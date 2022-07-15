using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TimeLog
{
    public class Event
    {
        public Event() { }
        public Event(DateTime startTime) 
        {
            this.StartTime = startTime;
        }
        public Event (DateTime startTime, DateTime endTime)
        {
            this.EndTime = endTime;
            this.StartTime = startTime;
        }
        public Event(string name, DateTime startTime, DateTime endTime)
        {
            this.Name = name;
            this.EndTime = endTime;
            this.StartTime = startTime;
        }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string DisplayEvent()
        {
            int j = 20 - this.Name.Length;
            string s = string.Empty;
            for (int i = 0; i < j; i++)
            {
                s += " ";
            }
            return this.Name + s +
                    this.StartTime.ToString("ddd") + " " +
                    this.StartTime.ToString("hh:mm tt") + "  -  " +
                    this.EndTime.ToString("hh:mm tt");// + " " +
                   // this.Duration.ToString("hh':'mm");
        }
        public string ButtonName()
        {
            return this.Name + this.StartTime.ToString();
        }
        
        [XmlAttribute]public string Name { get; set; }
        [XmlIgnore]public Color Color { get; set; }
        [XmlIgnore]public Color TextColor { get; set; }

        public TimeSpan Duration
        {
            get 
            {
                TimeSpan duration = EndTime - StartTime;
                return duration; 
            }
            
        }
        public int PanelLength
        {
            get
            {
                int length = (int) this.Duration.TotalMinutes;
                return length;


            }
        }

       

        public int GetAdjustedLocation(DateTime startDate, int hour, int min)
        {
           



            if (this.StartTime.Date > startDate.Date)
            {
                DateTime displayStart = new DateTime(startDate.Year, startDate.Month, startDate.Day, hour, min, 0);
                TimeSpan SinceDisplayStart = this.StartTime - displayStart;
                int location = (int) SinceDisplayStart.TotalMinutes;
                //location = location;// + 960;
                return location;

            }
            else
            {
                DateTime displayStart = new DateTime(startDate.Year, startDate.Month, startDate.Day, hour, min, 0);
                TimeSpan sinceDisplayStart = this.StartTime - displayStart;
                return (int)sinceDisplayStart.TotalMinutes;

            }

        }

        public static int GetNowDisplay(int hour, int min)
        {
            DateTime dt = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, hour, min, 0);
            
            TimeSpan sinceMidnight = DateTime.Now - dt;
            return (int)sinceMidnight.TotalMinutes;
        }

        
    }
}

