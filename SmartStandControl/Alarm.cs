using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arduinoControlTest
{
    enum Repeat
    {
        NEVER,
        DAILY,
        WEEKLY,
        WEEKDAY,
        WEEKEND,
        MONTHLY,
        YEARLY
    }

    struct AlarmItem
    {
        public string name;
        public string message;
        public DateTime time;

        public bool noise;
        public bool ligth;
        public bool onArduino;

        public Repeat repeat;

        public override string ToString()
        {
            string text = "CreateAlarm:";
            text += message + ":";
            text += time.Year + ":";
            text += time.Month + ":";
            text += time.Day + ":";
            text += time.Hour + ":";
            text += time.Minute + ":";
            text += noise + ":";
            text += ligth + ":";
            text += repeat;
            return text;
        }

        public AlarmItem(string name, DateTime time, bool noise, bool ligth, bool onArduino, Repeat repeat, string message = "")
        {
            this.name = name;
            this.message = message;
            this.time = time;

            this.noise = noise;
            this.ligth = ligth;
            this.onArduino = onArduino;
            this.repeat = repeat;
        }
    }

    internal class Alarm
    {
        private const string filePath = "";

        public List<AlarmItem> items;
        public List<ListViewItem> listViewItems;

        public Alarm() 
        {
            items = new List<AlarmItem>();
            listViewItems = new List<ListViewItem>();
        }

        ~Alarm()
        {
            Save();
        }

        public void Load(string path = filePath)
        {
            AddItem(new AlarmItem());
        }

        public void Save(string path = filePath)
        {

        }

        public void AddItem(AlarmItem item)
        {
            items.Add(item);
            listViewItems.Add(new ListViewItem(new string[] { item.name, item.time.ToString() }));
        }
    }
}
