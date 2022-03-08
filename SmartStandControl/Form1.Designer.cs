namespace arduinoControlTest
{
    partial class Form1
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
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.time_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.button4 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.alarm_tabPage = new System.Windows.Forms.TabPage();
            this.createAlarm_button = new System.Windows.Forms.Button();
            this.alarmOnArduino_checkBox = new System.Windows.Forms.CheckBox();
            this.alarmNoise_checkBox = new System.Windows.Forms.CheckBox();
            this.alarmLight_checkBox = new System.Windows.Forms.CheckBox();
            this.alarmName_textBox = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.alarm_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.alarms_listView = new System.Windows.Forms.ListView();
            this.label4 = new System.Windows.Forms.Label();
            this.alarmRepeat_comboBox = new System.Windows.Forms.ComboBox();
            this.deletAlarm_button = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.alarm_tabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 115200;
            this.serialPort1.PortName = "COM4";
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.alarm_tabPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 421);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Home";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(170, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Not connected";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Status: ";
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(9, 66);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 1;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(9, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "Connect";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.trackBar1);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 421);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Color";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(21, 174);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(109, 79);
            this.button5.TabIndex = 7;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(146, 35);
            this.textBox1.Margin = new System.Windows.Forms.Padding(0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(626, 22);
            this.textBox1.TabIndex = 6;
            // 
            // trackBar1
            // 
            this.trackBar1.LargeChange = 0;
            this.trackBar1.Location = new System.Drawing.Point(146, 69);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(626, 56);
            this.trackBar1.TabIndex = 5;
            this.trackBar1.Value = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 94);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.time_dateTimePicker);
            this.tabPage3.Controls.Add(this.button4);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.textBox2);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(792, 421);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Settings";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // time_dateTimePicker
            // 
            this.time_dateTimePicker.Location = new System.Drawing.Point(20, 98);
            this.time_dateTimePicker.Name = "time_dateTimePicker";
            this.time_dateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.time_dateTimePicker.TabIndex = 3;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(177, 42);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 2;
            this.button4.Text = "Set Port";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Port:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(57, 40);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 0;
            this.textBox2.Text = "COM4";
            // 
            // alarm_tabPage
            // 
            this.alarm_tabPage.Controls.Add(this.deletAlarm_button);
            this.alarm_tabPage.Controls.Add(this.alarmRepeat_comboBox);
            this.alarm_tabPage.Controls.Add(this.label4);
            this.alarm_tabPage.Controls.Add(this.alarms_listView);
            this.alarm_tabPage.Controls.Add(this.listBox1);
            this.alarm_tabPage.Controls.Add(this.alarm_dateTimePicker);
            this.alarm_tabPage.Controls.Add(this.alarmName_textBox);
            this.alarm_tabPage.Controls.Add(this.alarmLight_checkBox);
            this.alarm_tabPage.Controls.Add(this.alarmNoise_checkBox);
            this.alarm_tabPage.Controls.Add(this.alarmOnArduino_checkBox);
            this.alarm_tabPage.Controls.Add(this.createAlarm_button);
            this.alarm_tabPage.Location = new System.Drawing.Point(4, 25);
            this.alarm_tabPage.Name = "alarm_tabPage";
            this.alarm_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.alarm_tabPage.Size = new System.Drawing.Size(792, 421);
            this.alarm_tabPage.TabIndex = 3;
            this.alarm_tabPage.Text = "Alarm";
            this.alarm_tabPage.UseVisualStyleBackColor = true;
            // 
            // createAlarm_button
            // 
            this.createAlarm_button.Location = new System.Drawing.Point(207, 105);
            this.createAlarm_button.Name = "createAlarm_button";
            this.createAlarm_button.Size = new System.Drawing.Size(75, 23);
            this.createAlarm_button.TabIndex = 0;
            this.createAlarm_button.Text = "Create";
            this.createAlarm_button.UseVisualStyleBackColor = true;
            this.createAlarm_button.Click += new System.EventHandler(this.createAlarm_button_Click);
            // 
            // alarmOnArduino_checkBox
            // 
            this.alarmOnArduino_checkBox.AutoSize = true;
            this.alarmOnArduino_checkBox.Location = new System.Drawing.Point(23, 34);
            this.alarmOnArduino_checkBox.Name = "alarmOnArduino_checkBox";
            this.alarmOnArduino_checkBox.Size = new System.Drawing.Size(95, 20);
            this.alarmOnArduino_checkBox.TabIndex = 1;
            this.alarmOnArduino_checkBox.Text = "checkBox1";
            this.alarmOnArduino_checkBox.UseVisualStyleBackColor = true;
            // 
            // alarmNoise_checkBox
            // 
            this.alarmNoise_checkBox.AutoSize = true;
            this.alarmNoise_checkBox.Location = new System.Drawing.Point(23, 72);
            this.alarmNoise_checkBox.Name = "alarmNoise_checkBox";
            this.alarmNoise_checkBox.Size = new System.Drawing.Size(95, 20);
            this.alarmNoise_checkBox.TabIndex = 2;
            this.alarmNoise_checkBox.Text = "checkBox2";
            this.alarmNoise_checkBox.UseVisualStyleBackColor = true;
            // 
            // alarmLight_checkBox
            // 
            this.alarmLight_checkBox.AutoSize = true;
            this.alarmLight_checkBox.Location = new System.Drawing.Point(23, 108);
            this.alarmLight_checkBox.Name = "alarmLight_checkBox";
            this.alarmLight_checkBox.Size = new System.Drawing.Size(95, 20);
            this.alarmLight_checkBox.TabIndex = 3;
            this.alarmLight_checkBox.Text = "checkBox3";
            this.alarmLight_checkBox.UseVisualStyleBackColor = true;
            // 
            // alarmName_textBox
            // 
            this.alarmName_textBox.Location = new System.Drawing.Point(180, 32);
            this.alarmName_textBox.Name = "alarmName_textBox";
            this.alarmName_textBox.Size = new System.Drawing.Size(203, 22);
            this.alarmName_textBox.TabIndex = 4;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // alarm_dateTimePicker
            // 
            this.alarm_dateTimePicker.Location = new System.Drawing.Point(443, 34);
            this.alarm_dateTimePicker.Name = "alarm_dateTimePicker";
            this.alarm_dateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.alarm_dateTimePicker.TabIndex = 5;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(59, 206);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 84);
            this.listBox1.TabIndex = 6;
            // 
            // alarms_listView
            // 
            this.alarms_listView.HideSelection = false;
            this.alarms_listView.Location = new System.Drawing.Point(207, 206);
            this.alarms_listView.Name = "alarms_listView";
            this.alarms_listView.Size = new System.Drawing.Size(436, 97);
            this.alarms_listView.TabIndex = 7;
            this.alarms_listView.UseCompatibleStateImageBehavior = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(398, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Repeat: ";
            // 
            // alarmRepeat_comboBox
            // 
            this.alarmRepeat_comboBox.FormattingEnabled = true;
            this.alarmRepeat_comboBox.Location = new System.Drawing.Point(482, 99);
            this.alarmRepeat_comboBox.Name = "alarmRepeat_comboBox";
            this.alarmRepeat_comboBox.Size = new System.Drawing.Size(169, 24);
            this.alarmRepeat_comboBox.TabIndex = 9;
            // 
            // deletAlarm_button
            // 
            this.deletAlarm_button.Location = new System.Drawing.Point(681, 223);
            this.deletAlarm_button.Name = "deletAlarm_button";
            this.deletAlarm_button.Size = new System.Drawing.Size(75, 23);
            this.deletAlarm_button.TabIndex = 10;
            this.deletAlarm_button.Text = "Delete";
            this.deletAlarm_button.UseVisualStyleBackColor = true;
            this.deletAlarm_button.Click += new System.EventHandler(this.deletAlarm_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.alarm_tabPage.ResumeLayout(false);
            this.alarm_tabPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DateTimePicker time_dateTimePicker;
        private System.Windows.Forms.TabPage alarm_tabPage;
        private System.Windows.Forms.DateTimePicker alarm_dateTimePicker;
        private System.Windows.Forms.TextBox alarmName_textBox;
        private System.Windows.Forms.CheckBox alarmLight_checkBox;
        private System.Windows.Forms.CheckBox alarmNoise_checkBox;
        private System.Windows.Forms.CheckBox alarmOnArduino_checkBox;
        private System.Windows.Forms.Button createAlarm_button;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListView alarms_listView;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox alarmRepeat_comboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button deletAlarm_button;
    }
}

