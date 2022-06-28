using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TimeLog
{
    public class Activity
    {
        public Activity() { }
        [XmlElement(ElementName = "Name", Order = 1)]
        public string Name { get; set; }

        [XmlArray(ElementName = "Events", Order = 3)]
        public List<Event> Events = new List<Event>();
        //[XmlElement(ElementName = "ActColor", Order = 2)] public Color Color { get; set; }
        [XmlIgnore]
        public Color Color { get; set; }

        [XmlElement(ElementName = "ActColor", Order = 2)]
        public int ColorAsInt
        {
            get { return Color.ToArgb(); }
            set { Color = Color.FromArgb(value); }
        }

        public void StartCurrentActivity(DateTime start)
        {
            Event e = new Event(start);
            Events.Add(e);

        }
        public void EndCurrentActivity(DateTime start)
        {
            foreach(Event e in Events.Where(x => x.StartTime == start))
            {
                e.EndTime = DateTime.Now;
            }
        }
        public void AddPastEvent(string name, DateTime start, DateTime end)
        {
            name = this.Name;
            Events.Add(new Event(name, start, end));
        }

        public static List<Event> GetEvents (DateTime fromTime, DateTime toTime)
        {
            List<Event> events = new();
            List <Activity> activityList = new List<Activity>(GetActivityList());
            foreach (Activity activity in activityList)
            {
                foreach (Event e in activity.Events)
                {
                    if (e.StartTime > fromTime && e.StartTime < toTime)
                    {
                        events.Add(e);
                    }
                }
            }

            return events;

        }
        
        public static List<Activity> GetActivityList()
        {
            List<Activity> list = new List<Activity>();
            var filePath = @"C:\Users\Jason\source\repos\TimeLog\TimeLog\XmlFiles\Activities.xml";
            var xs = new XmlSerializer(typeof(List<Activity>));

            using (Stream s = File.OpenRead(filePath))
                list = (List<Activity>)xs.Deserialize(s);
            return list;


        }

        public static void SaveActivityList(List<Activity> list)
        {
            var filePath = @"C:\Users\Jason\source\repos\TimeLog\TimeLog\XmlFiles\Activities.xml";

            var xs = new XmlSerializer(typeof(List<Activity>));
            using (Stream s = File.Create(filePath))
                xs.Serialize(s, list);
        }

        public static Color GetActivityColor(string activityName)
        {
            Color color = Color.White;
            List <Activity> activities = new List<Activity>(GetActivityList());
            foreach (Activity activity in activities.Where(x => x.Name == activityName))
            {
                color = activity.Color;
                

            }
            return color;

        }
    }
    

}
