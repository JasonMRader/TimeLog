using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeLog
{
    public partial class frmAddPastEvent : Form
    {
        Activity activity = new Activity();
        public frmAddPastEvent(Activity a)
        {
            InitializeComponent();
            activity = a;
        }

        private void PopulateEventList(DateTime startDate, DateTime endDate)
        {
            flowEvents.Controls.Clear();
            List<Event> events = new List<Event>(Activity.GetEvents(startDate, endDate));
            foreach (Event ev in events)
            {
                string displayEvent = ev.DisplayEvent();

                CheckBox btn = new CheckBox();

                btn.Appearance = Appearance.Button;

                btn.Location = new Point(0, 0);
                btn.Text = displayEvent;
                btn.Name = ev.ButtonName();
                btn.BackColor = ev.Color;
                btn.FlatAppearance.BorderSize = 0;
                btn.FlatStyle = FlatStyle.Flat;
                btn.Margin = new Padding(0);
                btn.ForeColor = ev.TextColor;
                btn.Size = new Size(315, 25);
                btn.AutoSize = false;
                btn.Tag = ev.StartTime;
                btn.Font = new Font("Arial", 10, FontStyle.Regular);
                btn.Click += new EventHandler(EventCkBx_Click);
                flowEvents.Controls.Add(btn);

            }

        }
        private void PopulateButtons()
        {
            List<Activity> activities = new List<Activity>(Activity.GetActivityList());
            flowActDisplay.Controls.Clear();
            foreach (Activity a in activities)
            {

                Button btn = new Button();

                btn.Location = new Point(0, 0);
                btn.Text = a.Name;
                btn.Name = "newBtn" + a.Name;
                btn.BackColor = a.Color;
                btn.FlatAppearance.BorderSize = 0;
                btn.FlatStyle = FlatStyle.Flat;
                btn.Margin = new Padding(0);
                btn.ForeColor = a.TextColor;
                btn.Size = new Size(60, 25);
                btn.AutoSize = true;
                btn.Tag = a;
                btn.Font = new Font("Arial", 10, FontStyle.Regular);
                btn.Click += new EventHandler(BtnActivity_Click);
                flowActDisplay.Controls.Add(btn);

                //lbxFinishedEvent.Items.Add(a.Name);
            }


        }

        private void BtnActivity_Click(object? sender, EventArgs e)
        {
            Button btn = sender as Button;
            activity = btn.Tag as Activity;
            this.BackColor = activity.Color;
            this.ForeColor = activity.TextColor;
            lblEventDisplay.Text = activity.Name;
        }

        private void EventCkBx_Click(object? sender, EventArgs e)
        {

            CheckBox chk = sender as CheckBox;
            foreach (Control c in flowEvents.Controls)
            {
                if (((CheckBox)c).Checked)
                {

                }
            }
            if (chk.Checked)
            {
                chk.Font = new Font("Arial", 10, FontStyle.Bold);

            }
            if (!chk.Checked)
            {
                chk.Font = new Font("Arial", 10, FontStyle.Regular);
            }

        }
        private void frmAddPastEvent_Load(object sender, EventArgs e)
        {
            this.ForeColor = activity.TextColor;
            lblTimeFrame.Text = DateTime.Now.ToString("ddd MMM d");
            PopulateButtons();
            PopulateEventList(DateTime.Today.AddDays(-7), DateTime.Now);
            lblStartDisplay.Text = dtpStart.Value.ToString("dddd, MMM d");
            lblEndDisplay.Text = dtpEnd.Value.ToString("dddd, MMM d");
            lblEventDisplay.Text = activity.Name;
            this.BackColor = activity.Color;
        }
        private void dtpStart_ValueChanged(object sender, EventArgs e)
        {
            dtpEnd.Value = dtpStart.Value;
            lblStartDisplay.Visible = true;
            lblStartDisplay.Text = dtpStart.Value.ToString("dddd, MMM d");
            PopulateEventList(dtpStart.Value.Date, dtpStart.Value.Date.AddDays(1));
            lblTimeFrame.Text = dtpStart.Value.ToString("dddd, MMM d");
        }

        private void dtpEnd_ValueChanged(object sender, EventArgs e)
        {
            TimeSpan ts = dtpEnd.Value - dtpStart.Value;
            lblEndDisplay.Visible = true;
            lblEndDisplay.Text = dtpEnd.Value.ToString("dddd, MMM d");
            lblDuration.Visible = true;
            lblDuration.Text = ts.ToString("hh':'mm");
        }

        private void btnStartMinusHour_Click(object sender, EventArgs e)
        {
            dtpStart.Value = dtpStart.Value.AddHours(-1);
        }

        private void btnStartMinus15Min_Click(object sender, EventArgs e)
        {
            dtpStart.Value = dtpStart.Value.AddMinutes(-15);
        }

        private void btnStartMinus5Min_Click(object sender, EventArgs e)
        {
            dtpStart.Value = dtpStart.Value.AddMinutes(-5);
        }

        private void btnStartAddHour_Click(object sender, EventArgs e)
        {
            dtpStart.Value = dtpStart.Value.AddHours(1);
        }

        private void btnStartAdd15Min_Click(object sender, EventArgs e)
        {
            dtpStart.Value = dtpStart.Value.AddMinutes(15);
        }

        private void btnStartAdd5Min_Click(object sender, EventArgs e)
        {
            dtpStart.Value = dtpStart.Value.AddMinutes(5);
        }

        private void btnEndMinusHour_Click(object sender, EventArgs e)
        {
            dtpEnd.Value = dtpEnd.Value.AddHours(-1);
        }

        private void btnEndMinus15Min_Click(object sender, EventArgs e)
        {
            dtpEnd.Value = dtpEnd.Value.AddMinutes(-15);
        }

        private void btnEndMinus5Min_Click(object sender, EventArgs e)
        {
            dtpEnd.Value = dtpEnd.Value.AddMinutes(-5);
        }

        private void btnEndAddHour_Click(object sender, EventArgs e)
        {
            dtpEnd.Value = dtpEnd.Value.AddHours(1);
        }

        private void btnEndAdd15Min_Click(object sender, EventArgs e)
        {
            dtpEnd.Value = dtpEnd.Value.AddMinutes(15);
        }

        private void btnEndAdd5Min_Click(object sender, EventArgs e)
        {
            dtpEnd.Value = dtpEnd.Value.AddMinutes(5);
        }

        private void btnPreviousDay_Click(object sender, EventArgs e)
        {
            dtpStart.Value = dtpStart.Value.AddDays(-1);
        }

        private void btnNextDay_Click(object sender, EventArgs e)
        {
            dtpStart.Value = dtpStart.Value.AddDays(1);
        }

        private void btnAddEvent_Click(object sender, EventArgs e)
        {
            List <Activity> activities = Activity.GetActivityList();
            foreach (Activity a in activities.Where(x => x.Name == lblEventDisplay.Text))
            {
                a.AddPastEvent(a.Name, dtpStart.Value, dtpEnd.Value);
            }
            Activity.SaveActivityList(activities);
            this.Close();
        }

        private void btnDeleteEvents_Click(object sender, EventArgs e)
        {
            List <Activity> activities = Activity.GetActivityList();
            List<Event> eventsSelected = new List<Event>();
            List<DateTime> startTimeToDelete = new List<DateTime>();
            List<string> ckDisplays = new List<string>();
            foreach (Control c in flowEvents.Controls)
            {
                if (((CheckBox)c).Checked)
                {
                    ckDisplays.Add(c.Name);
                }
            }
            foreach (string c in ckDisplays)
            {
                foreach (Activity activity in activities)
                {
                    var itemToRemove = activity.Events.SingleOrDefault(x => x.ButtonName() == c);
                    if (itemToRemove != null)
                        activity.Events.Remove(itemToRemove);

                }
            }

            Activity.SaveActivityList(activities);
            

            PopulateEventList(DateTime.Now.AddDays(-7), DateTime.Now);
        }

        private void rdoWeek_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdoDay_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (rdoDay.Checked)
            {
                flowEvents.Controls.Clear();
                DateTime dt = DateTime.Parse(lblTimeFrame.Text).AddDays(-1);
                lblTimeFrame.Text = dt.ToString("ddd MMM d");
                PopulateEventList(dt, dt.AddDays(1));
            }
            dtpStart.Value = DateTime.Parse(lblTimeFrame.Text);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (rdoDay.Checked)
            {
                flowEvents.Controls.Clear();
                DateTime dt = DateTime.Parse(lblTimeFrame.Text).AddDays(1);
                lblTimeFrame.Text = dt.ToString("ddd MMM d");
                PopulateEventList(dt, dt.AddDays(1));
            }
        }

        private void btnAddMore_Click(object sender, EventArgs e)
        {
            List<Activity> activities = Activity.GetActivityList();
            foreach (Activity a in activities.Where(x => x.Name == lblEventDisplay.Text))
            {
                a.AddPastEvent(a.Name, dtpStart.Value, dtpEnd.Value);
            }
            Activity.SaveActivityList(activities);
            PopulateEventList(dtpStart.Value.Date, dtpEnd.Value.Date.AddDays(.99));
            dtpStart.Value = dtpEnd.Value;
        }
    }
}
