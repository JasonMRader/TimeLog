namespace TimeLog
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cdrDisplayEvents = new System.Windows.Forms.MonthCalendar();
            this.btnCreateNewEventCurrent = new System.Windows.Forms.Button();
            this.pnlDailyView = new System.Windows.Forms.Panel();
            this.btnNextDay = new System.Windows.Forms.Button();
            this.btnPreviousDay = new System.Windows.Forms.Button();
            this.lblDailyView = new System.Windows.Forms.Label();
            this.flowStatsActivity = new System.Windows.Forms.FlowLayoutPanel();
            this.flowStatsFirst = new System.Windows.Forms.FlowLayoutPanel();
            this.flowStatsSecond = new System.Windows.Forms.FlowLayoutPanel();
            this.dtpDailyView = new System.Windows.Forms.DateTimePicker();
            this.pnlDvTime = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNextHour = new System.Windows.Forms.Button();
            this.btnPreviousHour = new System.Windows.Forms.Button();
            this.btnAddEditActivities = new System.Windows.Forms.Button();
            this.rbWeek = new System.Windows.Forms.RadioButton();
            this.rbAllTime = new System.Windows.Forms.RadioButton();
            this.rbMonth = new System.Windows.Forms.RadioButton();
            this.gbFilters = new System.Windows.Forms.GroupBox();
            this.lblTodayDisplay = new System.Windows.Forms.Label();
            this.btnStatsPreviousDay = new System.Windows.Forms.Button();
            this.btnStatsNextDay = new System.Windows.Forms.Button();
            this.rbCustom = new System.Windows.Forms.RadioButton();
            this.btnLastMonth = new System.Windows.Forms.Button();
            this.btnNextMonth = new System.Windows.Forms.Button();
            this.lblDisplayMonth = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEndOfWeek = new System.Windows.Forms.Label();
            this.btnNextWeek = new System.Windows.Forms.Button();
            this.btnLastWeek = new System.Windows.Forms.Button();
            this.lblDisplayWeek = new System.Windows.Forms.Label();
            this.rbToday = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.flowStatsThird = new System.Windows.Forms.FlowLayoutPanel();
            this.txtTestBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTestBoxTwo = new System.Windows.Forms.TextBox();
            this.TxtTestBoxThree = new System.Windows.Forms.TextBox();
            this.flowIgnoreActivity = new System.Windows.Forms.FlowLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.lbxTest = new System.Windows.Forms.ListBox();
            this.flowStartCurrent = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.gbFilters.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // cdrDisplayEvents
            // 
            this.cdrDisplayEvents.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
            this.cdrDisplayEvents.Location = new System.Drawing.Point(801, 16);
            this.cdrDisplayEvents.MaxSelectionCount = 31;
            this.cdrDisplayEvents.Name = "cdrDisplayEvents";
            this.cdrDisplayEvents.TabIndex = 11;
            this.cdrDisplayEvents.Visible = false;
            this.cdrDisplayEvents.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.cdrDisplayEvents_DateChanged);
            // 
            // btnCreateNewEventCurrent
            // 
            this.btnCreateNewEventCurrent.Location = new System.Drawing.Point(850, 805);
            this.btnCreateNewEventCurrent.Name = "btnCreateNewEventCurrent";
            this.btnCreateNewEventCurrent.Size = new System.Drawing.Size(80, 34);
            this.btnCreateNewEventCurrent.TabIndex = 12;
            this.btnCreateNewEventCurrent.Text = "Start New Activity";
            this.btnCreateNewEventCurrent.UseVisualStyleBackColor = true;
            this.btnCreateNewEventCurrent.Visible = false;
            this.btnCreateNewEventCurrent.Click += new System.EventHandler(this.btnCreateNewEventCurrent_Click);
            // 
            // pnlDailyView
            // 
            this.pnlDailyView.BackColor = System.Drawing.Color.Black;
            this.pnlDailyView.Location = new System.Drawing.Point(61, 18);
            this.pnlDailyView.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.pnlDailyView.Name = "pnlDailyView";
            this.pnlDailyView.Size = new System.Drawing.Size(200, 1472);
            this.pnlDailyView.TabIndex = 16;
            // 
            // btnNextDay
            // 
            this.btnNextDay.Location = new System.Drawing.Point(224, 12);
            this.btnNextDay.Name = "btnNextDay";
            this.btnNextDay.Size = new System.Drawing.Size(28, 23);
            this.btnNextDay.TabIndex = 17;
            this.btnNextDay.Text = ">";
            this.btnNextDay.UseVisualStyleBackColor = true;
            this.btnNextDay.Click += new System.EventHandler(this.btnNextDay_Click);
            // 
            // btnPreviousDay
            // 
            this.btnPreviousDay.Location = new System.Drawing.Point(72, 12);
            this.btnPreviousDay.Name = "btnPreviousDay";
            this.btnPreviousDay.Size = new System.Drawing.Size(25, 23);
            this.btnPreviousDay.TabIndex = 18;
            this.btnPreviousDay.Text = "<";
            this.btnPreviousDay.UseVisualStyleBackColor = true;
            this.btnPreviousDay.Click += new System.EventHandler(this.btnPreviousDay_Click);
            // 
            // lblDailyView
            // 
            this.lblDailyView.AutoSize = true;
            this.lblDailyView.Location = new System.Drawing.Point(125, 16);
            this.lblDailyView.Name = "lblDailyView";
            this.lblDailyView.Size = new System.Drawing.Size(38, 15);
            this.lblDailyView.TabIndex = 20;
            this.lblDailyView.Text = "label1";
            // 
            // flowStatsActivity
            // 
            this.flowStatsActivity.BackColor = System.Drawing.Color.White;
            this.flowStatsActivity.Location = new System.Drawing.Point(406, 230);
            this.flowStatsActivity.Margin = new System.Windows.Forms.Padding(0);
            this.flowStatsActivity.Name = "flowStatsActivity";
            this.flowStatsActivity.Size = new System.Drawing.Size(128, 364);
            this.flowStatsActivity.TabIndex = 24;
            // 
            // flowStatsFirst
            // 
            this.flowStatsFirst.BackColor = System.Drawing.Color.White;
            this.flowStatsFirst.Location = new System.Drawing.Point(534, 230);
            this.flowStatsFirst.Margin = new System.Windows.Forms.Padding(0);
            this.flowStatsFirst.Name = "flowStatsFirst";
            this.flowStatsFirst.Size = new System.Drawing.Size(100, 364);
            this.flowStatsFirst.TabIndex = 24;
            // 
            // flowStatsSecond
            // 
            this.flowStatsSecond.BackColor = System.Drawing.Color.White;
            this.flowStatsSecond.Location = new System.Drawing.Point(735, 230);
            this.flowStatsSecond.Margin = new System.Windows.Forms.Padding(0);
            this.flowStatsSecond.Name = "flowStatsSecond";
            this.flowStatsSecond.Size = new System.Drawing.Size(100, 364);
            this.flowStatsSecond.TabIndex = 24;
            // 
            // dtpDailyView
            // 
            this.dtpDailyView.CustomFormat = "(\"hh:mm t\")";
            this.dtpDailyView.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpDailyView.Location = new System.Drawing.Point(115, 45);
            this.dtpDailyView.Name = "dtpDailyView";
            this.dtpDailyView.Size = new System.Drawing.Size(84, 23);
            this.dtpDailyView.TabIndex = 25;
            this.dtpDailyView.ValueChanged += new System.EventHandler(this.dtpDailyView_ValueChanged);
            // 
            // pnlDvTime
            // 
            this.pnlDvTime.Location = new System.Drawing.Point(18, 18);
            this.pnlDvTime.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.pnlDvTime.Name = "pnlDvTime";
            this.pnlDvTime.Size = new System.Drawing.Size(43, 1472);
            this.pnlDvTime.TabIndex = 26;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.AutoScroll = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.pnlDvTime);
            this.panel1.Controls.Add(this.pnlDailyView);
            this.panel1.Location = new System.Drawing.Point(7, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(287, 740);
            this.panel1.TabIndex = 28;
            // 
            // btnNextHour
            // 
            this.btnNextHour.Location = new System.Drawing.Point(224, 45);
            this.btnNextHour.Name = "btnNextHour";
            this.btnNextHour.Size = new System.Drawing.Size(28, 23);
            this.btnNextHour.TabIndex = 29;
            this.btnNextHour.Text = ">";
            this.btnNextHour.UseVisualStyleBackColor = true;
            this.btnNextHour.Click += new System.EventHandler(this.btnNextHour_Click);
            // 
            // btnPreviousHour
            // 
            this.btnPreviousHour.Location = new System.Drawing.Point(72, 45);
            this.btnPreviousHour.Name = "btnPreviousHour";
            this.btnPreviousHour.Size = new System.Drawing.Size(28, 23);
            this.btnPreviousHour.TabIndex = 29;
            this.btnPreviousHour.Text = "<";
            this.btnPreviousHour.UseVisualStyleBackColor = true;
            this.btnPreviousHour.Click += new System.EventHandler(this.btnPreviousHour_Click);
            // 
            // btnAddEditActivities
            // 
            this.btnAddEditActivities.Location = new System.Drawing.Point(344, 617);
            this.btnAddEditActivities.Name = "btnAddEditActivities";
            this.btnAddEditActivities.Size = new System.Drawing.Size(591, 33);
            this.btnAddEditActivities.TabIndex = 31;
            this.btnAddEditActivities.Text = "Add / Edit Activities";
            this.btnAddEditActivities.UseVisualStyleBackColor = true;
            this.btnAddEditActivities.Click += new System.EventHandler(this.btnAddEditActivities_Click);
            // 
            // rbWeek
            // 
            this.rbWeek.AutoSize = true;
            this.rbWeek.Checked = true;
            this.rbWeek.Location = new System.Drawing.Point(189, 22);
            this.rbWeek.Name = "rbWeek";
            this.rbWeek.Size = new System.Drawing.Size(54, 19);
            this.rbWeek.TabIndex = 0;
            this.rbWeek.TabStop = true;
            this.rbWeek.Text = "Week";
            this.rbWeek.UseVisualStyleBackColor = true;
            this.rbWeek.CheckedChanged += new System.EventHandler(this.rbWeek_CheckedChanged);
            // 
            // rbAllTime
            // 
            this.rbAllTime.AutoSize = true;
            this.rbAllTime.Location = new System.Drawing.Point(23, 22);
            this.rbAllTime.Name = "rbAllTime";
            this.rbAllTime.Size = new System.Drawing.Size(68, 19);
            this.rbAllTime.TabIndex = 1;
            this.rbAllTime.Text = "All Time";
            this.rbAllTime.UseVisualStyleBackColor = true;
            this.rbAllTime.CheckedChanged += new System.EventHandler(this.rbAllTime_CheckedChanged);
            // 
            // rbMonth
            // 
            this.rbMonth.AutoSize = true;
            this.rbMonth.Location = new System.Drawing.Point(263, 22);
            this.rbMonth.Name = "rbMonth";
            this.rbMonth.Size = new System.Drawing.Size(61, 19);
            this.rbMonth.TabIndex = 2;
            this.rbMonth.Text = "Month";
            this.rbMonth.UseVisualStyleBackColor = true;
            this.rbMonth.CheckedChanged += new System.EventHandler(this.rbMonth_CheckedChanged);
            // 
            // gbFilters
            // 
            this.gbFilters.Controls.Add(this.lblTodayDisplay);
            this.gbFilters.Controls.Add(this.btnStatsPreviousDay);
            this.gbFilters.Controls.Add(this.btnStatsNextDay);
            this.gbFilters.Controls.Add(this.rbCustom);
            this.gbFilters.Controls.Add(this.btnLastMonth);
            this.gbFilters.Controls.Add(this.btnNextMonth);
            this.gbFilters.Controls.Add(this.lblDisplayMonth);
            this.gbFilters.Controls.Add(this.label1);
            this.gbFilters.Controls.Add(this.lblEndOfWeek);
            this.gbFilters.Controls.Add(this.btnNextWeek);
            this.gbFilters.Controls.Add(this.btnLastWeek);
            this.gbFilters.Controls.Add(this.lblDisplayWeek);
            this.gbFilters.Controls.Add(this.rbToday);
            this.gbFilters.Controls.Add(this.rbMonth);
            this.gbFilters.Controls.Add(this.rbAllTime);
            this.gbFilters.Controls.Add(this.rbWeek);
            this.gbFilters.Location = new System.Drawing.Point(331, 56);
            this.gbFilters.Name = "gbFilters";
            this.gbFilters.Size = new System.Drawing.Size(455, 95);
            this.gbFilters.TabIndex = 15;
            this.gbFilters.TabStop = false;
            this.gbFilters.Text = "Filters";
            // 
            // lblTodayDisplay
            // 
            this.lblTodayDisplay.AutoSize = true;
            this.lblTodayDisplay.Location = new System.Drawing.Point(188, 58);
            this.lblTodayDisplay.Name = "lblTodayDisplay";
            this.lblTodayDisplay.Size = new System.Drawing.Size(38, 15);
            this.lblTodayDisplay.TabIndex = 36;
            this.lblTodayDisplay.Text = "Today";
            this.lblTodayDisplay.Visible = false;
            // 
            // btnStatsPreviousDay
            // 
            this.btnStatsPreviousDay.Location = new System.Drawing.Point(97, 49);
            this.btnStatsPreviousDay.Name = "btnStatsPreviousDay";
            this.btnStatsPreviousDay.Size = new System.Drawing.Size(23, 40);
            this.btnStatsPreviousDay.TabIndex = 40;
            this.btnStatsPreviousDay.Text = "<";
            this.btnStatsPreviousDay.UseVisualStyleBackColor = true;
            this.btnStatsPreviousDay.Visible = false;
            this.btnStatsPreviousDay.Click += new System.EventHandler(this.btnStatsPreviousDay_Click);
            // 
            // btnStatsNextDay
            // 
            this.btnStatsNextDay.Location = new System.Drawing.Point(327, 51);
            this.btnStatsNextDay.Name = "btnStatsNextDay";
            this.btnStatsNextDay.Size = new System.Drawing.Size(23, 40);
            this.btnStatsNextDay.TabIndex = 41;
            this.btnStatsNextDay.Text = ">";
            this.btnStatsNextDay.UseVisualStyleBackColor = true;
            this.btnStatsNextDay.Visible = false;
            this.btnStatsNextDay.Click += new System.EventHandler(this.btnStatsNextDay_Click);
            // 
            // rbCustom
            // 
            this.rbCustom.AutoSize = true;
            this.rbCustom.Location = new System.Drawing.Point(345, 22);
            this.rbCustom.Name = "rbCustom";
            this.rbCustom.Size = new System.Drawing.Size(67, 19);
            this.rbCustom.TabIndex = 35;
            this.rbCustom.TabStop = true;
            this.rbCustom.Text = "Custom";
            this.rbCustom.UseVisualStyleBackColor = true;
            this.rbCustom.CheckedChanged += new System.EventHandler(this.rbCustom_CheckedChanged);
            // 
            // btnLastMonth
            // 
            this.btnLastMonth.Location = new System.Drawing.Point(97, 49);
            this.btnLastMonth.Name = "btnLastMonth";
            this.btnLastMonth.Size = new System.Drawing.Size(23, 40);
            this.btnLastMonth.TabIndex = 34;
            this.btnLastMonth.Text = "<";
            this.btnLastMonth.UseVisualStyleBackColor = true;
            this.btnLastMonth.Visible = false;
            this.btnLastMonth.Click += new System.EventHandler(this.btnLastMonth_Click);
            // 
            // btnNextMonth
            // 
            this.btnNextMonth.Location = new System.Drawing.Point(327, 49);
            this.btnNextMonth.Name = "btnNextMonth";
            this.btnNextMonth.Size = new System.Drawing.Size(23, 40);
            this.btnNextMonth.TabIndex = 34;
            this.btnNextMonth.Text = ">";
            this.btnNextMonth.UseVisualStyleBackColor = true;
            this.btnNextMonth.Visible = false;
            this.btnNextMonth.Click += new System.EventHandler(this.btnNextMonth_Click);
            // 
            // lblDisplayMonth
            // 
            this.lblDisplayMonth.AutoSize = true;
            this.lblDisplayMonth.Location = new System.Drawing.Point(179, 58);
            this.lblDisplayMonth.Name = "lblDisplayMonth";
            this.lblDisplayMonth.Size = new System.Drawing.Size(66, 15);
            this.lblDisplayMonth.TabIndex = 33;
            this.lblDisplayMonth.Text = "MonthDisp";
            this.lblDisplayMonth.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(209, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 15);
            this.label1.TabIndex = 32;
            this.label1.Text = "-";
            this.label1.Visible = false;
            // 
            // lblEndOfWeek
            // 
            this.lblEndOfWeek.AutoSize = true;
            this.lblEndOfWeek.Location = new System.Drawing.Point(221, 62);
            this.lblEndOfWeek.Margin = new System.Windows.Forms.Padding(0);
            this.lblEndOfWeek.Name = "lblEndOfWeek";
            this.lblEndOfWeek.Size = new System.Drawing.Size(24, 15);
            this.lblEndOfWeek.TabIndex = 6;
            this.lblEndOfWeek.Text = "8/8";
            this.lblEndOfWeek.Visible = false;
            // 
            // btnNextWeek
            // 
            this.btnNextWeek.Location = new System.Drawing.Point(327, 49);
            this.btnNextWeek.Name = "btnNextWeek";
            this.btnNextWeek.Size = new System.Drawing.Size(23, 40);
            this.btnNextWeek.TabIndex = 5;
            this.btnNextWeek.Text = ">";
            this.btnNextWeek.UseVisualStyleBackColor = true;
            this.btnNextWeek.Visible = false;
            this.btnNextWeek.Click += new System.EventHandler(this.btnNextWeek_Click);
            // 
            // btnLastWeek
            // 
            this.btnLastWeek.Location = new System.Drawing.Point(97, 49);
            this.btnLastWeek.Name = "btnLastWeek";
            this.btnLastWeek.Size = new System.Drawing.Size(23, 40);
            this.btnLastWeek.TabIndex = 5;
            this.btnLastWeek.Text = "<";
            this.btnLastWeek.UseVisualStyleBackColor = true;
            this.btnLastWeek.Visible = false;
            this.btnLastWeek.Click += new System.EventHandler(this.btnLastWeek_Click);
            // 
            // lblDisplayWeek
            // 
            this.lblDisplayWeek.AutoSize = true;
            this.lblDisplayWeek.Location = new System.Drawing.Point(179, 62);
            this.lblDisplayWeek.Margin = new System.Windows.Forms.Padding(0);
            this.lblDisplayWeek.Name = "lblDisplayWeek";
            this.lblDisplayWeek.Size = new System.Drawing.Size(24, 15);
            this.lblDisplayWeek.TabIndex = 4;
            this.lblDisplayWeek.Text = "8/8";
            this.lblDisplayWeek.Visible = false;
            // 
            // rbToday
            // 
            this.rbToday.AutoSize = true;
            this.rbToday.Location = new System.Drawing.Point(110, 22);
            this.rbToday.Name = "rbToday";
            this.rbToday.Size = new System.Drawing.Size(56, 19);
            this.rbToday.TabIndex = 3;
            this.rbToday.Text = "Today";
            this.rbToday.UseVisualStyleBackColor = true;
            this.rbToday.CheckedChanged += new System.EventHandler(this.rbToday_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(406, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 32;
            this.label2.Text = "Activity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(534, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 32;
            this.label3.Text = "Total Hours";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(735, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 15);
            this.label4.TabIndex = 32;
            this.label4.Text = "Percentage";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(634, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 15);
            this.label5.TabIndex = 32;
            this.label5.Text = "Per Day";
            // 
            // flowStatsThird
            // 
            this.flowStatsThird.Location = new System.Drawing.Point(634, 230);
            this.flowStatsThird.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.flowStatsThird.Name = "flowStatsThird";
            this.flowStatsThird.Size = new System.Drawing.Size(100, 364);
            this.flowStatsThird.TabIndex = 33;
            // 
            // txtTestBox
            // 
            this.txtTestBox.Location = new System.Drawing.Point(629, 786);
            this.txtTestBox.Name = "txtTestBox";
            this.txtTestBox.Size = new System.Drawing.Size(100, 23);
            this.txtTestBox.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(629, 768);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 15);
            this.label6.TabIndex = 35;
            this.label6.Text = "TestBox";
            // 
            // txtTestBoxTwo
            // 
            this.txtTestBoxTwo.Location = new System.Drawing.Point(629, 812);
            this.txtTestBoxTwo.Name = "txtTestBoxTwo";
            this.txtTestBoxTwo.Size = new System.Drawing.Size(157, 23);
            this.txtTestBoxTwo.TabIndex = 36;
            // 
            // TxtTestBoxThree
            // 
            this.TxtTestBoxThree.Location = new System.Drawing.Point(629, 841);
            this.TxtTestBoxThree.Name = "TxtTestBoxThree";
            this.TxtTestBoxThree.Size = new System.Drawing.Size(157, 23);
            this.TxtTestBoxThree.TabIndex = 36;
            // 
            // flowIgnoreActivity
            // 
            this.flowIgnoreActivity.Location = new System.Drawing.Point(835, 230);
            this.flowIgnoreActivity.Margin = new System.Windows.Forms.Padding(0);
            this.flowIgnoreActivity.Name = "flowIgnoreActivity";
            this.flowIgnoreActivity.Size = new System.Drawing.Size(100, 364);
            this.flowIgnoreActivity.TabIndex = 37;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(835, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 15);
            this.label7.TabIndex = 38;
            this.label7.Text = "Ignore?";
            // 
            // lbxTest
            // 
            this.lbxTest.FormattingEnabled = true;
            this.lbxTest.ItemHeight = 15;
            this.lbxTest.Location = new System.Drawing.Point(471, 770);
            this.lbxTest.Name = "lbxTest";
            this.lbxTest.Size = new System.Drawing.Size(120, 94);
            this.lbxTest.TabIndex = 39;
            // 
            // flowStartCurrent
            // 
            this.flowStartCurrent.Location = new System.Drawing.Point(331, 230);
            this.flowStartCurrent.Margin = new System.Windows.Forms.Padding(0);
            this.flowStartCurrent.Name = "flowStartCurrent";
            this.flowStartCurrent.Size = new System.Drawing.Size(75, 364);
            this.flowStartCurrent.TabIndex = 40;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1041, 892);
            this.Controls.Add(this.flowStartCurrent);
            this.Controls.Add(this.lbxTest);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.flowIgnoreActivity);
            this.Controls.Add(this.TxtTestBoxThree);
            this.Controls.Add(this.txtTestBoxTwo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTestBox);
            this.Controls.Add(this.flowStatsThird);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAddEditActivities);
            this.Controls.Add(this.btnPreviousHour);
            this.Controls.Add(this.btnNextHour);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowStatsSecond);
            this.Controls.Add(this.dtpDailyView);
            this.Controls.Add(this.flowStatsFirst);
            this.Controls.Add(this.flowStatsActivity);
            this.Controls.Add(this.lblDailyView);
            this.Controls.Add(this.btnPreviousDay);
            this.Controls.Add(this.btnNextDay);
            this.Controls.Add(this.gbFilters);
            this.Controls.Add(this.btnCreateNewEventCurrent);
            this.Controls.Add(this.cdrDisplayEvents);
            this.Name = "Form1";
            this.Text = "Time Keeper";
            this.Activated += new System.EventHandler(this.Form1_Load);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.gbFilters.ResumeLayout(false);
            this.gbFilters.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private MonthCalendar cdrDisplayEvents;
        private Button btnCreateNewEventCurrent;
        private Panel pnlDailyView;
        private Button btnNextDay;
        private Button btnPreviousDay;
        private Label lblDailyView;
        private FlowLayoutPanel flowStatsActivity;
        private FlowLayoutPanel flowStatsFirst;
        private FlowLayoutPanel flowStatsSecond;
        private DateTimePicker dtpDailyView;
        private Panel pnlDvTime;
        private Panel panel1;
        private Button btnNextHour;
        private Button btnPreviousHour;
        private Button btnAddEditActivities;
        private RadioButton rbWeek;
        private RadioButton rbAllTime;
        private RadioButton rbMonth;
        private GroupBox gbFilters;
        private RadioButton rbToday;
        private Button btnNextWeek;
        private Button btnLastWeek;
        private Label lblDisplayWeek;
        private Label lblEndOfWeek;
        private Label label1;
        private Label lblDisplayMonth;
        private Button btnLastMonth;
        private Button btnNextMonth;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private FlowLayoutPanel flowStatsThird;
        private TextBox txtTestBox;
        private Label label6;
        private TextBox txtTestBoxTwo;
        private TextBox TxtTestBoxThree;
        private FlowLayoutPanel flowIgnoreActivity;
        private Label label7;
        private ListBox lbxTest;
        private RadioButton rbCustom;
        private Label lblTodayDisplay;
        private Button btnStatsPreviousDay;
        private Button btnStatsNextDay;
        private FlowLayoutPanel flowStartCurrent;
    }
}