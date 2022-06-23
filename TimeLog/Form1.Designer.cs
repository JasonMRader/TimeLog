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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblCurrentEventStart = new System.Windows.Forms.Label();
            this.lblStartLabel = new System.Windows.Forms.Label();
            this.lblCurrentDuration = new System.Windows.Forms.Label();
            this.btnStopCurrentActivity = new System.Windows.Forms.Button();
            this.btnStartCurrent = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblOldEnd = new System.Windows.Forms.Label();
            this.lblOldStart = new System.Windows.Forms.Label();
            this.btnRecordPastEvent = new System.Windows.Forms.Button();
            this.dtpPastEventEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpPastEventStart = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.lbxAllActivities = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnCreateNewType = new System.Windows.Forms.Button();
            this.txtNewActivityName = new System.Windows.Forms.TextBox();
            this.lbxDisplayEvents = new System.Windows.Forms.ListBox();
            this.cdrDisplayEvents = new System.Windows.Forms.MonthCalendar();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(278, 375);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.lblCurrentEventStart);
            this.tabPage1.Controls.Add(this.lblStartLabel);
            this.tabPage1.Controls.Add(this.lblCurrentDuration);
            this.tabPage1.Controls.Add(this.btnStopCurrentActivity);
            this.tabPage1.Controls.Add(this.btnStartCurrent);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(270, 347);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Start New Activity";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblCurrentEventStart
            // 
            this.lblCurrentEventStart.AutoSize = true;
            this.lblCurrentEventStart.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCurrentEventStart.Location = new System.Drawing.Point(83, 59);
            this.lblCurrentEventStart.Name = "lblCurrentEventStart";
            this.lblCurrentEventStart.Size = new System.Drawing.Size(106, 25);
            this.lblCurrentEventStart.TabIndex = 12;
            this.lblCurrentEventStart.Text = "#StartTime";
            this.lblCurrentEventStart.Visible = false;
            // 
            // lblStartLabel
            // 
            this.lblStartLabel.AutoSize = true;
            this.lblStartLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStartLabel.Location = new System.Drawing.Point(3, 59);
            this.lblStartLabel.Name = "lblStartLabel";
            this.lblStartLabel.Size = new System.Drawing.Size(74, 25);
            this.lblStartLabel.TabIndex = 10;
            this.lblStartLabel.Text = "Started";
            this.lblStartLabel.Visible = false;
            // 
            // lblCurrentDuration
            // 
            this.lblCurrentDuration.AutoSize = true;
            this.lblCurrentDuration.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCurrentDuration.Location = new System.Drawing.Point(3, 139);
            this.lblCurrentDuration.Name = "lblCurrentDuration";
            this.lblCurrentDuration.Size = new System.Drawing.Size(37, 30);
            this.lblCurrentDuration.TabIndex = 4;
            this.lblCurrentDuration.Text = "00";
            this.lblCurrentDuration.Visible = false;
            // 
            // btnStopCurrentActivity
            // 
            this.btnStopCurrentActivity.Enabled = false;
            this.btnStopCurrentActivity.Location = new System.Drawing.Point(118, 274);
            this.btnStopCurrentActivity.Name = "btnStopCurrentActivity";
            this.btnStopCurrentActivity.Size = new System.Drawing.Size(96, 52);
            this.btnStopCurrentActivity.TabIndex = 3;
            this.btnStopCurrentActivity.Text = "Stop!";
            this.btnStopCurrentActivity.UseVisualStyleBackColor = true;
            this.btnStopCurrentActivity.Click += new System.EventHandler(this.btnStopCurrentActivity_Click);
            // 
            // btnStartCurrent
            // 
            this.btnStartCurrent.Enabled = false;
            this.btnStartCurrent.Location = new System.Drawing.Point(6, 274);
            this.btnStartCurrent.Name = "btnStartCurrent";
            this.btnStartCurrent.Size = new System.Drawing.Size(106, 52);
            this.btnStartCurrent.TabIndex = 2;
            this.btnStartCurrent.Text = "Start!";
            this.btnStartCurrent.UseVisualStyleBackColor = true;
            this.btnStartCurrent.Click += new System.EventHandler(this.btnStartCurrent_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblOldEnd);
            this.tabPage2.Controls.Add(this.lblOldStart);
            this.tabPage2.Controls.Add(this.btnRecordPastEvent);
            this.tabPage2.Controls.Add(this.dtpPastEventEnd);
            this.tabPage2.Controls.Add(this.dtpPastEventStart);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(270, 347);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Record Previous Activity";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblOldEnd
            // 
            this.lblOldEnd.AutoSize = true;
            this.lblOldEnd.Location = new System.Drawing.Point(117, 49);
            this.lblOldEnd.Name = "lblOldEnd";
            this.lblOldEnd.Size = new System.Drawing.Size(38, 15);
            this.lblOldEnd.TabIndex = 3;
            this.lblOldEnd.Text = "label2";
            this.lblOldEnd.Visible = false;
            // 
            // lblOldStart
            // 
            this.lblOldStart.AutoSize = true;
            this.lblOldStart.Location = new System.Drawing.Point(6, 49);
            this.lblOldStart.Name = "lblOldStart";
            this.lblOldStart.Size = new System.Drawing.Size(88, 15);
            this.lblOldStart.TabIndex = 3;
            this.lblOldStart.Text = "OldStartDisplay";
            this.lblOldStart.Visible = false;
            // 
            // btnRecordPastEvent
            // 
            this.btnRecordPastEvent.Enabled = false;
            this.btnRecordPastEvent.Location = new System.Drawing.Point(6, 168);
            this.btnRecordPastEvent.Name = "btnRecordPastEvent";
            this.btnRecordPastEvent.Size = new System.Drawing.Size(106, 23);
            this.btnRecordPastEvent.TabIndex = 2;
            this.btnRecordPastEvent.Text = "Save Activity";
            this.btnRecordPastEvent.UseVisualStyleBackColor = true;
            this.btnRecordPastEvent.Click += new System.EventHandler(this.btnRecordPastEvent_Click);
            // 
            // dtpPastEventEnd
            // 
            this.dtpPastEventEnd.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpPastEventEnd.Location = new System.Drawing.Point(117, 67);
            this.dtpPastEventEnd.Name = "dtpPastEventEnd";
            this.dtpPastEventEnd.Size = new System.Drawing.Size(105, 23);
            this.dtpPastEventEnd.TabIndex = 1;
            this.dtpPastEventEnd.ValueChanged += new System.EventHandler(this.dtpPastEventEnd_ValueChanged);
            // 
            // dtpPastEventStart
            // 
            this.dtpPastEventStart.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpPastEventStart.Location = new System.Drawing.Point(6, 67);
            this.dtpPastEventStart.Name = "dtpPastEventStart";
            this.dtpPastEventStart.Size = new System.Drawing.Size(105, 23);
            this.dtpPastEventStart.TabIndex = 1;
            this.dtpPastEventStart.ValueChanged += new System.EventHandler(this.dtpPastEventStart_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(292, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Activity";
            // 
            // lbxAllActivities
            // 
            this.lbxAllActivities.FormattingEnabled = true;
            this.lbxAllActivities.ItemHeight = 15;
            this.lbxAllActivities.Location = new System.Drawing.Point(292, 40);
            this.lbxAllActivities.Name = "lbxAllActivities";
            this.lbxAllActivities.Size = new System.Drawing.Size(120, 334);
            this.lbxAllActivities.TabIndex = 7;
            this.lbxAllActivities.SelectedIndexChanged += new System.EventHandler(this.lbxAllActivities_SelectedIndexChanged);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnCreateNewType
            // 
            this.btnCreateNewType.Location = new System.Drawing.Point(418, 36);
            this.btnCreateNewType.Name = "btnCreateNewType";
            this.btnCreateNewType.Size = new System.Drawing.Size(163, 23);
            this.btnCreateNewType.TabIndex = 8;
            this.btnCreateNewType.Text = "Create New Catagory";
            this.btnCreateNewType.UseVisualStyleBackColor = true;
            this.btnCreateNewType.Click += new System.EventHandler(this.btnCreateNewType_Click);
            // 
            // txtNewActivityName
            // 
            this.txtNewActivityName.Location = new System.Drawing.Point(418, 65);
            this.txtNewActivityName.Name = "txtNewActivityName";
            this.txtNewActivityName.Size = new System.Drawing.Size(163, 23);
            this.txtNewActivityName.TabIndex = 9;
            // 
            // lbxDisplayEvents
            // 
            this.lbxDisplayEvents.FormattingEnabled = true;
            this.lbxDisplayEvents.ItemHeight = 15;
            this.lbxDisplayEvents.Location = new System.Drawing.Point(649, 250);
            this.lbxDisplayEvents.Name = "lbxDisplayEvents";
            this.lbxDisplayEvents.Size = new System.Drawing.Size(295, 469);
            this.lbxDisplayEvents.TabIndex = 10;
            // 
            // cdrDisplayEvents
            // 
            this.cdrDisplayEvents.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
            this.cdrDisplayEvents.Location = new System.Drawing.Point(649, 36);
            this.cdrDisplayEvents.Name = "cdrDisplayEvents";
            this.cdrDisplayEvents.TabIndex = 11;
            this.cdrDisplayEvents.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.cdrDisplayEvents_DateChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(6, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 30);
            this.label2.TabIndex = 8;
            this.label2.Text = "Start Something!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 819);
            this.Controls.Add(this.cdrDisplayEvents);
            this.Controls.Add(this.lbxDisplayEvents);
            this.Controls.Add(this.txtNewActivityName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCreateNewType);
            this.Controls.Add(this.lbxAllActivities);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private ListBox lbxAllActivities;
        private Label label1;
        private Label lblCurrentDuration;
        private Button btnStopCurrentActivity;
        private Button btnStartCurrent;
        private TabPage tabPage2;
        private DateTimePicker dtpPastEventEnd;
        private DateTimePicker dtpPastEventStart;
        private System.Windows.Forms.Timer timer1;
        private Button btnCreateNewType;
        private TextBox txtNewActivityName;
        private Button btnRecordPastEvent;
        private Label lblCurrentEventStart;
        private Label lblStartLabel;
        private ListBox lbxDisplayEvents;
        private MonthCalendar cdrDisplayEvents;
        private Label lblOldEnd;
        private Label lblOldStart;
        private Label label2;
    }
}