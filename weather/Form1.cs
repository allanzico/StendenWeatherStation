using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.IO;
using System.Web;
using System.Xml;
using System.Diagnostics;
using System.Timers;
using System.Threading;
using System.Net;
using System.Data.SqlClient;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms.DataVisualization.Charting;

namespace weather
{
    public partial class weather : Form
    {
        private string Temperature;
        private string Condition;
        private string WindSpeed;
        private string City;
        private int Interval;
        private string Date;
        private string ConvertTemperature;
        public string LastUpdate;
        public System.Windows.Forms.Timer aTimer;
        private Boolean celsius = true;
        private MySql.Data.MySqlClient.MySqlConnection conn;
        private MySql.Data.MySqlClient.MySqlCommand cmd;
        private DataTable datatable = new DataTable();
        private MySqlDataAdapter adapter;
        public weather()
        {
            Thread t = new Thread(new ThreadStart(splashStart));
            t.Start();
            Thread.Sleep(5000);
            InitializeComponent();
            t.Abort();
            City = "Emmen";
            Interval = 60;
            conn = new MySql.Data.MySqlClient.MySqlConnection();
            cmd = new MySql.Data.MySqlClient.MySqlCommand();
            // Set connection / query
            conn.ConnectionString = "server=localhost;uid=root;pwd=;database=FinalAssignment;";
            aTimer = new System.Windows.Forms.Timer();
            aTimer.Interval = Interval;
            aTimer.Tick += new EventHandler(OnTimedEvent);
            aTimer.Start();
            getWeather();
            
        }
        private void splashStart()
        {
            Application.Run(new SplashScreen());
        }

        private void weather_Load(object sender, EventArgs e)
        {

        }
       

        //Get Weather from Yahoo API
        private void getWeather()
        {

            string query = "select * from weather.forecast where woeid  in (select woeid from geo.places(1) where text='" + City + ", NL')";
            string path = "https://query.yahooapis.com/v1/public/yql?q=" + query + "&format=xml";
            XmlDocument data = new XmlDocument();
            data.Load(path);
            XmlNamespaceManager manager = new XmlNamespaceManager(data.NameTable);
            manager.AddNamespace("yweather", "http://xml.weather.yahoo.com/ns/rss/1.0");
            //Get data from XML document and acquire weather details
            XmlNode channel = data.SelectSingleNode("//results/channel/item/yweather:condition", manager);
            if (channel.Attributes["temp"].Value != null)
            {
                Temperature = channel.Attributes["temp"].Value;
                ConvertTemperature = Math.Round(((int.Parse(Temperature) - 32) / 1.8), 0).ToString();  //Convert Temperature from Celcius to Farhnheit
                Condition = channel.Attributes["text"].Value;
                //Date = channel.Attributes["date"].Value;
                Date = data.SelectSingleNode("//results/channel/lastBuildDate", manager).InnerText;
                WindSpeed = data.SelectSingleNode("//results/channel/yweather:wind", manager).Attributes["speed"].Value;
                City = data.SelectSingleNode("//results/channel/yweather:location", manager).Attributes["city"].Value;
                intervaltxt.Text = Interval.ToString();
                citylbl.Text = City;
                datelbl.Text = Date;
                temperaturelbl.Text = celsius ? ConvertTemperature += " ° C" : Temperature += "° F";
                chart1.Series[0].LegendText = celsius ? " ° C" : "° F";
                conditionlbl.Text = "Condition: " + " " + Condition;
                windlbl.Text = "Wind Speed: " + " " + WindSpeed + " " + "m/hr";
                string[] Forecast = new string[9];
                int i = 0;
                foreach (XmlNode node in data.SelectNodes("//results/channel/item/yweather:forecast", manager))
                {
                    if (i < data.SelectNodes("//results/channel/item/yweather:forecast", manager).Count - 1)
                    {
                        Forecast[i] = node.Attributes["date"].Value + "," + node.Attributes["high"].Value;
                        i++;
                    }
                }
                Debug.WriteLine("constructor fired");
                try
                {
                    // Open the connection and execute command (query
                    conn.Open();
                    cmd.Connection = conn;
                    string deleteQuery = "truncate weather";
                    cmd.CommandText = deleteQuery;
                    cmd.ExecuteNonQuery();
                    string myquerystring;

                    for (int x = 0; x < 5; x++)
                    {
                        string[] split = Forecast[x].Split(',');
                        myquerystring = "INSERT INTO weather VALUES(NULL, '" + City + "', '" + split[0] + "', '" + split[1] + "')";
                        cmd.CommandText = myquerystring;
                        cmd.ExecuteNonQuery();
                    }
                    // Close connection
                    conn.Close();

                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    // Show error
                    MessageBox.Show(ex.Message);
                }
                string selectQuery = celsius ? ("SELECT date,(temperature-32)*5/9 AS temperature FROM weather") : ("SELECT * FROM weather");
                try
                {
                    conn.Open();
                    cmd.Connection = conn;
                    cmd.CommandText = selectQuery;
                    adapter = new MySqlDataAdapter(cmd);
                    datatable.Clear();
                    adapter.Fill(datatable);
                    conn.Close();

                }
                catch (MySqlException ex)
                {
                    Debug.WriteLine(ex.Message);
                }

                chart1.Series["Temp"].Points.Clear();
                chart1.DataSource = datatable;
                chart1.Series["Temp"].XValueMember = "date";
                chart1.Series["Temp"].YValueMembers = "temperature";
                chart1.DataBind();
            }

        }


