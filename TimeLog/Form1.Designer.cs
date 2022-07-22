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
            this.rbCustom = new System.Windows.Forms.RadioButton();
            this.rbToday = new System.Windows.Forms.RadioButton();
            this.lblTimeFilterRange = new System.Windows.Forms.Label();
            this.btnStatsPreviousDay = new System.Windows.Forms.Button();
            this.btnStatsNextDay = new System.Windows.Forms.Button();
            this.btnLastMonth = new System.Windows.Forms.Button();
            this.btnNextMonth = new System.Windows.Forms.Button();
            this.btnNextWeek = new System.Windows.Forms.Button();
            this.btnLastWeek = new System.Windows.Forms.Button();
            this.flowStatsThird = new System.Windows.Forms.FlowLayoutPanel();
            this.txtTestBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTestBoxTwo = new System.Windows.Forms.TextBox();
            this.TxtTestBoxThree = new System.Windows.Forms.TextBox();
            this.flowIgnoreActivity = new System.Windows.Forms.FlowLayoutPanel();
            this.lbxTest = new System.Windows.Forms.ListBox();
            this.flowStartCurrent = new System.Windows.Forms.FlowLayoutPanel();
            this.txtTestBox4 = new System.Windows.Forms.TextBox();
            this.btnUnassigned = new System.Windows.Forms.Button();
            this.cbUnassignedHrs = new System.Windows.Forms.CheckBox();
            this.cbUnassignedHrsPerDay = new System.Windows.Forms.CheckBox();
            this.cbUnassignedPercent = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtpCustomStart = new System.Windows.Forms.DateTimePicker();
            this.dtpCustomEnd = new System.Windows.Forms.DateTimePicker();
            this.lblCustomStart = new System.Windows.Forms.Label();
            this.lblCustomEnd = new System.Windows.Forms.Label();
            this.btnUnignoreAll = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.gbFilters.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnCreateNewEventCurrent
            // 
            this.btnCreateNewEventCurrent.Location = new System.Drawing.Point(719, 886);
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
            this.pnlDailyView.BackColor = System.Drawing.Color.WhiteSmoke;
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
            this.flowStatsActivity.AutoSize = true;
            this.flowStatsActivity.BackColor = System.Drawing.Color.White;
            this.flowStatsActivity.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowStatsActivity.Location = new System.Drawing.Point(86, 0);
            this.flowStatsActivity.Margin = new System.Windows.Forms.Padding(0);
            this.flowStatsActivity.Name = "flowStatsActivity";
            this.flowStatsActivity.Size = new System.Drawing.Size(128, 579);
            this.flowStatsActivity.TabIndex = 24;
            // 
            // flowStatsFirst
            // 
            this.flowStatsFirst.AutoSize = true;
            this.flowStatsFirst.BackColor = System.Drawing.Color.White;
            this.flowStatsFirst.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowStatsFirst.Location = new System.Drawing.Point(214, 0);
            this.flowStatsFirst.Margin = new System.Windows.Forms.Padding(0);
            this.flowStatsFirst.Name = "flowStatsFirst";
            this.flowStatsFirst.Size = new System.Drawing.Size(100, 579);
            this.flowStatsFirst.TabIndex = 24;
            // 
            // flowStatsSecond
            // 
            this.flowStatsSecond.AutoSize = true;
            this.flowStatsSecond.BackColor = System.Drawing.Color.White;
            this.flowStatsSecond.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowStatsSecond.Location = new System.Drawing.Point(415, 0);
            this.flowStatsSecond.Margin = new System.Windows.Forms.Padding(0);
            this.flowStatsSecond.Name = "flowStatsSecond";
            this.flowStatsSecond.Size = new System.Drawing.Size(100, 579);
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
            this.pnlDvTime.BackColor = System.Drawing.Color.DimGray;
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
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pnlDvTime);
            this.panel1.Controls.Add(this.pnlDailyView);
            this.panel1.Location = new System.Drawing.Point(7, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(287, 883);
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
            this.btnAddEditActivities.Location = new System.Drawing.Point(352, 780);
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
            this.rbWeek.Location = new System.Drawing.Point(291, 22);
            this.rbWeek.Name = "rbWeek";
            this.rbWeek.Size = new System.Drawing.Size(54, 19);
            this.rbWeek.TabIndex = 0;
            this.rbWeek.Text = "Week";
            this.rbWeek.UseVisualStyleBackColor = true;
            this.rbWeek.CheckedChanged += new System.EventHandler(this.rbWeek_CheckedChanged);
            // 
            // rbAllTime
            // 
            this.rbAllTime.AutoSize = true;
            this.rbAllTime.Checked = true;
            this.rbAllTime.Location = new System.Drawing.Point(23, 22);
            this.rbAllTime.Name = "rbAllTime";
            this.rbAllTime.Size = new System.Drawing.Size(68, 19);
            this.rbAllTime.TabIndex = 1;
            this.rbAllTime.TabStop = true;
            this.rbAllTime.Text = "All Time";
            this.rbAllTime.UseVisualStyleBackColor = true;
            this.rbAllTime.CheckedChanged += new System.EventHandler(this.rbAllTime_CheckedChanged);
            // 
            // rbMonth
            // 
            this.rbMonth.AutoSize = true;
            this.rbMonth.Location = new System.Drawing.Point(394, 22);
            this.rbMonth.Name = "rbMonth";
            this.rbMonth.Size = new System.Drawing.Size(61, 19);
            this.rbMonth.TabIndex = 2;
            this.rbMonth.Text = "Month";
            this.rbMonth.UseVisualStyleBackColor = true;
            this.rbMonth.CheckedChanged += new System.EventHandler(this.rbMonth_CheckedChanged);
            // 
            // gbFilters
            // 
            this.gbFilters.Controls.Add(this.rbCustom);
            this.gbFilters.Controls.Add(this.rbToday);
            this.gbFilters.Controls.Add(this.rbMonth);
            this.gbFilters.Controls.Add(this.rbAllTime);
            this.gbFilters.Controls.Add(this.rbWeek);
            this.gbFilters.Location = new System.Drawing.Point(329, 12);
            this.gbFilters.Name = "gbFilters";
            this.gbFilters.Size = new System.Drawing.Size(590, 63);
            this.gbFilters.TabIndex = 15;
            this.gbFilters.TabStop = false;
            this.gbFilters.Text = "Filters";
            // 
            // rbCustom
            // 
            this.rbCustom.AutoSize = true;
            this.rbCustom.Location = new System.Drawing.Point(517, 22);
            this.rbCustom.Name = "rbCustom";
            this.rbCustom.Size = new System.Drawing.Size(67, 19);
            this.rbCustom.TabIndex = 35;
            this.rbCustom.Text = "Custom";
            this.rbCustom.UseVisualStyleBackColor = true;
            this.rbCustom.CheckedChanged += new System.EventHandler(this.rbCustom_CheckedChanged);
            // 
            // rbToday
            // 
            this.rbToday.AutoSize = true;
            this.rbToday.Location = new System.Drawing.Point(160, 22);
            this.rbToday.Name = "rbToday";
            this.rbToday.Size = new System.Drawing.Size(45, 19);
            this.rbToday.TabIndex = 3;
            this.rbToday.Text = "Day";
            this.rbToday.UseVisualStyleBackColor = true;
            this.rbToday.CheckedChanged += new System.EventHandler(this.rbToday_CheckedChanged);
            // 
            // lblTimeFilterRange
            // 
            this.lblTimeFilterRange.AutoSize = true;
            this.lblTimeFilterRange.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTimeFilterRange.Location = new System.Drawing.Point(576, 92);
            this.lblTimeFilterRange.Name = "lblTimeFilterRange";
            this.lblTimeFilterRange.Size = new System.Drawing.Size(80, 25);
            this.lblTimeFilterRange.TabIndex = 41;
            this.lblTimeFilterRange.Text = "All Time";
            // 
            // btnStatsPreviousDay
            // 
            this.btnStatsPreviousDay.Location = new System.Drawing.Point(489, 87);
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
            this.btnStatsNextDay.Location = new System.Drawing.Point(745, 85);
            this.btnStatsNextDay.Name = "btnStatsNextDay";
            this.btnStatsNextDay.Size = new System.Drawing.Size(23, 40);
            this.btnStatsNextDay.TabIndex = 41;
            this.btnStatsNextDay.Text = ">";
            this.btnStatsNextDay.UseVisualStyleBackColor = true;
            this.btnStatsNextDay.Visible = false;
            this.btnStatsNextDay.Click += new System.EventHandler(this.btnStatsNextDay_Click);
            // 
            // btnLastMonth
            // 
            this.btnLastMonth.Location = new System.Drawing.Point(489, 87);
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
            this.btnNextMonth.Location = new System.Drawing.Point(745, 85);
            this.btnNextMonth.Name = "btnNextMonth";
            this.btnNextMonth.Size = new System.Drawing.Size(23, 40);
            this.btnNextMonth.TabIndex = 34;
            this.btnNextMonth.Text = ">";
            this.btnNextMonth.UseVisualStyleBackColor = true;
            this.btnNextMonth.Visible = false;
            this.btnNextMonth.Click += new System.EventHandler(this.btnNextMonth_Click);
            // 
            // btnNextWeek
            // 
            this.btnNextWeek.Location = new System.Drawing.Point(745, 85);
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
            this.btnLastWeek.Location = new System.Drawing.Point(489, 87);
            this.btnLastWeek.Name = "btnLastWeek";
            this.btnLastWeek.Size = new System.Drawing.Size(23, 40);
            this.btnLastWeek.TabIndex = 5;
            this.btnLastWeek.Text = "<";
            this.btnLastWeek.UseVisualStyleBackColor = true;
            this.btnLastWeek.Visible = false;
            this.btnLastWeek.Click += new System.EventHandler(this.btnLastWeek_Click);
            // 
            // flowStatsThird
            // 
            this.flowStatsThird.AutoSize = true;
            this.flowStatsThird.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowStatsThird.Location = new System.Drawing.Point(314, 0);
            this.flowStatsThird.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.flowStatsThird.Name = "flowStatsThird";
            this.flowStatsThird.Size = new System.Drawing.Size(100, 579);
            this.flowStatsThird.TabIndex = 33;
            // 
            // txtTestBox
            // 
            this.txtTestBox.Location = new System.Drawing.Point(529, 849);
            this.txtTestBox.Name = "txtTestBox";
            this.txtTestBox.Size = new System.Drawing.Size(157, 23);
            this.txtTestBox.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(529, 831);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 15);
            this.label6.TabIndex = 35;
            this.label6.Text = "TestBox";
            // 
            // txtTestBoxTwo
            // 
            this.txtTestBoxTwo.Location = new System.Drawing.Point(529, 875);
            this.txtTestBoxTwo.Name = "txtTestBoxTwo";
            this.txtTestBoxTwo.Size = new System.Drawing.Size(157, 23);
            this.txtTestBoxTwo.TabIndex = 36;
            // 
            // TxtTestBoxThree
            // 
            this.TxtTestBoxThree.Location = new System.Drawing.Point(529, 904);
            this.TxtTestBoxThree.Name = "TxtTestBoxThree";
            this.TxtTestBoxThree.Size = new System.Drawing.Size(157, 23);
            this.TxtTestBoxThree.TabIndex = 36;
            // 
            // flowIgnoreActivity
            // 
            this.flowIgnoreActivity.AutoSize = true;
            this.flowIgnoreActivity.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowIgnoreActivity.Location = new System.Drawing.Point(515, 0);
            this.flowIgnoreActivity.Margin = new System.Windows.Forms.Padding(0);
            this.flowIgnoreActivity.Name = "flowIgnoreActivity";
            this.flowIgnoreActivity.Size = new System.Drawing.Size(100, 579);
            this.flowIgnoreActivity.TabIndex = 37;
            // 
            // lbxTest
            // 
            this.lbxTest.FormattingEnabled = true;
            this.lbxTest.ItemHeight = 15;
            this.lbxTest.Location = new System.Drawing.Point(383, 841);
            this.lbxTest.Name = "lbxTest";
            this.lbxTest.Size = new System.Drawing.Size(120, 94);
            this.lbxTest.TabIndex = 39;
            // 
            // flowStartCurrent
            // 
            this.flowStartCurrent.AutoSize = true;
            this.flowStartCurrent.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowStartCurrent.Location = new System.Drawing.Point(11, 0);
            this.flowStartCurrent.Margin = new System.Windows.Forms.Padding(0);
            this.flowStartCurrent.Name = "flowStartCurrent";
            this.flowStartCurrent.Size = new System.Drawing.Size(75, 579);
            this.flowStartCurrent.TabIndex = 40;
            // 
            // txtTestBox4
            // 
            this.txtTestBox4.Location = new System.Drawing.Point(699, 849);
            this.txtTestBox4.Name = "txtTestBox4";
            this.txtTestBox4.Size = new System.Drawing.Size(158, 23);
            this.txtTestBox4.TabIndex = 41;
            // 
            // btnUnassigned
            // 
            this.btnUnassigned.Location = new System.Drawing.Point(406, 140);
            this.btnUnassigned.Name = "btnUnassigned";
            this.btnUnassigned.Size = new System.Drawing.Size(128, 23);
            this.btnUnassigned.TabIndex = 42;
            this.btnUnassigned.Text = "Unassigned Time";
            this.btnUnassigned.UseVisualStyleBackColor = true;
            // 
            // cbUnassignedHrs
            // 
            this.cbUnassignedHrs.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbUnassignedHrs.Location = new System.Drawing.Point(534, 140);
            this.cbUnassignedHrs.Name = "cbUnassignedHrs";
            this.cbUnassignedHrs.Size = new System.Drawing.Size(75, 23);
            this.cbUnassignedHrs.TabIndex = 43;
            this.cbUnassignedHrs.Text = "Hrs";
            this.cbUnassignedHrs.UseVisualStyleBackColor = true;
            // 
            // cbUnassignedHrsPerDay
            // 
            this.cbUnassignedHrsPerDay.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbUnassignedHrsPerDay.Location = new System.Drawing.Point(634, 140);
            this.cbUnassignedHrsPerDay.Name = "cbUnassignedHrsPerDay";
            this.cbUnassignedHrsPerDay.Size = new System.Drawing.Size(95, 23);
            this.cbUnassignedHrsPerDay.TabIndex = 43;
            this.cbUnassignedHrsPerDay.Text = "Hrs/Day";
            this.cbUnassignedHrsPerDay.UseVisualStyleBackColor = true;
            // 
            // cbUnassignedPercent
            // 
            this.cbUnassignedPercent.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbUnassignedPercent.Location = new System.Drawing.Point(735, 140);
            this.cbUnassignedPercent.Name = "cbUnassignedPercent";
            this.cbUnassignedPercent.Size = new System.Drawing.Size(75, 23);
            this.cbUnassignedPercent.TabIndex = 43;
            this.cbUnassignedPercent.Text = "unass %";
            this.cbUnassignedPercent.UseVisualStyleBackColor = true;
            this.cbUnassignedPercent.CheckedChanged += new System.EventHandler(this.cbUnassignedPercent_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.flowStatsActivity);
            this.panel2.Controls.Add(this.flowStatsFirst);
            this.panel2.Controls.Add(this.flowStatsSecond);
            this.panel2.Controls.Add(this.flowStatsThird);
            this.panel2.Controls.Add(this.flowIgnoreActivity);
            this.panel2.Controls.Add(this.flowStartCurrent);
            this.panel2.Location = new System.Drawing.Point(314, 178);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(649, 596);
            this.panel2.TabIndex = 44;
            // 
            // dtpCustomStart
            // 
            this.dtpCustomStart.Location = new System.Drawing.Point(329, 105);
            this.dtpCustomStart.Name = "dtpCustomStart";
            this.dtpCustomStart.Size = new System.Drawing.Size(200, 23);
            this.dtpCustomStart.TabIndex = 45;
            this.dtpCustomStart.Visible = false;
            this.dtpCustomStart.ValueChanged += new System.EventHandler(this.dtpCustomStart_ValueChanged);
            // 
            // dtpCustomEnd
            // 
            this.dtpCustomEnd.Location = new System.Drawing.Point(717, 104);
            this.dtpCustomEnd.Name = "dtpCustomEnd";
            this.dtpCustomEnd.Size = new System.Drawing.Size(200, 23);
            this.dtpCustomEnd.TabIndex = 46;
            this.dtpCustomEnd.Visible = false;
            this.dtpCustomEnd.ValueChanged += new System.EventHandler(this.dtpCustomEnd_ValueChanged);
            // 
            // lblCustomStart
            // 
            this.lblCustomStart.AutoSize = true;
            this.lblCustomStart.Location = new System.Drawing.Point(329, 87);
            this.lblCustomStart.Name = "lblCustomStart";
            this.lblCustomStart.Size = new System.Drawing.Size(38, 15);
            this.lblCustomStart.TabIndex = 47;
            this.lblCustomStart.Text = "From:";
            this.lblCustomStart.Visible = false;
            // 
            // lblCustomEnd
            // 
            this.lblCustomEnd.AutoSize = true;
            this.lblCustomEnd.Location = new System.Drawing.Point(717, 87);
            this.lblCustomEnd.Name = "lblCustomEnd";
            this.lblCustomEnd.Size = new System.Drawing.Size(22, 15);
            this.lblCustomEnd.TabIndex = 48;
            this.lblCustomEnd.Text = "To:";
            this.lblCustomEnd.Visible = false;
            // 
            // btnUnignoreAll
            // 
            this.btnUnignoreAll.Location = new System.Drawing.Point(838, 140);
            this.btnUnignoreAll.Name = "btnUnignoreAll";
            this.btnUnignoreAll.Size = new System.Drawing.Size(91, 23);
            this.btnUnignoreAll.TabIndex = 49;
            this.btnUnignoreAll.Text = "Unignore All";
            this.btnUnignoreAll.UseVisualStyleBackColor = true;
            this.btnUnignoreAll.Click += new System.EventHandler(this.btnUnignoreAll_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1019, 992);
            this.Controls.Add(this.btnUnignoreAll);
            this.Controls.Add(this.btnUnassigned);
            this.Controls.Add(this.lblCustomEnd);
            this.Controls.Add(this.lblCustomStart);
            this.Controls.Add(this.cbUnassignedPercent);
            this.Controls.Add(this.dtpCustomEnd);
            this.Controls.Add(this.dtpCustomStart);
            this.Controls.Add(this.cbUnassignedHrsPerDay);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblTimeFilterRange);
            this.Controls.Add(this.cbUnassignedHrs);
            this.Controls.Add(this.btnStatsPreviousDay);
            this.Controls.Add(this.txtTestBox4);
            this.Controls.Add(this.btnStatsNextDay);
            this.Controls.Add(this.lbxTest);
            this.Controls.Add(this.btnLastMonth);
            this.Controls.Add(this.btnNextMonth);
            this.Controls.Add(this.TxtTestBoxThree);
            this.Controls.Add(this.btnNextWeek);
            this.Controls.Add(this.txtTestBoxTwo);
            this.Controls.Add(this.btnLastWeek);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTestBox);
            this.Controls.Add(this.btnAddEditActivities);
            this.Controls.Add(this.btnPreviousHour);
            this.Controls.Add(this.btnNextHour);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtpDailyView);
            this.Controls.Add(this.lblDailyView);
            this.Controls.Add(this.btnPreviousDay);
            this.Controls.Add(this.btnNextDay);
            this.Controls.Add(this.gbFilters);
            this.Controls.Add(this.btnCreateNewEventCurrent);
            this.Name = "Form1";
            this.Text = "Time Keeper";
            this.Activated += new System.EventHandler(this.Form1_Load);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.gbFilters.ResumeLayout(false);
            this.gbFilters.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
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
        private Button btnLastMonth;
        private Button btnNextMonth;
        private FlowLayoutPanel flowStatsThird;
        private TextBox txtTestBox;
        private Label label6;
        private TextBox txtTestBoxTwo;
        private TextBox TxtTestBoxThree;
        private FlowLayoutPanel flowIgnoreActivity;
        private ListBox lbxTest;
        private RadioButton rbCustom;
        private Button btnStatsPreviousDay;
        private Button btnStatsNextDay;
        private FlowLayoutPanel flowStartCurrent;
        private Label lblTimeFilterRange;
        private TextBox txtTestBox4;
        private Button btnUnassigned;
        private CheckBox cbUnassignedHrs;
        private CheckBox cbUnassignedHrsPerDay;
        private CheckBox cbUnassignedPercent;
        private Panel panel2;
        private DateTimePicker dtpCustomStart;
        private DateTimePicker dtpCustomEnd;
        private Label lblCustomStart;
        private Label lblCustomEnd;
        private Button btnUnignoreAll;
    }
}