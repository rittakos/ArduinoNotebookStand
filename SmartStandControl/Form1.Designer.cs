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
            this.connection_button = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.sendColor_button = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.color_button = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.setTimeOnButton_checkBox = new System.Windows.Forms.CheckBox();
            this.setTime_button = new System.Windows.Forms.Button();
            this.time_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.setPort_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.alarm_tabPage = new System.Windows.Forms.TabPage();
            this.deletAlarm_button = new System.Windows.Forms.Button();
            this.alarmRepeat_comboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.alarms_listView = new System.Windows.Forms.ListView();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.alarm_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.alarmName_textBox = new System.Windows.Forms.TextBox();
            this.alarmLight_checkBox = new System.Windows.Forms.CheckBox();
            this.alarmNoise_checkBox = new System.Windows.Forms.CheckBox();
            this.alarmOnArduino_checkBox = new System.Windows.Forms.CheckBox();
            this.createAlarm_button = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
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
            this.tabPage1.Controls.Add(this.connection_button);
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
            // connection_button
            // 
            this.connection_button.Location = new System.Drawing.Point(9, 19);
            this.connection_button.Name = "connection_button";
            this.connection_button.Size = new System.Drawing.Size(98, 23);
            this.connection_button.TabIndex = 0;
            this.connection_button.Text = "Connect";
            this.connection_button.UseVisualStyleBackColor = true;
            this.connection_button.Click += new System.EventHandler(this.connection_button_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.sendColor_button);
            this.tabPage2.Controls.Add(this.trackBar1);
            this.tabPage2.Controls.Add(this.color_button);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 421);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Color";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // sendColor_button
            // 
            this.sendColor_button.Location = new System.Drawing.Point(30, 150);
            this.sendColor_button.Name = "sendColor_button";
            this.sendColor_button.Size = new System.Drawing.Size(109, 79);
            this.sendColor_button.TabIndex = 7;
            this.sendColor_button.Text = "Send";
            this.sendColor_button.UseVisualStyleBackColor = true;
            this.sendColor_button.Click += new System.EventHandler(this.sendColor_button_Click);
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
            // color_button
            // 
            this.color_button.Location = new System.Drawing.Point(21, 31);
            this.color_button.Name = "color_button";
            this.color_button.Size = new System.Drawing.Size(109, 94);
            this.color_button.TabIndex = 1;
            this.color_button.Text = "Choose Color";
            this.color_button.UseVisualStyleBackColor = true;
            this.color_button.Click += new System.EventHandler(this.color_button_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.setTimeOnButton_checkBox);
            this.tabPage3.Controls.Add(this.setTime_button);
            this.tabPage3.Controls.Add(this.time_dateTimePicker);
            this.tabPage3.Controls.Add(this.setPort_button);
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
            // setTimeOnButton_checkBox
            // 
            this.setTimeOnButton_checkBox.AutoSize = true;
            this.setTimeOnButton_checkBox.Location = new System.Drawing.Point(301, 65);
            this.setTimeOnButton_checkBox.Name = "setTimeOnButton_checkBox";
            this.setTimeOnButton_checkBox.Size = new System.Drawing.Size(120, 20);
            this.setTimeOnButton_checkBox.TabIndex = 5;
            this.setTimeOnButton_checkBox.Text = "on button press";
            this.setTimeOnButton_checkBox.UseVisualStyleBackColor = true;
            // 
            // setTime_button
            // 
            this.setTime_button.Location = new System.Drawing.Point(427, 65);
            this.setTime_button.Name = "setTime_button";
            this.setTime_button.Size = new System.Drawing.Size(75, 23);
            this.setTime_button.TabIndex = 4;
            this.setTime_button.Text = "Set Time";
            this.setTime_button.UseVisualStyleBackColor = true;
            this.setTime_button.Click += new System.EventHandler(this.setTime_button_Click);
            // 
            // time_dateTimePicker
            // 
            this.time_dateTimePicker.Location = new System.Drawing.Point(301, 28);
            this.time_dateTimePicker.Name = "time_dateTimePicker";
            this.time_dateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.time_dateTimePicker.TabIndex = 3;
            // 
            // setPort_button
            // 
            this.setPort_button.Location = new System.Drawing.Point(20, 53);
            this.setPort_button.Name = "setPort_button";
            this.setPort_button.Size = new System.Drawing.Size(151, 43);
            this.setPort_button.TabIndex = 2;
            this.setPort_button.Text = "Set Port";
            this.setPort_button.UseVisualStyleBackColor = true;
            this.setPort_button.Click += new System.EventHandler(this.setPort_button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Port:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(71, 25);
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
            // deletAlarm_button
            // 
            this.deletAlarm_button.Location = new System.Drawing.Point(680, 270);
            this.deletAlarm_button.Name = "deletAlarm_button";
            this.deletAlarm_button.Size = new System.Drawing.Size(75, 70);
            this.deletAlarm_button.TabIndex = 10;
            this.deletAlarm_button.Text = "Delete";
            this.deletAlarm_button.UseVisualStyleBackColor = true;
            this.deletAlarm_button.Click += new System.EventHandler(this.deletAlarm_button_Click);
            // 
            // alarmRepeat_comboBox
            // 
            this.alarmRepeat_comboBox.FormattingEnabled = true;
            this.alarmRepeat_comboBox.Location = new System.Drawing.Point(84, 99);
            this.alarmRepeat_comboBox.Name = "alarmRepeat_comboBox";
            this.alarmRepeat_comboBox.Size = new System.Drawing.Size(172, 24);
            this.alarmRepeat_comboBox.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Repeat: ";
            // 
            // alarms_listView
            // 
            this.alarms_listView.HideSelection = false;
            this.alarms_listView.Location = new System.Drawing.Point(363, 227);
            this.alarms_listView.Name = "alarms_listView";
            this.alarms_listView.Size = new System.Drawing.Size(271, 148);
            this.alarms_listView.TabIndex = 7;
            this.alarms_listView.UseCompatibleStateImageBehavior = false;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(23, 227);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(316, 148);
            this.listBox1.TabIndex = 6;
            // 
            // alarm_dateTimePicker
            // 
            this.alarm_dateTimePicker.Location = new System.Drawing.Point(23, 61);
            this.alarm_dateTimePicker.Name = "alarm_dateTimePicker";
            this.alarm_dateTimePicker.Size = new System.Drawing.Size(233, 22);
            this.alarm_dateTimePicker.TabIndex = 5;
            // 
            // alarmName_textBox
            // 
            this.alarmName_textBox.Location = new System.Drawing.Point(23, 21);
            this.alarmName_textBox.Name = "alarmName_textBox";
            this.alarmName_textBox.Size = new System.Drawing.Size(233, 22);
            this.alarmName_textBox.TabIndex = 4;
            // 
            // alarmLight_checkBox
            // 
            this.alarmLight_checkBox.AutoSize = true;
            this.alarmLight_checkBox.Location = new System.Drawing.Point(483, 98);
            this.alarmLight_checkBox.Name = "alarmLight_checkBox";
            this.alarmLight_checkBox.Size = new System.Drawing.Size(172, 20);
            this.alarmLight_checkBox.TabIndex = 3;
            this.alarmLight_checkBox.Text = "turn on lights (on device)";
            this.alarmLight_checkBox.UseVisualStyleBackColor = true;
            // 
            // alarmNoise_checkBox
            // 
            this.alarmNoise_checkBox.AutoSize = true;
            this.alarmNoise_checkBox.Location = new System.Drawing.Point(483, 61);
            this.alarmNoise_checkBox.Name = "alarmNoise_checkBox";
            this.alarmNoise_checkBox.Size = new System.Drawing.Size(169, 20);
            this.alarmNoise_checkBox.TabIndex = 2;
            this.alarmNoise_checkBox.Text = "make noise (on device)";
            this.alarmNoise_checkBox.UseVisualStyleBackColor = true;
            // 
            // alarmOnArduino_checkBox
            // 
            this.alarmOnArduino_checkBox.AutoSize = true;
            this.alarmOnArduino_checkBox.Location = new System.Drawing.Point(483, 23);
            this.alarmOnArduino_checkBox.Name = "alarmOnArduino_checkBox";
            this.alarmOnArduino_checkBox.Size = new System.Drawing.Size(129, 20);
            this.alarmOnArduino_checkBox.TabIndex = 1;
            this.alarmOnArduino_checkBox.Text = "upload to device";
            this.alarmOnArduino_checkBox.UseVisualStyleBackColor = true;
            // 
            // createAlarm_button
            // 
            this.createAlarm_button.Location = new System.Drawing.Point(289, 133);
            this.createAlarm_button.Name = "createAlarm_button";
            this.createAlarm_button.Size = new System.Drawing.Size(127, 56);
            this.createAlarm_button.TabIndex = 0;
            this.createAlarm_button.Text = "Create";
            this.createAlarm_button.UseVisualStyleBackColor = true;
            this.createAlarm_button.Click += new System.EventHandler(this.createAlarm_button_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
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
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button color_button;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button connection_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button setPort_button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button sendColor_button;
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
        private System.Windows.Forms.Button setTime_button;
        private System.Windows.Forms.CheckBox setTimeOnButton_checkBox;
    }
}

