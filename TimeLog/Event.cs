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
        [XmlAttribute]public string Name { get; set; }
        public TimeSpan Duration
        {
            get 
            {
                TimeSpan duration = EndTime - StartTime;
                return duration; 
            }
            
        }
        
    }
}

