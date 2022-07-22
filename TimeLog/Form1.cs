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

        TimeSpan milliSecond = new TimeSpan(0, 0, 0, 0, 1);

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }
        
        private void PopulateIgnoreCheckBoxes(DateTime startDate, DateTime endDate)
        {
            flowIgnoreActivity.Controls.Clear();
            List<Activity> activities = new List<Activity>(Activity.SortActivities(startDate, endDate));
            List<Event> events = new List<Event>(Activity.GetEvents(startDate, endDate));
            //activities.Sort((b, a) => a.TotalDuration.CompareTo(b.TotalDuration));
            foreach (Activity a in activities)
            {
                CheckBox cbIgnore = new CheckBox();
                

                cbIgnore.Appearance = Appearance.Button;
                cbIgnore.Location = new Point(0, 0);
                
                cbIgnore.BackColor = a.Color;
                cbIgnore.ForeColor = a.TextColor;
                cbIgnore.Name = a.Name + "ignore";
                cbIgnore.FlatAppearance.BorderSize = 0;
                cbIgnore.FlatStyle = FlatStyle.Popup;
                cbIgnore.Margin = new Padding(0, 5, 0, 5);
                cbIgnore.ForeColor = a.TextColor;
                cbIgnore.Size = new Size(75, 23);
                cbIgnore.AutoSize = false;
                cbIgnore.Tag = a;
                cbIgnore.Font = new Font("Arial", 10, FontStyle.Regular);
                cbIgnore.Click += new EventHandler(EventCbIgnore_Click);
                flowIgnoreActivity.Controls.Add(cbIgnore);
                if (a.isIgnored == true)
                {
                    cbIgnore.Checked = true;
                    cbIgnore.Text = "Ignored";
                }
                if (a.isIgnored == false)
                {
                    cbIgnore.Checked = false;
                    cbIgnore.Text = "";
                }

            }
        }
        
        private void RefreshActivityStats()
        {
            if (rbAllTime.Checked)
            {
                List<Event> events = new List<Event>(Activity.GetAllEvents());
                DateTime firstEvent = events.Min(a => a.StartTime);
                firstEvent = firstEvent.AddDays(-1);
                PopulateStats(firstEvent, DateTime.Now);
            }
            if (rbToday.Checked)
            {
                DateTime day = DateTime.Parse(lblTimeFilterRange.Text);
                if (day.Date == DateTime.Now.Date)
                    PopulateStats(day, DateTime.Now);
                else
                    PopulateStats(day, day.AddDays(1));
               
            }
            if (rbWeek.Checked)
            {
                string weekStart = lblTimeFilterRange.Text.Substring(0, lblTimeFilterRange.Text.IndexOf("-"));
                txtTestBox.Text = weekStart;

                DateTime lastWeek = DateTime.Parse(weekStart);
                DateTime StartOfWeek = lastWeek.StartOfWeek(DayOfWeek.Monday);
                DateTime EndOfWeek = StartOfWeek.AddDays(7) - milliSecond;
                if (EndOfWeek > DateTime.Now)
                    PopulateStats(StartOfWeek, DateTime.Now);
                else
                    PopulateStats(StartOfWeek, EndOfWeek);

            }
            if (rbMonth.Checked)
            {
                DateTime thisMonth = DateTime.ParseExact(lblTimeFilterRange.Text,
                "MMMM", System.Globalization.CultureInfo.InvariantCulture);
                var firstDayOfMonth = new DateTime(thisMonth.Year, thisMonth.Month, 1);
                var lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddSeconds(-1);
                if (lastDayOfMonth.Date > DateTime.Now.Date)
                    PopulateStats(firstDayOfMonth, DateTime.Now);
                else
                    PopulateStats(firstDayOfMonth, lastDayOfMonth);

            }
            if (rbCustom.Checked)
            {

                PopulateStats(dtpCustomStart.Value,dtpCustomEnd.Value);
            }
        }
        private void EventCbIgnore_Click(object? sender, EventArgs e)
        {
            
            List<Activity> list = new List<Activity>(Activity.GetActivityList());
            CheckBox cb = sender as CheckBox;
            string actName = cb.Tag.ToString();
            Activity activity = cb.Tag as Activity;
            activity.isIgnored = cb.Checked;
            foreach (Activity a in list.Where(x => x.Name == activity.Name))
            {
                a.isIgnored = activity.isIgnored;

            }
            if (cb.Checked)
            {
                cb.Text = "Ignored";
            }
            else
            {
                cb.Text = "";
            }
            txtTestBox.Text = cb.Tag.ToString();
            Activity.SaveActivityList(list);
            RefreshActivityStats();

            
        }

        private void PopulateStats(DateTime startDate, DateTime endDate)
        {
            flowStatsActivity.Controls.Clear();
            flowStatsFirst.Controls.Clear();
            flowStatsSecond.Controls.Clear();
            flowStatsThird.Controls.Clear();
            flowStartCurrent.Controls.Clear();
            PopulateIgnoreCheckBoxes(startDate, endDate);
            List<Event> events = new List<Event>(Activity.GetEvents(startDate, endDate));
            TimeSpan timeSpan = endDate - startDate;
            double DaysDisplayed = timeSpan.TotalDays;

            

            List<Activity> activities = new List<Activity>(Activity.SortActivities(startDate, endDate));
            TimeSpan allEvents = Activity.AllEventsDuration(events, startDate, endDate);
            
            activities.Sort((b, a) =>a.TotalDuration.CompareTo(b.TotalDuration));
            TimeSpan ignoredDuration = Activity.GetIgnoredEvents(startDate, endDate);   
            //TimeSpan unassigned = timeSpan - allEvents;
            TimeSpan unassigned = Activity.GetUnassignedDuration(events, startDate, endDate);
            cbUnassignedHrs.Text = unassigned.TotalHours.ToString("0.#");
            
            if (cbUnassignedPercent.Checked)
                cbUnassignedPercent.Text = (unassigned.TotalHours / 
                    (timeSpan.TotalHours - ignoredDuration.TotalHours)).ToString("P");
            if (!cbUnassignedPercent.Checked)
                cbUnassignedPercent.Text = "Ignored";

            foreach (Activity a in activities)
            {
                Button btnStart = new Button();


                Button btn = new Button();
                
                CheckBox btnHours = new CheckBox();
                CheckBox btnPercentage = new CheckBox();    
                CheckBox btnAvgHours = new CheckBox();

                btnStart.Location = new Point(0, 0);
                btnStart.Text =  "Start";
                btnStart.ForeColor = a.TextColor;
                btnStart.Name = "btn" + a.Name;
                btnStart.BackColor = a.Color;
                btnStart.FlatAppearance.BorderSize = 0;
                btnStart.FlatStyle = FlatStyle.Popup;
                btnStart.Margin = new Padding(0, 5, 0, 5);
                btnStart.ForeColor = a.TextColor;
                btnStart.Size = new Size(74, 23);
                btnStart.AutoSize = false;
                btnStart.Tag = a;
                btnStart.Font = new Font("Arial", 10, FontStyle.Regular);
                btnStart.Click += new EventHandler(EventBtnStart_Click);

                flowStartCurrent.Controls.Add(btnStart);

                btn.Location = new Point(0, 0);
                btn.Text = a.Name + " +";
                btn.ForeColor = a.TextColor;
                btn.Name = "btn" + a.Name;
                btn.BackColor = a.Color;
                btn.FlatAppearance.BorderSize = 0;
                btn.FlatStyle = FlatStyle.Popup;
                btn.Margin = new Padding(0,5,0,5);
                btn.ForeColor = a.TextColor;
                btn.Size = new Size(125, 23);
                btn.AutoSize = false;
                btn.Tag = a;
                btn.Font = new Font("Arial", 10, FontStyle.Regular);
                btn.Click += new EventHandler(EventBtnAdd_Click);             
                                              

                TimeSpan ts = new TimeSpan(0,0,0);

                ts = a.GetDuration(startDate, endDate);

                btnHours.Appearance = Appearance.Button;
                btnHours.Location = new Point(0, 0);
                
                btnHours.Text = ts.TotalHours.ToString("G2") + " Hrs";

                btnHours.ForeColor = a.TextColor;
                btnHours.Name = "btn" + a.Name;
                btnHours.BackColor = a.Color;
                btnHours.FlatAppearance.BorderSize = 0;
                btnHours.FlatStyle = FlatStyle.Flat;
                btnHours.Margin = new Padding(0,5,0,5);
                btnHours.ForeColor = a.TextColor;
                btnHours.Size = new Size(75, 23);
                btnHours.AutoSize = false;                               

                double percentage = ts / allEvents;
                if (cbUnassignedPercent.Checked)
                    percentage = ts / (timeSpan-ignoredDuration);

                btnPercentage.Appearance = Appearance.Button;
                btnPercentage.Location = new Point(0, 0);
                btnPercentage.Text = percentage.ToString("P");
                btnPercentage.ForeColor = a.TextColor;
                btnPercentage.Name = "btn" + a.Name;
                btnPercentage.BackColor = a.Color;
                btnPercentage.FlatAppearance.BorderSize = 0;
                btnPercentage.FlatStyle = FlatStyle.Flat;
                btnPercentage.Margin = new Padding(0, 5, 0, 5);
                btnPercentage.ForeColor = a.TextColor;
                btnPercentage.Size = new Size(75, 23);
                btnPercentage.AutoSize = false;
                
                flowStatsActivity.Controls.Add(btn);
                flowStatsSecond.Controls.Add(btnPercentage); 
               
                flowStatsFirst.Controls.Add(btnHours);
                
                double dailyAvg;
                if (DaysDisplayed > 0)
                {
                    dailyAvg = ts.TotalHours / DaysDisplayed;
                }
                else
                {
                    dailyAvg = 0;
                }
                
                btnAvgHours.Appearance = Appearance.Button;
                btnAvgHours.Location = new Point(0, 0);
                btnAvgHours.Text = dailyAvg.ToString("0.#") + " Hrs/Day";
                btnAvgHours.ForeColor = a.TextColor;
                btnAvgHours.Name = "btn" + a.Name;
                btnAvgHours.BackColor = a.Color;
                btnAvgHours.FlatAppearance.BorderSize = 0;
                btnAvgHours.FlatStyle = FlatStyle.Flat;
                btnAvgHours.Margin = new Padding(0, 5, 0, 5);
                btnAvgHours.ForeColor = a.TextColor;
                btnAvgHours.Size = new Size(95, 23);
                btnAvgHours.AutoSize = false;

                flowStatsThird.Controls.Add(btnAvgHours);

                txtTestBox.Text = startDate.ToString("ddd d hh:mm tt") + " StartDate";
                txtTestBoxTwo.Text = allEvents.TotalHours.ToString("0.##"); 
                TxtTestBoxThree.Text = endDate.ToString("ddd d hh:mm tt") + " EndDate";

                txtTestBox4.Text = timeSpan.TotalHours.ToString("0.##" + " Timespan Hours") ;              
                

            }                       

        }

        private void EventBtnStart_Click(object? sender, EventArgs e)
        {
            Button btn = sender as Button;
            Activity a = new Activity();
            a = (Activity)btn.Tag;
            this.Tag = a;
            Form form = new frmCurrentActivity(a);
            this.Hide();
            form.ShowDialog();
        }

        private void EventBtnAdd_Click(object? sender, EventArgs e)
        {
            Button btn = sender as Button;
            Activity a = new Activity();
            a = (Activity)btn.Tag;
            this.Tag = a;
            Form form = new frmAddPastEvent(a);
            form.ShowDialog();
        }
                               
        private void Form1_Load(object sender, EventArgs e)
        {
            lblDailyView.Text = DateTime.Now.ToString("ddd MMM d");
            dtpDailyView.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 8, 0, 0);
            TimeOnly timeOnly = new TimeOnly(8,0);
                                  
                       
            
            DateTime lastWeekStart = DateTime.Now.AddDays(-7);
            List<Event> events = new List<Event>(Activity.GetEvents(lastWeekStart, DateTime.Now));
            //PopulateEventList(lastWeekStart, DateTime.Now);
            
            DisplayDailyView(DateTime.Parse(lblDailyView.Text), dtpDailyView.Value.Hour, dtpDailyView.Value.Minute);
            PopulateStats(lastWeekStart, DateTime.Now);
            PopulateIgnoreCheckBoxes(lastWeekStart, DateTime.Now);

        }              
       
        
        
        private void btnCreateNewEventCurrent_Click(object sender, EventArgs e)
        {
            //Form form = new frmCurrentActivity();
            //form.Show();
            //this.Hide();
        }
       
       

        private void btnAddEditActivities_Click(object sender, EventArgs e)
        {
            Form form = new frmAddCatagories();
            form.ShowDialog();
        }

        private void btnNextHour_Click(object sender, EventArgs e)
        {
            dtpDailyView.Value = dtpDailyView.Value.AddHours(1);
            
        }

        private void btnPreviousHour_Click(object sender, EventArgs e)
        {
            dtpDailyView.Value = dtpDailyView.Value.AddHours(-1);
            
        }

        private void rbAllTime_CheckedChanged(object sender, EventArgs e)
        {
            lblTimeFilterRange.Visible = !rbAllTime.Checked;
            List<Event> events = new List<Event>(Activity.GetAllEvents());
            DateTime firstEvent = events.Min(a => a.StartTime);
            firstEvent = firstEvent.AddDays(-1);


            if (rbAllTime.Checked)
            {
                PopulateStats(firstEvent, DateTime.Now);
            }
        }

        private void rbToday_CheckedChanged(object sender, EventArgs e)
        {
            
            btnStatsNextDay.Visible = rbToday.Checked;
            btnStatsPreviousDay.Visible = rbToday.Checked;
            if (rbToday.Checked)
            {
                lblTimeFilterRange.Text = DateTime.Today.ToString("ddd MMM d");                
                PopulateStats(DateTime.Today, DateTime.Now);
                
            }                       
        }

        private void rbWeek_CheckedChanged(object sender, EventArgs e)
        {
            btnLastWeek.Visible = rbWeek.Checked;
            btnNextWeek.Visible = rbWeek.Checked;
            
            DateTime StartOfWeek = DateTime.Now.StartOfWeek(DayOfWeek.Monday);
            DateTime EndOfWeek = StartOfWeek.AddDays(7) - milliSecond;
            if (rbWeek.Checked)
            {
                lblTimeFilterRange.Text = StartOfWeek.ToString("M/d") + "-" + EndOfWeek.ToString("M/d");
                RefreshActivityStats();
            }
         
        }
        public static DateTime GetMonday(DateTime time)
        {
            if (time.DayOfWeek != DayOfWeek.Monday)
                return time.Subtract(new TimeSpan((int)time.DayOfWeek - 1, 0, 0, 0));

            return time;
        }

        private void btnLastWeek_Click(object sender, EventArgs e)
        {
            string weekStart = lblTimeFilterRange.Text.Substring(0, lblTimeFilterRange.Text.IndexOf("-"));
            txtTestBox.Text = weekStart;

           
            DateTime lastWeek = DateTime.Parse(weekStart).AddDays(-7);
            DateTime StartOfWeek = lastWeek.StartOfWeek(DayOfWeek.Monday);
            DateTime EndOfWeek = StartOfWeek.AddDays(7) - milliSecond;
            lblTimeFilterRange.Text = StartOfWeek.ToString("M/d") + "-" + EndOfWeek.ToString("M/d");
            RefreshActivityStats();
            
        }

        private void btnNextWeek_Click(object sender, EventArgs e)
        {

            string weekStart = lblTimeFilterRange.Text.Substring(0, lblTimeFilterRange.Text.IndexOf("-"));
            txtTestBox.Text = weekStart;


            DateTime lastWeek = DateTime.Parse(weekStart).AddDays(7);
            DateTime StartOfWeek = lastWeek.StartOfWeek(DayOfWeek.Monday);
            DateTime EndOfWeek = StartOfWeek.AddDays(7) - milliSecond;
            lblTimeFilterRange.Text = StartOfWeek.ToString("M/d") + "-" + EndOfWeek.ToString("M/d");
            RefreshActivityStats();
          
        }

        private void rbMonth_CheckedChanged(object sender, EventArgs e)
        {
            btnNextMonth.Visible = rbMonth.Checked;
            btnLastMonth.Visible = rbMonth.Checked;
            if (rbMonth.Checked)
            {
                lblTimeFilterRange.Text = DateTime.Now.ToString("MMMM");
                RefreshActivityStats();
            }              
            
        }

        private void btnLastMonth_Click(object sender, EventArgs e)
        {
            DateTime thisMonth = DateTime.ParseExact(lblTimeFilterRange.Text, 
                "MMMM", System.Globalization.CultureInfo.InvariantCulture);
            DateTime displayMonth = thisMonth.AddMonths(-1);
            lblTimeFilterRange.Text = displayMonth.ToString("MMMM");
            RefreshActivityStats();            
        }

        private void btnNextMonth_Click(object sender, EventArgs e)
        {
            DateTime thisMonth = DateTime.ParseExact(lblTimeFilterRange.Text,
               "MMMM", System.Globalization.CultureInfo.InvariantCulture);
            DateTime displayMonth = thisMonth.AddMonths(1);
            lblTimeFilterRange.Text = displayMonth.ToString("MMMM");
            RefreshActivityStats();
            
        }

        private void rbCustom_CheckedChanged(object sender, EventArgs e)
        {        
            lblCustomStart.Visible = rbCustom.Checked;
            lblCustomEnd.Visible = rbCustom.Checked;
            dtpCustomEnd.Visible = rbCustom.Checked;
            dtpCustomStart.Visible = rbCustom.Checked;
            TimeSpan ts = dtpCustomEnd.Value - dtpCustomStart.Value;
            lblTimeFilterRange.Text = ts.TotalDays.ToString("0.##") + " Days";
            PopulateStats(DateTime.Today, DateTime.Now);

        }

        private void btnStatsPreviousDay_Click(object sender, EventArgs e)
        {
            DateTime day = DateTime.Parse(lblTimeFilterRange.Text).AddDays(-1);
            lblTimeFilterRange.Text = day.ToString("ddd MMM d");
            RefreshActivityStats();           

        }

        private void btnStatsNextDay_Click(object sender, EventArgs e)
        {
            DateTime day = DateTime.Parse(lblTimeFilterRange.Text).AddDays(1);
            lblTimeFilterRange.Text = day.ToString("ddd MMM d");
            RefreshActivityStats();          

        }
       

        private void cbUnassignedPercent_CheckedChanged(object sender, EventArgs e)
        {
            RefreshActivityStats();
        }


        //Start of Daily view code
        //
        //--------------------------------------------------------------------------------------------------------
        //
        //

        private void btnNextDay_Click(object sender, EventArgs e)
        {
            pnlDailyView.Controls.Clear();
            DateTime dt = DateTime.Parse(lblDailyView.Text).AddDays(1);
            lblDailyView.Text = dt.ToString("ddd MMM d");
            dtpDailyView.Value = dtpDailyView.Value.AddDays(-1);
            DisplayDailyView(DateTime.Parse(lblDailyView.Text), dtpDailyView.Value.Hour, dtpDailyView.Value.Minute);
        }

        private void btnPreviousDay_Click(object sender, EventArgs e)
        {
            pnlDailyView.Controls.Clear();
            DateTime dt = DateTime.Parse(lblDailyView.Text).AddDays(-1);
            lblDailyView.Text = dt.ToString("ddd MMM d");
            dtpDailyView.Value = dtpDailyView.Value.AddDays(-1);
            DisplayDailyView(DateTime.Parse(lblDailyView.Text), dtpDailyView.Value.Hour, dtpDailyView.Value.Minute);
        }


        private void dtpDailyView_ValueChanged(object sender, EventArgs e)
        {
            pnlDailyView.Controls.Clear();
            DisplayDailyView(DateTime.Parse(lblDailyView.Text), dtpDailyView.Value.Hour, dtpDailyView.Value.Minute);

        }
        private void DisplayDailyView(DateTime startDate, int displayHour, int displayMin)
        {
            pnlDvTime.Controls.Clear();
            pnlDailyView.Controls.Clear();
            List<Event> events = new List<Event>(Activity.GetEvents(startDate, startDate.AddDays(2)));
            foreach (Event ev in events)
            {
                //if (ev.StartTime.Date < startDate.Date)
                Panel panel = new Panel();
                panel.Size = new Size(200, ev.PanelLength);
                panel.Location = new Point(0, ev.GetAdjustedLocation(startDate, displayHour, displayMin));
                panel.BackColor = ev.Color;
                Label label = new Label();
                label.Text = ev.Name;
                label.ForeColor = ev.TextColor;
                Label duration = new Label();
                duration.Text = ev.Duration.ToString("h':'mm");
                duration.Location = new Point(165, 0);
                label.Font = new Font("Arial", 8, FontStyle.Regular);
                duration.Font = new Font("Arial", 8, FontStyle.Regular);
                duration.ForeColor = ev.TextColor;
                if (ev.Duration < new TimeSpan(0, 14, 0))
                {
                    label.Font = new Font("Arial", 6, FontStyle.Regular);
                    duration.Font = new Font("Arial", 6, FontStyle.Regular);
                }

                pnlDailyView.Controls.Add(panel);
                panel.Controls.Add(label);
                panel.Controls.Add(duration);
            }
            TimeOnly display = new TimeOnly(displayHour, displayMin);
            Label lblHour = new Label();
            lblHour.Text = display.ToString("h tt");
            lblHour.Location = new Point(0, 0);
            lblHour.ForeColor = Color.White;
            pnlDvTime.Controls.Add(lblHour);
            for (int i = 0; i < 11; i++)
            {
                TimeOnly now = TimeOnly.FromDateTime(DateTime.Now);
                display = display.AddHours(2);
                Label label = new Label();
                label.Text = (display).ToString("h tt");
                label.Location = new Point(0, ((i + 1) * 120));
                label.ForeColor = Color.White;
                pnlDvTime.Controls.Add(label);
                if (display <= now.AddMinutes(20) && display >= now.AddMinutes(-20))
                {
                    label.Visible = false;
                }

            }
            if (DateTime.Parse(lblDailyView.Text) == DateTime.Today)
            {
                Panel pnlCurrentTime = new Panel();
                pnlCurrentTime.Size = new Size(43, 28);
                pnlCurrentTime.Location = new Point(0, Event.GetNowDisplay(displayHour, displayMin));
                pnlCurrentTime.BackColor = Color.DarkBlue;
                pnlDvTime.Controls.Add(pnlCurrentTime);

                Panel innerPnl = new Panel();
                innerPnl.Size = new Size(200, 14);
                innerPnl.Location = new Point(0, 7);
                innerPnl.BackColor = Color.Yellow;
                pnlCurrentTime.Controls.Add(innerPnl);
                Label lblNow = new Label();
                lblNow.Text = "Now";
                //lblNow.ForeColor = Color.White;
                innerPnl.Controls.Add(lblNow);
            }

        }

        private void btnUnignoreAll_Click(object sender, EventArgs e)
        {
            List<Activity> activities = Activity.GetActivityList();
            foreach (Activity activity in activities)
            {
                activity.isIgnored = false;
            }
            Activity.SaveActivityList(activities);
            RefreshActivityStats();
        }
        //TODO test inputs for hour accuracy, add dtpEnd event
        private void dtpCustomStart_ValueChanged(object sender, EventArgs e)
        {
            TimeSpan ts = dtpCustomEnd.Value - dtpCustomStart.Value;
            lblTimeFilterRange.Text = ts.TotalDays.ToString("0.##") + " Days";

            //activities = Activity.GetActivityList();
            //List<Event> events = new List<Event>(Activity.GetEvents(dtpCustomStart.Value, dtpCustomEnd.Value));
            ////PopulateEventList(e.Start, e.End);
            //PopulateStats(dtpCustomStart.Value, dtpCustomEnd.Value);
            RefreshActivityStats();
        }
        private void dtpCustomEnd_ValueChanged(object sender, EventArgs e)
        {
            TimeSpan ts = dtpCustomEnd.Value - dtpCustomStart.Value;
            lblTimeFilterRange.Text = ts.TotalHours.ToString("0.##") + " Hours";
            RefreshActivityStats();
        }
    }
}
