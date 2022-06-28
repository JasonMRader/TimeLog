namespace TimeLog
{
    public partial class Form1 : Form
    {
        List<Activity> activities = new List<Activity>();
        DateTime newStartTime;
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnStartCurrent_Click(object sender, EventArgs e)
        {                        
                                     
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void btnCreateNewType_Click(object sender, EventArgs e)
        {
            //activities = Activity.GetActivityList();
            //Activity a = new Activity();
            //a.Name = txtNewActivityName.Text;
            //activities.Add(a);
            //Activity.SaveActivityList(activities);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            activities = Activity.GetActivityList();
            foreach (Activity a in activities)
            {
                clbActivityFIlter.Items.Add(a.Name);
            }
            DateTime lastWeekStart = DateTime.Now.AddDays(-7);
            List<Event> events = new List<Event>(Activity.GetEvents(lastWeekStart, DateTime.Now));
            //events.OrderBy<Event.TimeStart>
            foreach (Event ev in events)
            {
                lbxDisplayEvents.Items.Add(ev.StartTime.ToString() + " " + ev.Name + "  " + ev.Duration.ToString());
            }
            
        }

        private void btnStopCurrentActivity_Click(object sender, EventArgs e)
        {
            
        }

        private void btnRecordPastEvent_Click(object sender, EventArgs e)
        {
            //activities = Activity.GetActivityList();
            //foreach (Activity a in activities.Where(x => x.Name == lbxAllActivities.Text))
            //{
            //    a.AddPastEvent(a.Name, dtpPastEventStart.Value, dtpPastEventEnd.Value);
            //}
            //Activity.SaveActivityList(activities);
        }

        private void lbxAllActivities_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }
        //TODO Add Filters for viewing events, select specifit activities
        //TODO Display stats on percentages of time, total time, time vs other activites, and minus sleep
        private void cdrDisplayEvents_DateChanged(object sender, DateRangeEventArgs e)
        {
            lbxDisplayEvents.Items.Clear();
            
            List<Event> events = new List<Event>(Activity.GetEvents(e.Start, e.End));
            foreach (Event ev in events)
            {
                lbxDisplayEvents.Items.Add(ev.StartTime.ToString() + " " + ev.Name + "  " + ev.Duration.ToString());
            }
        }

        private void dtpPastEventStart_ValueChanged(object sender, EventArgs e)
        {
            //lblOldStart.Visible = true;
            //lblOldStart.Text = dtpPastEventStart.Value.ToString("dddd");
        }

        private void dtpPastEventEnd_ValueChanged(object sender, EventArgs e)
        {
            //lblOldEnd.Visible = true;
            //lblOldEnd.Text = dtpPastEventEnd.Value.ToString("dddd");
        }

        private void btnCreateNewEventCurrent_Click(object sender, EventArgs e)
        {
            Form form = new frmCurrentActivity();
            form.Show();
            this.Hide();
        }
        public void reopenMainForm(object sender, EventArgs e)
        {
            this.Show();
        }

    }
}