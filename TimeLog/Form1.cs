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
           

            
                
            lblCurrentEventStart.Text = DateTime.Now.ToString("hh:mm:ss tt");
            lblActivityDisplay.Visible = true;
            lblActivityDisplay.Text = "You Are " + lbxAllActivities.Text;
            lblCurrentDuration.Visible = true;
            lblStartLabel.Visible = true;
            lblCurrentEventStart.Visible = true;
            
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan duration = DateTime.Now - DateTime.Parse(lblCurrentEventStart.Text);
            lblCurrentDuration.Text = duration.ToString("hh':'mm':'ss");
        }

        private void btnCreateNewType_Click(object sender, EventArgs e)
        {
            
            Activity a = new Activity();
            a.Name = txtNewActivityName.Text;
            activities.Add(a);
            Activity.SaveActivityList(activities);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            activities = Activity.GetActivityList();
            foreach (Activity a in activities)
            {
                lbxAllActivities.Items.Add(a.Name);
            }
            DateTime lastWeekStart = DateTime.Now.AddDays(-7);
            List<Event> events = new List<Event>(Activity.GetEvents(lastWeekStart, DateTime.Now));
            foreach (Event ev in events)
            {
                lbxDisplayEvents.Items.Add(ev.StartTime.ToString() + " " + ev.Name + "  " + ev.Duration.ToString());
            }
            
        }

        private void btnStopCurrentActivity_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            
            activities = Activity.GetActivityList();
            foreach (Activity activity in activities.Where(x => x.Name == lbxAllActivities.SelectedItem.ToString()))
            {
                activity.AddPastEvent(activity.Name, DateTime.Parse(lblCurrentEventStart.Text), DateTime.Now);
                
            }
            Activity.SaveActivityList(activities);
        }

        private void btnRecordPastEvent_Click(object sender, EventArgs e)
        {
            activities = Activity.GetActivityList();
            foreach (Activity a in activities.Where(x => x.Name == lbxAllActivities.Text))
            {
                a.AddPastEvent(a.Name, dtpPastEventStart.Value, dtpPastEventEnd.Value);
            }
            Activity.SaveActivityList(activities);
        }

        private void lbxAllActivities_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxAllActivities.SelectedIndex == -1)
            {
                btnStartCurrent.Enabled = false;
                btnStopCurrentActivity.Enabled = false;
                btnRecordPastEvent.Enabled = false;
            }
            if (lbxAllActivities.SelectedIndex <= 0)
            {
                btnStartCurrent.Enabled = true;
                btnStopCurrentActivity.Enabled = true;
                btnRecordPastEvent.Enabled = true;
            }

        }

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
            lblOldStart.Visible = true;
            lblOldStart.Text = dtpPastEventStart.Value.ToString("dddd");
        }

        private void dtpPastEventEnd_ValueChanged(object sender, EventArgs e)
        {
            lblOldEnd.Visible = true;
            lblOldEnd.Text = dtpPastEventEnd.Value.ToString("dddd");
        }
    }
}