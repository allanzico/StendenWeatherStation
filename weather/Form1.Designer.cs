﻿namespace weather
{
    partial class weather
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(weather));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.datelbl = new System.Windows.Forms.Label();
            this.conditionlbl = new System.Windows.Forms.Label();
            this.windlbl = new System.Windows.Forms.Label();
            this.temperaturelbl = new System.Windows.Forms.Label();
            this.citylbl = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.okbtn = new System.Windows.Forms.Button();
            this.celsiusRadio = new System.Windows.Forms.RadioButton();
            this.fahrenheitRadio = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.intervaltxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.citytxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(2, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(431, 328);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(423, 302);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Current";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.datelbl);
            this.groupBox1.Controls.Add(this.conditionlbl);
            this.groupBox1.Controls.Add(this.windlbl);
            this.groupBox1.Controls.Add(this.temperaturelbl);
            this.groupBox1.Controls.Add(this.citylbl);
            this.groupBox1.Location = new System.Drawing.Point(9, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(403, 220);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Current Weather";
            // 
            // datelbl
            // 
            this.datelbl.AutoSize = true;
            this.datelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datelbl.Location = new System.Drawing.Point(146, 28);
            this.datelbl.Name = "datelbl";
            this.datelbl.Size = new System.Drawing.Size(33, 15);
            this.datelbl.TabIndex = 4;
            this.datelbl.Text = "Date";
            // 
            // conditionlbl
            // 
            this.conditionlbl.AutoSize = true;
            this.conditionlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conditionlbl.Location = new System.Drawing.Point(31, 144);
            this.conditionlbl.Name = "conditionlbl";
            this.conditionlbl.Size = new System.Drawing.Size(64, 16);
            this.conditionlbl.TabIndex = 3;
            this.conditionlbl.Text = "Condition";
            // 
            // windlbl
            // 
            this.windlbl.AutoSize = true;
            this.windlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windlbl.Location = new System.Drawing.Point(31, 117);
            this.windlbl.Name = "windlbl";
            this.windlbl.Size = new System.Drawing.Size(39, 16);
            this.windlbl.TabIndex = 2;
            this.windlbl.Text = "Wind";
            // 
            // temperaturelbl
            // 
            this.temperaturelbl.AutoSize = true;
            this.temperaturelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temperaturelbl.Location = new System.Drawing.Point(29, 85);
            this.temperaturelbl.Name = "temperaturelbl";
            this.temperaturelbl.Size = new System.Drawing.Size(44, 16);
            this.temperaturelbl.TabIndex = 1;
            this.temperaturelbl.Text = "Temp";
            this.temperaturelbl.Click += new System.EventHandler(this.temperaturelbl_Click);
            // 
            // citylbl
            // 
            this.citylbl.AutoSize = true;
            this.citylbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.citylbl.Location = new System.Drawing.Point(24, 25);
            this.citylbl.Name = "citylbl";
            this.citylbl.Size = new System.Drawing.Size(39, 20);
            this.citylbl.TabIndex = 0;
            this.citylbl.Text = "City";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.chart1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(423, 302);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Trend";
            // 
            // chart1
            // 
            chartArea5.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chart1.Legends.Add(legend5);
            this.chart1.Location = new System.Drawing.Point(6, 1);
            this.chart1.Name = "chart1";
            this.chart1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.IsValueShownAsLabel = true;
            series5.Legend = "Legend1";
            series5.LegendText = "Degrees C";
            series5.Name = "Temp";
            series5.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
            this.chart1.Series.Add(series5);
            this.chart1.Size = new System.Drawing.Size(427, 300);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click_1);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(423, 302);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Options";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.okbtn);
            this.groupBox2.Controls.Add(this.celsiusRadio);
            this.groupBox2.Controls.Add(this.fahrenheitRadio);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.intervaltxt);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.citytxt);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(27, 90);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(372, 186);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Options";
            // 
            // okbtn
            // 
            this.okbtn.Location = new System.Drawing.Point(226, 144);
            this.okbtn.Name = "okbtn";
            this.okbtn.Size = new System.Drawing.Size(75, 23);
            this.okbtn.TabIndex = 8;
            this.okbtn.Text = "OK";
            this.okbtn.UseVisualStyleBackColor = true;
            this.okbtn.Click += new System.EventHandler(this.okbtn_Click);
            // 
            // celsiusRadio
            // 
            this.celsiusRadio.AutoSize = true;
            this.celsiusRadio.Checked = true;
            this.celsiusRadio.Location = new System.Drawing.Point(97, 101);
            this.celsiusRadio.Name = "celsiusRadio";
            this.celsiusRadio.Size = new System.Drawing.Size(58, 17);
            this.celsiusRadio.TabIndex = 7;
            this.celsiusRadio.TabStop = true;
            this.celsiusRadio.Text = "Celsius";
            this.celsiusRadio.UseVisualStyleBackColor = true;
            this.celsiusRadio.CheckedChanged += new System.EventHandler(this.celsiusRadio_CheckedChanged);
            // 
            // fahrenheitRadio
            // 
            this.fahrenheitRadio.AutoSize = true;
            this.fahrenheitRadio.Location = new System.Drawing.Point(174, 101);
            this.fahrenheitRadio.Name = "fahrenheitRadio";
            this.fahrenheitRadio.Size = new System.Drawing.Size(75, 17);
            this.fahrenheitRadio.TabIndex = 6;
            this.fahrenheitRadio.TabStop = true;
            this.fahrenheitRadio.Text = "Fahrenheit";
            this.fahrenheitRadio.UseVisualStyleBackColor = true;
            this.fahrenheitRadio.CheckedChanged += new System.EventHandler(this.fahrenheitRadio_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Temperature";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(138, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "[ seconds ]";
            // 
            // intervaltxt
            // 
            this.intervaltxt.Location = new System.Drawing.Point(97, 66);
            this.intervaltxt.Name = "intervaltxt";
            this.intervaltxt.Size = new System.Drawing.Size(35, 20);
            this.intervaltxt.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Interval";
            // 
            // citytxt
            // 
            this.citytxt.Location = new System.Drawing.Point(97, 35);
            this.citytxt.Name = "citytxt";
            this.citytxt.Size = new System.Drawing.Size(152, 20);
            this.citytxt.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "City";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.refreshToolStripMenuItem1,
            this.optionsToolStripMenuItem,
            this.openToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(117, 136);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click_1);
            // 
            // refreshToolStripMenuItem1
            // 
            this.refreshToolStripMenuItem1.Name = "refreshToolStripMenuItem1";
            this.refreshToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.refreshToolStripMenuItem1.Text = "Refresh";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.optionsToolStripMenuItem.Text = "Options";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Stenden Weather";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // weather
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 331);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "weather";
            this.Text = "StendenWeatherStation";
            this.Load += new System.EventHandler(this.weather_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label conditionlbl;
        private System.Windows.Forms.Label windlbl;
        private System.Windows.Forms.Label temperaturelbl;
        private System.Windows.Forms.Label citylbl;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button okbtn;
        private System.Windows.Forms.RadioButton celsiusRadio;
        private System.Windows.Forms.RadioButton fahrenheitRadio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox intervaltxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox citytxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label datelbl;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