        private static XmlNamespaceManager NewMethod(XmlDocument data)
        {
            return new XmlNamespaceManager(data.NameTable);
        }

        private void temperaturelbl_Click(object sender, EventArgs e)
        {

        }

        private void citytxt_TextChanged(object sender, EventArgs e)
        {
            getWeather();
            citytxt.AppendText(City);
        }

        private void okbtn_Click(object sender, EventArgs e)
        {

            citylbl.Text = citytxt.Text;
            City = citytxt.Text;
            Interval = int.Parse(intervaltxt.Text);
            getWeather();
            aTimer.Stop();
            aTimer.Interval = Interval;
            aTimer.Start();
        }

        private void fahrenheitRadio_CheckedChanged(object sender, EventArgs e)
        {
            temperaturelbl.Text = Temperature += " ° F";
            celsius = false;
        }

        private void celsiusRadio_CheckedChanged(object sender, EventArgs e)
        {
            temperaturelbl.Text = ConvertTemperature += " ° C";
            celsius = true;
        }
        private void OnTimedEvent(object source, EventArgs e)

        {
            try
            {
                string query = "select * from weather.forecast where woeid  in (select woeid from geo.places(1) where text='" + City + ", NL')";
                string path = "https://query.yahooapis.com/v1/public/yql?q=" + query + "&format=xml";
                XmlDocument data = new XmlDocument();
                data.Load(path);
                XmlNamespaceManager manager = new XmlNamespaceManager(data.NameTable);
                manager.AddNamespace("yweather", "http://xml.weather.yahoo.com/ns/rss/1.0");
                //Get data from XML document and acquire weather details
                XmlNode channel = data.SelectSingleNode("//results/channel/item/yweather:condition", manager);
                if (channel.Attributes["temp"].Value != null)
                {
                    Temperature = channel.Attributes["temp"].Value;
                    ConvertTemperature = Math.Round(((int.Parse(Temperature) - 32) / 1.8), 0).ToString();  //Convert Temperature from Celcius to Farhnheit
                    Condition = channel.Attributes["text"].Value;
                    //Date = channel.Attributes["date"].Value;
                    Date = data.SelectSingleNode("//results/channel/lastBuildDate", manager).InnerText;
                    WindSpeed = data.SelectSingleNode("//results/channel/yweather:wind", manager).Attributes["speed"].Value;
                    City = data.SelectSingleNode("//results/channel/yweather:location", manager).Attributes["city"].Value;
                    datelbl.Text = Date;
                    temperaturelbl.Text = celsius ? ConvertTemperature += " ° C" : Temperature += "° F";
                    conditionlbl.Text = "Condition: " + " " + Condition;
                    windlbl.Text = "Wind Speed: " + " " + WindSpeed + " " + "m/hr";
                }
            }
            catch (WebException exp)
            {
                if (exp.Status == WebExceptionStatus.ProtocolError &&
                exp.Response != null)
                {
                    var webres = (HttpWebResponse)exp.Response;

                }
            }

        }
        public void SQL()
        {


        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            about a = new about();
            a.Show();

        }

        

        

       
        private void chart1_Click_1(object sender, EventArgs e)
        {



        }

        private void aboutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            about a = new about();
            a.Show();
            
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
            tabControl1.SelectTab(2);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void weather_SizeChanged(object sender, EventArgs e)
        {

        }
        private void weather_FormClosing(object sender, FormClosingEventArgs e)
        {

            e.Cancel = true;
            notifyIcon1.Visible = true;
            this.Hide();

        }
        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
        }
    }
}
