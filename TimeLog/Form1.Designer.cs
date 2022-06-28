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
            this.lbxDisplayEvents = new System.Windows.Forms.ListBox();
            this.cdrDisplayEvents = new System.Windows.Forms.MonthCalendar();
            this.btnCreateNewEventCurrent = new System.Windows.Forms.Button();
            this.clbActivityFIlter = new System.Windows.Forms.CheckedListBox();
            this.cbxAllActivities = new System.Windows.Forms.CheckBox();
            this.gbFilters = new System.Windows.Forms.GroupBox();
            this.rbAwakeActivities = new System.Windows.Forms.RadioButton();
            this.rbAllTime = new System.Windows.Forms.RadioButton();
            this.rbAwake = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNextDay = new System.Windows.Forms.Button();
            this.btnPreviousDay = new System.Windows.Forms.Button();
            this.gbFilters.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbxDisplayEvents
            // 
            this.lbxDisplayEvents.FormattingEnabled = true;
            this.lbxDisplayEvents.ItemHeight = 15;
            this.lbxDisplayEvents.Location = new System.Drawing.Point(162, 310);
            this.lbxDisplayEvents.Name = "lbxDisplayEvents";
            this.lbxDisplayEvents.Size = new System.Drawing.Size(354, 319);
            this.lbxDisplayEvents.TabIndex = 10;
            // 
            // cdrDisplayEvents
            // 
            this.cdrDisplayEvents.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
            this.cdrDisplayEvents.Location = new System.Drawing.Point(162, 65);
            this.cdrDisplayEvents.Name = "cdrDisplayEvents";
            this.cdrDisplayEvents.TabIndex = 11;
            this.cdrDisplayEvents.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.cdrDisplayEvents_DateChanged);
            // 
            // btnCreateNewEventCurrent
            // 
            this.btnCreateNewEventCurrent.Location = new System.Drawing.Point(174, 23);
            this.btnCreateNewEventCurrent.Name = "btnCreateNewEventCurrent";
            this.btnCreateNewEventCurrent.Size = new System.Drawing.Size(114, 23);
            this.btnCreateNewEventCurrent.TabIndex = 12;
            this.btnCreateNewEventCurrent.Text = "New Event Form";
            this.btnCreateNewEventCurrent.UseVisualStyleBackColor = true;
            this.btnCreateNewEventCurrent.Click += new System.EventHandler(this.btnCreateNewEventCurrent_Click);
            // 
            // clbActivityFIlter
            // 
            this.clbActivityFIlter.FormattingEnabled = true;
            this.clbActivityFIlter.Location = new System.Drawing.Point(401, 74);
            this.clbActivityFIlter.Name = "clbActivityFIlter";
            this.clbActivityFIlter.Size = new System.Drawing.Size(227, 148);
            this.clbActivityFIlter.TabIndex = 13;
            // 
            // cbxAllActivities
            // 
            this.cbxAllActivities.AutoSize = true;
            this.cbxAllActivities.Location = new System.Drawing.Point(401, 49);
            this.cbxAllActivities.Name = "cbxAllActivities";
            this.cbxAllActivities.Size = new System.Drawing.Size(119, 19);
            this.cbxAllActivities.TabIndex = 14;
            this.cbxAllActivities.Text = "View All Activities";
            this.cbxAllActivities.UseVisualStyleBackColor = true;
            // 
            // gbFilters
            // 
            this.gbFilters.Controls.Add(this.rbAwakeActivities);
            this.gbFilters.Controls.Add(this.rbAllTime);
            this.gbFilters.Controls.Add(this.rbAwake);
            this.gbFilters.Location = new System.Drawing.Point(645, 74);
            this.gbFilters.Name = "gbFilters";
            this.gbFilters.Size = new System.Drawing.Size(186, 101);
            this.gbFilters.TabIndex = 15;
            this.gbFilters.TabStop = false;
            this.gbFilters.Text = "Filters";
            // 
            // rbAwakeActivities
            // 
            this.rbAwakeActivities.AutoSize = true;
            this.rbAwakeActivities.Location = new System.Drawing.Point(6, 72);
            this.rbAwakeActivities.Name = "rbAwakeActivities";
            this.rbAwakeActivities.Size = new System.Drawing.Size(136, 19);
            this.rbAwakeActivities.TabIndex = 2;
            this.rbAwakeActivities.TabStop = true;
            this.rbAwakeActivities.Text = "Awake Activites Only";
            this.rbAwakeActivities.UseVisualStyleBackColor = true;
            // 
            // rbAllTime
            // 
            this.rbAllTime.AutoSize = true;
            this.rbAllTime.Location = new System.Drawing.Point(6, 22);
            this.rbAllTime.Name = "rbAllTime";
            this.rbAllTime.Size = new System.Drawing.Size(68, 19);
            this.rbAllTime.TabIndex = 1;
            this.rbAllTime.TabStop = true;
            this.rbAllTime.Text = "All Time";
            this.rbAllTime.UseVisualStyleBackColor = true;
            // 
            // rbAwake
            // 
            this.rbAwake.AutoSize = true;
            this.rbAwake.Location = new System.Drawing.Point(6, 47);
            this.rbAwake.Name = "rbAwake";
            this.rbAwake.Size = new System.Drawing.Size(133, 19);
            this.rbAwake.TabIndex = 0;
            this.rbAwake.TabStop = true;
            this.rbAwake.Text = "Exclude Time Asleep";
            this.rbAwake.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(115, 846);
            this.panel1.TabIndex = 16;
            // 
            // btnNextDay
            // 
            this.btnNextDay.Location = new System.Drawing.Point(99, 36);
            this.btnNextDay.Name = "btnNextDay";
            this.btnNextDay.Size = new System.Drawing.Size(28, 23);
            this.btnNextDay.TabIndex = 17;
            this.btnNextDay.Text = ">";
            this.btnNextDay.UseVisualStyleBackColor = true;
            // 
            // btnPreviousDay
            // 
            this.btnPreviousDay.Location = new System.Drawing.Point(12, 36);
            this.btnPreviousDay.Name = "btnPreviousDay";
            this.btnPreviousDay.Size = new System.Drawing.Size(25, 23);
            this.btnPreviousDay.TabIndex = 18;
            this.btnPreviousDay.Text = "<";
            this.btnPreviousDay.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 923);
            this.Controls.Add(this.btnPreviousDay);
            this.Controls.Add(this.btnNextDay);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbFilters);
            this.Controls.Add(this.cbxAllActivities);
            this.Controls.Add(this.clbActivityFIlter);
            this.Controls.Add(this.btnCreateNewEventCurrent);
            this.Controls.Add(this.cdrDisplayEvents);
            this.Controls.Add(this.lbxDisplayEvents);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbFilters.ResumeLayout(false);
            this.gbFilters.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private ListBox lbxDisplayEvents;
        private MonthCalendar cdrDisplayEvents;
        private Button btnCreateNewEventCurrent;
        private CheckedListBox clbActivityFIlter;
        private CheckBox cbxAllActivities;
        private GroupBox gbFilters;
        private RadioButton rbAwakeActivities;
        private RadioButton rbAllTime;
        private RadioButton rbAwake;
        private Panel panel1;
        private Button btnNextDay;
        private Button btnPreviousDay;
    }
}