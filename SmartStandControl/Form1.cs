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
        public delegate void AddDataDelegate(String myString);// Delegate for richtextbox
        public AddDataDelegate myDelegate;// An instance of AddDataDelegate
        public delegate void AddDataDelegate_button(String myString);// Delegate for button
        public AddDataDelegate_button myDelegate_button;// An instance of AddDataDelegate_button
        bool status = false;// LED status
        bool connected = false;
        Alarm alarm = new Alarm();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connected = false;
            serialPort1.PortName = "COM4";

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

        public void AddDataMethod_button(String myString)
        {
            button1.Text = myString;//changes button text
        }

        public void AddDataMethod(String myString)
        {
            //richTextBox1.Text = myString + Environment.NewLine;//changes richtextbox text
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            string s = serialPort1.ReadExisting();//reads the serialport buffer
            if (s.Contains("state="))//checks if it is status
            {
                s=s.Trim();
                string new_s = s.Replace("state=", "");
                if (new_s.Contains("0"))
                {
                    status = false;
                    button1.Invoke(this.myDelegate_button, new Object[] { "ON" });//sets button text to on
                }
                else
                {
                    status = true;
                    button1.Invoke(this.myDelegate_button, new Object[] { "OFF" });//sets button text to off
                }
            }
            else
            {
                //richTextBox1.Invoke(this.myDelegate, new Object[] { s });//adds the recieved bytes to the richtextbox
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            MyDialog.AllowFullOpen = true;
            MyDialog.ShowHelp = true;
            MyDialog.Color = textBox1.BackColor;
 
            if (MyDialog.ShowDialog() == DialogResult.OK)
                textBox1.BackColor =  MyDialog.Color;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(!connected)
            {
                try
                {
                    serialPort1.Open();
                    button2.Text = "Disconnect";
                    label2.Text = "Connected";
                    label2.ForeColor = Color.Green;
                    this.myDelegate = new AddDataDelegate(AddDataMethod);//Assigning "the function that changes richtextbox text" to the delegate
                    this.myDelegate_button = new AddDataDelegate_button(AddDataMethod_button);//Assigning "the function that changes button text" to the delegate
                    serialPort1.WriteLine("STATE");
                    connected = true;
                }
                catch { label2.Text = "Could not Connect!"; }
            } else
            {
                serialPort1.Close();
                button2.Text = "Connect";
                label2.Text = "Not Connected";
                label2.ForeColor = Color.Red;
                connected = false;
            }
            update();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text.Contains("ON"))
            {
                serialPort1.WriteLine("OFF");//sends off command when the previous state was on
                button3.Text = "OFF";
                status = false;
            }
            else
            {
                serialPort1.WriteLine("ON");//sends on command when the previous state was off
                button3.Text = "ON";
                status = true;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (connected)
                serialPort1.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            serialPort1.PortName = textBox2.Text;
        }

        private void update()
        {
            if(connected)
                button3.Enabled = true;
            else
                button3.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string color = "Color:" + textBox1.BackColor.R.ToString() + ":" + textBox1.BackColor.G.ToString() + ":" + textBox1.BackColor.B.ToString();
            serialPort1.WriteLine(color);
        }

        private void createAlarm_button_Click(object sender, EventArgs e)
        {
            alarm.AddItem(new AlarmItem(alarmName_textBox.Text,
                                        alarm_dateTimePicker.Value,
                                        alarmNoise_checkBox.Checked,
                                        alarmLight_checkBox.Checked,
                                        alarmOnArduino_checkBox.Checked,
                                        Repeat.NEVER));

            alarms_listView.Items.Add(alarm.listViewItems.Last());
            alarms_listView.Refresh();
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
            foreach(AlarmItem item in alarm.items)
            {
                DateTime now = DateTime.Now;
                if(now.Hour == item.time.Hour && now.Minute == item.time.Minute)
                {
                    listBox1.BackColor = Color.Red;
                    return;
                }
            }
            listBox1.BackColor = Color.White;
        }
    }
}
