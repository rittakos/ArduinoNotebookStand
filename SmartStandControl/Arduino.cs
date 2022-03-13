using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arduinoControlTest
{
    class Arduino
    {
        private bool connected;
        private SerialPort serialPort;
        private string port;
        public string Port { get { return port; } set { port = value; } }

        private System.Drawing.Color stripColor;
        public System.Drawing.Color StrokeColor { get { return stripColor; } set { stripColor = value; } }

        public bool isConnected() { return connected; }

        public Arduino(SerialPort serialPort)
        {
            connected = false;
            port = "COM4";
            this.serialPort = serialPort;
            this.serialPort.PortName = port;
        }

        public bool sendMessage(string message)
        {
            if(!connected)
                return false;
            try
            {
                serialPort.WriteLine(message);
                return true;
            } catch { return false; }
        }

        public void Connect()
        {
            if (!connected)
            {
                try
                {
                    serialPort.Open();
                    connected = true;
                } catch { throw new Exception("Couldn't connect!"); }
            }
            else
            {
                serialPort.Close();
                connected = false;
            }
        }

        ~Arduino()
        {
            if(connected)
                serialPort.Close();
        }
    }
}
