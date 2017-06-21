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
            notifyIcon1.ContextMenuStrip = contextMenuStrip1;
        }
        private void splashStart()
        {
            Application.Run(new SplashScreen());
        }

        private void weather_Load(object sender, EventArgs e)
        {

        }
        private void weather_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.ShowInTaskbar = false;
            }
            else
            {
                this.ShowInTaskbar = true;
            }
        }
        private void weather_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (e.CloseReason != CloseReason.TaskManagerClosing &&
                e.CloseReason != CloseReason.WindowsShutDown)
                e.Cancel = true;
            this.WindowState = FormWindowState.Minimized;

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
                conditionlbl.Text = "Condition: " + " " + Condition;
                windlbl.Text = "Wind Speed: " + " " + WindSpeed + " " + "m/hr";
                string[] Forecast = new string[5];
                int i = 0;
            foreach (XmlNode node in data.SelectNodes("//results/channel/item/yweather:forecast", manager))
            {
                
                if (i <= 4)
                {
                    Forecast[i] = node.Attributes["date"].Value + "," + node.Attributes["high"].Value;
                     i++;
                }

            }
            Debug.WriteLine("constructor fired");
            try
            {
                // Open the connection and execute command (query
                string myquerystring;
                conn.Open();
                cmd.Connection = conn;
                foreach(string forecast in Forecast)
                {
                    string[] split = forecast.Split(',');
                    myquerystring = "INSERT INTO weather VALUES(NULL, '" + City + "', '" + split[0] + "', '" + split[1] + "')";
                    MessageBox.Show(myquerystring);
                    cmd.CommandText = myquerystring;
                    cmd.ExecuteNonQuery();
                }
                
                cmd.ExecuteNonQuery();
                MessageBox.Show("Row Inserted into database successfully!",
                "Success!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                // Close connection
                conn.Close();

            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                // Show error
                MessageBox.Show(ex.Message);
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

        private void closeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            notifyIcon1.Dispose();
            Application.Exit();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                Hide();
                WindowState = FormWindowState.Minimized;
            }
            else
            {
                Show();
                WindowState = FormWindowState.Normal;
            }
           
        }
        private void minimizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;  //minimize button at Stip menu

            if (FormWindowState.Minimized == this.WindowState)
            {
                notifyIcon1.Visible = true;
                notifyIcon1.ShowBalloonTip(500);
                this.Hide();
            }

            else if (FormWindowState.Normal == this.WindowState)
            {
                notifyIcon1.Visible = false;
            }


        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.tabControl1.SelectedTab = tabPage3; //show tab3:  Options 
        }
    }
}
