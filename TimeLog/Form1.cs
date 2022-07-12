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
        private void DisplayDailyView( DateTime startDate, int displayHour, int displayMin)
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
                label.Location = new Point(0, ((i + 1)*120));
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

       
        //private void PopulateEventList(DateTime startDate, DateTime endDate)
        //{
        //    flowLayoutPanel1.Controls.Clear();
        //    List<Event> events = new List<Event>(Activity.GetEvents(startDate, endDate));
        //    foreach (Event ev in events)
        //    {
        //        string displayEvent = ev.DisplayEvent();
                    
        //        CheckBox btn = new CheckBox();

        //        btn.Appearance = Appearance.Button;
                
        //        btn.Location = new Point(0, 0);
        //        btn.Text = displayEvent;
        //        btn.Name = ev.ButtonName();
        //        btn.BackColor = ev.Color;
        //        btn.FlatAppearance.BorderSize = 0;
        //        btn.FlatStyle = FlatStyle.Flat;
        //        btn.Margin = new Padding(0);
        //        btn.ForeColor = ev.TextColor;
        //        btn.Size = new Size(300, 25);
        //        btn.AutoSize = false;
        //        btn.Tag = ev.StartTime;
        //        btn.Font = new Font("Arial", 10, FontStyle.Regular);
        //        btn.Click += new EventHandler(EventCkBx_Click);
        //        flowLayoutPanel1.Controls.Add(btn);
                
        //    }            

        //}
        private void PopulateIgnoreCheckBoxes(DateTime startDate, DateTime endDate)
        {
            flowIgnoreActivity.Controls.Clear();
            List<Activity> activities = new List<Activity>(Activity.GetActivityList());
            List<Event> events = new List<Event>(Activity.GetEvents(startDate, endDate));
            activities.Sort((b, a) => a.TotalDuration.CompareTo(b.TotalDuration));
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
        private bool isIgnored(Activity a)
        {
            lbxTest.Items.Clear();
            bool isIgnored = false;
            foreach (Control c in flowIgnoreActivity.Controls)
            {
                if (((CheckBox)c).Checked && c.Tag == a)
                {
                    isIgnored = true;
                    lbxTest.Items.Add(c.Tag.ToString());
                }
                
            }
            return isIgnored;
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
            //isIgnored(cb.Tag);
        }

        private void PopulateStats(DateTime startDate, DateTime endDate)
        {
            flowStatsActivity.Controls.Clear();
            flowStatsFirst.Controls.Clear();
            flowStatsSecond.Controls.Clear();
            flowStatsThird.Controls.Clear();
            flowStartCurrent.Controls.Clear();
            List<Event> events = new List<Event>(Activity.GetEvents(startDate, endDate));
            TimeSpan timeSpan = endDate - startDate;
            double DaysDisplayed = timeSpan.TotalDays;
            
            List<Activity> activities = new List<Activity>(Activity.GetActivityList());
            TimeSpan allEvents = new TimeSpan(0, 0, 0);
            foreach(Event e in events)
            {
                allEvents += e.Duration;
            }
            activities.Sort((b, a) =>a.TotalDuration.CompareTo(b.TotalDuration));            
            
            foreach (Activity a in activities)
            {
                Button btnStart = new Button();


                Button btn = new Button();
                
                CheckBox btnFirstStat = new CheckBox();
                CheckBox btnSecondStat = new CheckBox();    
                CheckBox btnThirdStat = new CheckBox();

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

                btnFirstStat.Appearance = Appearance.Button;
                btnFirstStat.Location = new Point(0, 0);
                //if (isIgnored(a.Name) == false)
                //{
                //    ts = a.GetDuration(startDate, endDate);
                //}
                //if (isIgnored(a.Name) == true)
                //{
                    
                //}
                btnFirstStat.Text = ts.TotalHours.ToString("G2");

                btnFirstStat.ForeColor = a.TextColor;
                btnFirstStat.Name = "btn" + a.Name;
                btnFirstStat.BackColor = a.Color;
                btnFirstStat.FlatAppearance.BorderSize = 0;
                btnFirstStat.FlatStyle = FlatStyle.Flat;
                btnFirstStat.Margin = new Padding(0,5,0,5);
                btnFirstStat.ForeColor = a.TextColor;
                btnFirstStat.Size = new Size(75, 23);
                btnFirstStat.AutoSize = false;                               

                double percentage = ts / allEvents;

                btnSecondStat.Appearance = Appearance.Button;
                btnSecondStat.Location = new Point(0, 0);
                btnSecondStat.Text = percentage.ToString("P");
                btnSecondStat.ForeColor = a.TextColor;
                btnSecondStat.Name = "btn" + a.Name;
                btnSecondStat.BackColor = a.Color;
                btnSecondStat.FlatAppearance.BorderSize = 0;
                btnSecondStat.FlatStyle = FlatStyle.Flat;
                btnSecondStat.Margin = new Padding(0, 5, 0, 5);
                btnSecondStat.ForeColor = a.TextColor;
                btnSecondStat.Size = new Size(75, 23);
                btnSecondStat.AutoSize = false;
                
                flowStatsActivity.Controls.Add(btn);
                flowStatsSecond.Controls.Add(btnSecondStat); 
               
                flowStatsFirst.Controls.Add(btnFirstStat);
                
                double dailyAvg;
                if (DaysDisplayed > 0)
                {
                    dailyAvg = ts.TotalHours / DaysDisplayed;
                }
                else
                {
                    dailyAvg = 0;
                }
                
                btnThirdStat.Appearance = Appearance.Button;
                btnThirdStat.Location = new Point(0, 0);
                btnThirdStat.Text = dailyAvg.ToString();
                btnThirdStat.ForeColor = a.TextColor;
                btnThirdStat.Name = "btn" + a.Name;
                btnThirdStat.BackColor = a.Color;
                btnThirdStat.FlatAppearance.BorderSize = 0;
                btnThirdStat.FlatStyle = FlatStyle.Flat;
                btnThirdStat.Margin = new Padding(0, 5, 0, 5);
                btnThirdStat.ForeColor = a.TextColor;
                btnThirdStat.Size = new Size(75, 23);
                btnThirdStat.AutoSize = false;

                flowStatsThird.Controls.Add(btnThirdStat);

                txtTestBox.Text = DaysDisplayed.ToString(); //timeSpan.TotalHours.ToString();
                txtTestBoxTwo.Text = startDate.ToString("ddd d hh:mm tt");
                TxtTestBoxThree.Text = endDate.ToString("ddd d hh:mm tt");


                  

            }
            if (flowIgnoreActivity.Controls.Count == 0)
            {
                //PopulateIgnoreCheckBoxes(startDate, endDate);
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

        

        //private void EventCkBx_Click(object? sender, EventArgs e)
        //{
            
        //    CheckBox chk = sender as CheckBox;
        //    foreach (Control c in flowLayoutPanel1.Controls)
        //    {
        //        if (((CheckBox)c).Checked)
        //        {
                    
        //        }
        //    }
        //    if (chk.Checked)
        //    {
        //        chk.Font = new Font("Arial", 10, FontStyle.Bold);

        //    }
        //    if (!chk.Checked)
        //    {
        //        chk.Font = new Font("Arial", 10, FontStyle.Regular);
        //    }
            
        //}
                
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

       
        private void cdrDisplayEvents_DateChanged(object sender, DateRangeEventArgs e)
        {
            
            activities = Activity.GetActivityList();
            List<Event> events = new List<Event>(Activity.GetEvents(e.Start, e.End));
            //PopulateEventList(e.Start, e.End);
            PopulateStats(e.Start, e.End);
        }

        
        private void btnCreateNewEventCurrent_Click(object sender, EventArgs e)
        {
            //Form form = new frmCurrentActivity();
            //form.Show();
            //this.Hide();
        }
       
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

        //private void btnDeleteEvent_Click(object sender, EventArgs e)
        //{
        //    activities = Activity.GetActivityList();
        //    List<Event> eventsSelected = new List<Event>();
        //    List<DateTime> startTimeToDelete = new List<DateTime>();
        //    List <string> ckDisplays = new List<string>();
        //    foreach (Control c in flowLayoutPanel1.Controls)
        //    {
        //        if (((CheckBox)c).Checked)
        //        {
        //            ckDisplays.Add(c.Name);
        //        }
        //    }
        //    foreach (string c in ckDisplays)
        //    {
        //        foreach (Activity activity in activities)
        //        {
        //            var itemToRemove = activity.Events.SingleOrDefault(x => x.ButtonName() == c);
        //            if (itemToRemove != null)
        //                activity.Events.Remove(itemToRemove);
                           
        //        }
        //    }
                        
        //    Activity.SaveActivityList(activities);
        //    DateTime lastWeekStart = DateTime.Now.AddDays(-7);
            
        //    //PopulateEventList(lastWeekStart, DateTime.Now);
            
        //}

        private void dtpDailyView_ValueChanged(object sender, EventArgs e)
        {
            pnlDailyView.Controls.Clear();
            DisplayDailyView(DateTime.Parse(lblDailyView.Text), dtpDailyView.Value.Hour, dtpDailyView.Value.Minute);
           
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
                //PopulateEventList(firstEvent, DateTime.Now);
            }
        }

        private void rbToday_CheckedChanged(object sender, EventArgs e)
        {
            List<Event> events = new List<Event>(Activity.GetAllEvents());
            //DateTime wokeUP = new DateTime();
            //foreach (Event ev in events.Where(e => e.Name == "Sleep"))
            //{
            //    wokeUP = events.Max(a => a.EndTime);
            //}
           
            btnStatsNextDay.Visible = rbToday.Checked;
            btnStatsPreviousDay.Visible = rbToday.Checked;
            if (rbToday.Checked)
            {
                lblTimeFilterRange.Text = DateTime.Today.ToString("ddd MMM d");
                
                PopulateStats(DateTime.Today, DateTime.Now);
                //PopulateEventList(DateTime.Today, DateTime.Now);
            }
           
            
        }

        private void rbWeek_CheckedChanged(object sender, EventArgs e)
        {
           
            ///TimeSpan second = new TimeSpan(0, 0, 0, 1);
            DateTime StartOfWeek = DateTime.Now.StartOfWeek(DayOfWeek.Monday);
            DateTime EndOfWeek = StartOfWeek.AddDays(7) - milliSecond;

            PopulateStats(StartOfWeek, EndOfWeek);
            //PopulateEventList(StartOfWeek, EndOfWeek);
            if (rbWeek.Checked)

            {
                lblTimeFilterRange.Text = StartOfWeek.ToString("M/d") + "-" + EndOfWeek.ToString("M/d");
                
                
                btnLastWeek.Visible = true;
                btnNextWeek.Visible = true;
            }
            if (!rbWeek.Checked)
            {
                
                btnLastWeek.Visible = false;
                btnNextWeek.Visible = false;
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
            PopulateStats(StartOfWeek, EndOfWeek);
            
            TimeSpan ts = EndOfWeek - StartOfWeek;
            Double days = ts.TotalDays;
            lblTimeFilterRange.Text = StartOfWeek.ToString("M/d") + "-" + EndOfWeek.ToString("M/d");
            

        }

        private void btnNextWeek_Click(object sender, EventArgs e)
        {

            string weekStart = lblTimeFilterRange.Text.Substring(0, lblTimeFilterRange.Text.IndexOf("-"));
            txtTestBox.Text = weekStart;


            DateTime lastWeek = DateTime.Parse(weekStart).AddDays(7);
            DateTime StartOfWeek = lastWeek.StartOfWeek(DayOfWeek.Monday);
            DateTime EndOfWeek = StartOfWeek.AddDays(7) - milliSecond;
            PopulateStats(StartOfWeek, EndOfWeek);

            TimeSpan ts = EndOfWeek - StartOfWeek;
            Double days = ts.TotalDays;
            lblTimeFilterRange.Text = StartOfWeek.ToString("M/d") + "-" + EndOfWeek.ToString("M/d");

        }

        private void rbMonth_CheckedChanged(object sender, EventArgs e)
        {
            btnNextMonth.Visible = rbMonth.Checked;
            btnLastMonth.Visible = rbMonth.Checked;
            if (rbMonth.Checked)
                lblTimeFilterRange.Text = DateTime.Now.ToString("MMMM");

            var firstDayOfMonth = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            var lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddSeconds(-1);
            PopulateStats(firstDayOfMonth, lastDayOfMonth);




        }

        private void btnLastMonth_Click(object sender, EventArgs e)
        {
            DateTime thisMonth = DateTime.ParseExact(lblTimeFilterRange.Text, 
                "MMMM", System.Globalization.CultureInfo.InvariantCulture);
            DateTime displayMonth = thisMonth.AddMonths(-1);
            lblTimeFilterRange.Text = displayMonth.ToString("MMMM");

            var firstDayOfMonth = new DateTime(displayMonth.Year, displayMonth.Month, 1);
            var lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddSeconds(-1);
            PopulateStats(firstDayOfMonth, lastDayOfMonth);
            txtTestBoxTwo.Text = firstDayOfMonth.ToString();
            TxtTestBoxThree.Text = lastDayOfMonth.ToString();
        }

        private void btnNextMonth_Click(object sender, EventArgs e)
        {
            DateTime thisMonth = DateTime.ParseExact(lblTimeFilterRange.Text,
               "MMMM", System.Globalization.CultureInfo.InvariantCulture);
            DateTime displayMonth = thisMonth.AddMonths(1);
            lblTimeFilterRange.Text = displayMonth.ToString("MMMM");

            var firstDayOfMonth = new DateTime(displayMonth.Year, displayMonth.Month, 1);
            var lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddSeconds(-1);
            PopulateStats(firstDayOfMonth, lastDayOfMonth);
            txtTestBoxTwo.Text = firstDayOfMonth.ToString();
            TxtTestBoxThree.Text = lastDayOfMonth.ToString();
        }

        private void rbCustom_CheckedChanged(object sender, EventArgs e)
        {
            cdrDisplayEvents.Visible = rbCustom.Checked;
            lblTimeFilterRange.Visible = !rbCustom.Checked;
            
        }

        private void btnStatsPreviousDay_Click(object sender, EventArgs e)
        {
            DateTime day = DateTime.Parse(lblTimeFilterRange.Text).AddDays(-1);
            lblTimeFilterRange.Text = day.ToString("ddd MMM d");
            PopulateStats(day, day.AddDays(1));
        }

        private void btnStatsNextDay_Click(object sender, EventArgs e)
        {
            DateTime day = DateTime.Parse(lblTimeFilterRange.Text).AddDays(1);
            lblTimeFilterRange.Text = day.ToString("ddd MMM d");
            PopulateStats(day, day.AddDays(1));
        }
    }
}
