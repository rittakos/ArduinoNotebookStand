using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arduinoControlTest
{
    public partial class Form1 : Form
    {      
        Alarm alarm = new Alarm();
        Arduino arduino;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            arduino = new Arduino(serialPort1);

            alarm_dateTimePicker.Format = DateTimePickerFormat.Custom;
            alarm_dateTimePicker.CustomFormat = "HH:mm tt";
            alarm_dateTimePicker.Value = DateTime.Now.Date;

            alarmRepeat_comboBox.DataSource = Enum.GetValues(typeof(Repeat));

            alarms_listView.View = View.Details;
            alarms_listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            alarms_listView.Columns.Add("Name");
            alarms_listView.Columns.Add("Time");
            
            update();
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            //string s = serialPort1.ReadExisting();//reads the serialport buffer
            //if (s.Contains("state="))//checks if it is status
            //{
            //    s=s.Trim();
            //    string new_s = s.Replace("state=", "");
            //    if (new_s.Contains("0"))
            //    {
            //        status = false;
            //        button1.Invoke(this.myDelegate_button, new Object[] { "ON" });//sets button text to on
            //    }
            //    else
            //    {
            //        status = true;
            //        button1.Invoke(this.myDelegate_button, new Object[] { "OFF" });//sets button text to off
            //    }
            //}
            //else
            //{
            //    //richTextBox1.Invoke(this.myDelegate, new Object[] { s });//adds the recieved bytes to the richtextbox
            //}
        }

        private void color_button_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.AllowFullOpen = true;
            colorDialog.ShowHelp = true;
            colorDialog.Color = color_button.BackColor;

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                arduino.StrokeColor = colorDialog.Color;
                color_button.BackColor =  colorDialog.Color;
            }
        }

        private void connection_button_Click(object sender, EventArgs e)
        {
            try
            {
                arduino.Connect();
            }catch
            {
                label2.Text = "Could not Connect!";
            }

            update();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void setPort_button_Click(object sender, EventArgs e)
        {
            arduino.Port = textBox2.Text;
        }

        private void update()
        {
            if (arduino.isConnected())
            {
                connection_button.Text = "Disconnect";
                label2.Text = "Connected";
                label2.ForeColor = Color.Green;
            }
            else
            {
                connection_button.Text = "Connect";
                label2.Text = "Not Connected";
                label2.ForeColor = Color.Red;
            }
        }

        private void sendColor_button_Click(object sender, EventArgs e)
        {
            string color = "Color:" + color_button.BackColor.R.ToString() + ":" + color_button.BackColor.G.ToString() + ":" + color_button.BackColor.B.ToString();
            arduino.sendMessage(color);
        }

        private void createAlarm_button_Click(object sender, EventArgs e)
        {
            AlarmItem alarmItem = new AlarmItem(alarmName_textBox.Text,
                                                alarm_dateTimePicker.Value,
                                                alarmNoise_checkBox.Checked,
                                                alarmLight_checkBox.Checked,
                                                alarmOnArduino_checkBox.Checked,
                                                Repeat.NEVER);
            alarm.AddItem(alarmItem);

            alarms_listView.Items.Add(alarm.listViewItems.Last());
            alarms_listView.Refresh();

            if(alarmItem.onArduino)
                arduino.sendMessage(alarmItem.ToString());
        }

        private void deletAlarm_button_Click(object sender, EventArgs e)
        {
            for (int i = alarms_listView.Items.Count - 1; i >= 0; i--)
            {
                if (alarms_listView.Items[i].Selected)
                {
                    alarm.listViewItems.Remove(alarms_listView.Items[i]);
                    alarms_listView.Items[i].Remove();
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            foreach (AlarmItem item in alarm.items)
            {
                DateTime now = DateTime.Now;
                if (now.Hour == item.time.Hour && now.Minute == item.time.Minute)
                {
                    listBox1.BackColor = Color.Red;
                    arduino.sendMessage("Alarm:Szia!:" + item.noise + ":" + item.ligth + ':' + item.onArduino);
                    return;
                }
            }
            listBox1.BackColor = Color.White;
        }

        private void setTime_button_Click(object sender, EventArgs e)
        {
            arduino.sendMessage("Time:::::");
        }
    }
}
