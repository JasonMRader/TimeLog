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
        public Activity(string name, Color color, string textColor, bool ignore)
        {
            this.Name = name;
            this.Color = color;
            this.TextColorString = textColor;
            this.isIgnored = ignore;
        }
        [XmlElement(ElementName = "Name", Order = 1)]
        public string Name { get; set; }

        [XmlArray(ElementName = "Events", Order = 3)]
        public List<Event> Events = new List<Event>();
       
        [XmlIgnore]
        public Color Color { get; set; }

        [XmlElement(ElementName = "textColor", Order = 4)]
        public string TextColorString { get; set; }
        [XmlIgnore]
        public Color TextColor
        {
            get
            {
                if (TextColorString == "white")
                {
                    return Color.White;
                }
                else { return Color.Black; }
            }
        }
        [XmlElement(ElementName = "Ignore", Order = 5)]
        public bool isIgnored { get; set; }

        [XmlElement(ElementName = "ActColor", Order = 2)]
        public int ColorAsInt
        {
            get { return Color.ToArgb(); }
            set { Color = Color.FromArgb(value); }
        }
        [XmlIgnore]
        public TimeSpan TotalDuration
        {
            get
            {
                TimeSpan duration = new TimeSpan(0, 0, 0);
                foreach (Event e in Events)
                {
                    duration += e.Duration;
                }
                return duration;
            }
        }

       
        public void AddPastEvent(string name, DateTime start, DateTime end)
        {
            name = this.Name;
            Events.Add(new Event(name, start, end));
        }
        public void DeleteEvents(DateTime evStart)
        {
            
            foreach (Event e in Events)
            {
                if (e.Name == this.Name && e.StartTime == evStart)
                {
                    Events.Remove(e);
                }
            }
            
           
        }
       
        public static List<Activity> SortActivities(DateTime fromTime, DateTime toTime)
        {
            //List<Event> events = new();
            List<Activity> activityList = new List<Activity>(GetActivityList());
            List<Activity> sortedList = new();
            foreach (Activity activity in activityList)
            {
                Activity a = new Activity(activity.Name, activity.Color, activity.TextColorString, activity.isIgnored);
                
                //activity.TotalDuration = (int 0, int 0, int 0);
                foreach (Event e in activity.Events)
                {
                    if (e.StartTime > fromTime && e.StartTime < toTime && activity.isIgnored == false)
                    {
                        e.Color = activity.Color;
                        e.TextColor = activity.TextColor;
                        a.Events.Add(e);
                        //activity.TotalDuration += e.Duration;
                    }
                    
                }
                sortedList.Add(a);
            }
            sortedList.Sort((b, a) => a.TotalDuration.CompareTo(b.TotalDuration));
            //events.Sort((a, b) => a.StartTime.CompareTo(b.StartTime));

            return sortedList;
        }
        public static List<Event> GetEvents (DateTime fromTime, DateTime toTime)
        {
            List<Event> events = new();
            List <Activity> activityList = new List<Activity>(GetActivityList());
            foreach (Activity activity in activityList)
            {
                //activity.TotalDuration = (int 0, int 0, int 0);
                foreach (Event e in activity.Events)
                {
                    if (e.StartTime > fromTime && e.StartTime < toTime && activity.isIgnored == false)
                    {
                        e.Color = activity.Color;
                        e.TextColor = activity.TextColor;
                        events.Add(e);
                        //activity.TotalDuration += e.Duration;
                    }
                }
            }
            events.Sort((a,b)=> a.StartTime.CompareTo(b.StartTime));

            return events;

        }
        public static TimeSpan GetIgnoredEvents(DateTime fromTime, DateTime toTime)
        {
            TimeSpan ignoredEvents = TimeSpan.Zero;
            List<Event> events = new();
            List<Activity> activityList = new List<Activity>(GetActivityList());
            foreach (Activity activity in activityList)
            {
                //activity.TotalDuration = (int 0, int 0, int 0);
                foreach (Event e in activity.Events)
                {
                    if (e.StartTime > fromTime && e.StartTime < toTime && activity.isIgnored == true)
                    {
                        if (e.EndTime < toTime)
                            ignoredEvents += e.Duration;
                        else
                            ignoredEvents += e.Duration - (e.EndTime - toTime);
                    }
                }
            }
            events.Sort((a, b) => a.StartTime.CompareTo(b.StartTime));

            return ignoredEvents;

        }
        public TimeSpan GetDuration(DateTime dtStart, DateTime dtEnd)
        {
            TimeSpan duration = new TimeSpan(0, 0, 0);
            //this.TotalDuration = duration;
            foreach (Event e in this.Events)
            {
                if (e.StartTime > dtStart && e.StartTime < dtEnd && this.isIgnored == false)
                {
                    if (e.EndTime < dtEnd)
                        duration += e.Duration;
                    else
                        duration += e.Duration - (e.EndTime - dtEnd);
                }

            }
            return duration;

        }
        public static TimeSpan GetUnassignedDuration(List<Event> events, DateTime start, DateTime end)
        {
            
            TimeSpan timeSpan = end - start;
            TimeSpan eventsDuration = AllEventsDuration(events, start, end) + GetIgnoredEvents(start, end);
            return timeSpan - eventsDuration;


        }
        public static TimeSpan AllEventsDuration(List<Event> events, DateTime dtStart, DateTime dtEnd)
        {
            TimeSpan allEvents = new TimeSpan(0, 0, 0);
            foreach (Event e in events)
            {
                if (e.EndTime < dtEnd)
                    allEvents += e.Duration;
                else
                    allEvents += e.Duration - (e.EndTime - dtEnd);
            }
            return allEvents;
        }
        public static List<Event> GetAllEvents()
        {
            List<Event> events = new();
            List<Activity> activityList = new List<Activity>(GetActivityList());
            foreach (Activity activity in activityList)
            {
                //activity.TotalDuration = (int 0, int 0, int 0);
                foreach (Event e in activity.Events)
                {
                    
                    e.Color = activity.Color;
                    e.TextColor = activity.TextColor;
                    events.Add(e);
                    
                }
            }
            events.Sort((a, b) => a.StartTime.CompareTo(b.StartTime));

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

        public static Activity GetActivity (string activityName)
        {
            Activity a = new Activity();
            List<Activity> list = GetActivityList();
            foreach (Activity activity in list.Where (x => x.Name == activityName)) 
            {
                a = activity;
            }  
            return a;
        }
        

    }
    

}
