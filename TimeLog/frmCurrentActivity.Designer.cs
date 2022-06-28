namespace TimeLog
{
    partial class frmCurrentActivity
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblActivityDisplay = new System.Windows.Forms.Label();
            this.lblStartLabel = new System.Windows.Forms.Label();
            this.lblCurrentEventStart = new System.Windows.Forms.Label();
            this.lblCurrentDuration = new System.Windows.Forms.Label();
            this.btnStartCurrent = new System.Windows.Forms.Button();
            this.btnStopCurrentActivity = new System.Windows.Forms.Button();
            this.lbxAllActivities = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnDone = new System.Windows.Forms.Button();
            this.gbModeSelect = new System.Windows.Forms.GroupBox();
            this.rdoNewCatagory = new System.Windows.Forms.RadioButton();
            this.rdoCurrentEvent = new System.Windows.Forms.RadioButton();
            this.rdoPastEvent = new System.Windows.Forms.RadioButton();
            this.pnlCurrentEvent = new System.Windows.Forms.Panel();
            this.btnCancelCurrent = new System.Windows.Forms.Button();
            this.btnMinusFive = new System.Windows.Forms.Button();
            this.btnAddFive = new System.Windows.Forms.Button();
            this.pnlPassedEvent = new System.Windows.Forms.Panel();
            this.lblPastEventDisplay = new System.Windows.Forms.Label();
            this.btnCancelPastEvent = new System.Windows.Forms.Button();
            this.dtpPastEventEnd = new System.Windows.Forms.DateTimePicker();
            this.lblOldEnd = new System.Windows.Forms.Label();
            this.dtpPastEventStart = new System.Windows.Forms.DateTimePicker();
            this.lblOldStart = new System.Windows.Forms.Label();
            this.pnlNewCatagory = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnColorSelect = new System.Windows.Forms.Button();
            this.txtNewActivityName = new System.Windows.Forms.TextBox();
            this.pnlLbx = new System.Windows.Forms.Panel();
            this.btnRecordPastEvent = new System.Windows.Forms.Button();
            this.btnCreateNewType = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.gbModeSelect.SuspendLayout();
            this.pnlCurrentEvent.SuspendLayout();
            this.pnlPassedEvent.SuspendLayout();
            this.pnlNewCatagory.SuspendLayout();
            this.pnlLbx.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblActivityDisplay
            // 
            this.lblActivityDisplay.AutoSize = true;
            this.lblActivityDisplay.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblActivityDisplay.Location = new System.Drawing.Point(3, 0);
            this.lblActivityDisplay.Name = "lblActivityDisplay";
            this.lblActivityDisplay.Size = new System.Drawing.Size(181, 30);
            this.lblActivityDisplay.TabIndex = 9;
            this.lblActivityDisplay.Text = "Start Something!";
            // 
            // lblStartLabel
            // 
            this.lblStartLabel.AutoSize = true;
            this.lblStartLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStartLabel.Location = new System.Drawing.Point(3, 41);
            this.lblStartLabel.Name = "lblStartLabel";
            this.lblStartLabel.Size = new System.Drawing.Size(74, 25);
            this.lblStartLabel.TabIndex = 11;
            this.lblStartLabel.Text = "Started";
            this.lblStartLabel.Visible = false;
            // 
            // lblCurrentEventStart
            // 
            this.lblCurrentEventStart.AutoSize = true;
            this.lblCurrentEventStart.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCurrentEventStart.Location = new System.Drawing.Point(83, 41);
            this.lblCurrentEventStart.Name = "lblCurrentEventStart";
            this.lblCurrentEventStart.Size = new System.Drawing.Size(106, 25);
            this.lblCurrentEventStart.TabIndex = 13;
            this.lblCurrentEventStart.Text = "#StartTime";
            this.lblCurrentEventStart.Visible = false;
            // 
            // lblCurrentDuration
            // 
            this.lblCurrentDuration.AutoSize = true;
            this.lblCurrentDuration.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCurrentDuration.Location = new System.Drawing.Point(3, 83);
            this.lblCurrentDuration.Name = "lblCurrentDuration";
            this.lblCurrentDuration.Size = new System.Drawing.Size(84, 65);
            this.lblCurrentDuration.TabIndex = 14;
            this.lblCurrentDuration.Text = "00";
            this.lblCurrentDuration.Visible = false;
            // 
            // btnStartCurrent
            // 
            this.btnStartCurrent.Location = new System.Drawing.Point(14, 289);
            this.btnStartCurrent.Name = "btnStartCurrent";
            this.btnStartCurrent.Size = new System.Drawing.Size(281, 52);
            this.btnStartCurrent.TabIndex = 15;
            this.btnStartCurrent.Text = "Start!";
            this.btnStartCurrent.UseVisualStyleBackColor = true;
            this.btnStartCurrent.Visible = false;
            this.btnStartCurrent.Click += new System.EventHandler(this.btnStartCurrent_Click);
            // 
            // btnStopCurrentActivity
            // 
            this.btnStopCurrentActivity.Location = new System.Drawing.Point(14, 289);
            this.btnStopCurrentActivity.Name = "btnStopCurrentActivity";
            this.btnStopCurrentActivity.Size = new System.Drawing.Size(281, 52);
            this.btnStopCurrentActivity.TabIndex = 16;
            this.btnStopCurrentActivity.Text = "Stop!";
            this.btnStopCurrentActivity.UseVisualStyleBackColor = true;
            this.btnStopCurrentActivity.Visible = false;
            this.btnStopCurrentActivity.Click += new System.EventHandler(this.btnStopCurrentActivity_Click);
            // 
            // lbxAllActivities
            // 
            this.lbxAllActivities.FormattingEnabled = true;
            this.lbxAllActivities.ItemHeight = 15;
            this.lbxAllActivities.Location = new System.Drawing.Point(3, 3);
            this.lbxAllActivities.Name = "lbxAllActivities";
            this.lbxAllActivities.Size = new System.Drawing.Size(208, 139);
            this.lbxAllActivities.TabIndex = 17;
            this.lbxAllActivities.SelectedIndexChanged += new System.EventHandler(this.lbxAllActivities_SelectedIndexChanged);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(14, 347);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(281, 52);
            this.btnDone.TabIndex = 18;
            this.btnDone.Text = "Finished";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // gbModeSelect
            // 
            this.gbModeSelect.Controls.Add(this.rdoNewCatagory);
            this.gbModeSelect.Controls.Add(this.rdoCurrentEvent);
            this.gbModeSelect.Controls.Add(this.rdoPastEvent);
            this.gbModeSelect.Location = new System.Drawing.Point(29, 12);
            this.gbModeSelect.Name = "gbModeSelect";
            this.gbModeSelect.Size = new System.Drawing.Size(308, 45);
            this.gbModeSelect.TabIndex = 19;
            this.gbModeSelect.TabStop = false;
            // 
            // rdoNewCatagory
            // 
            this.rdoNewCatagory.AutoSize = true;
            this.rdoNewCatagory.Location = new System.Drawing.Point(193, 11);
            this.rdoNewCatagory.Name = "rdoNewCatagory";
            this.rdoNewCatagory.Size = new System.Drawing.Size(100, 19);
            this.rdoNewCatagory.TabIndex = 2;
            this.rdoNewCatagory.Text = "New Catagory";
            this.rdoNewCatagory.UseVisualStyleBackColor = true;
            this.rdoNewCatagory.CheckedChanged += new System.EventHandler(this.rdoNewCatagory_CheckedChanged);
            // 
            // rdoCurrentEvent
            // 
            this.rdoCurrentEvent.AutoSize = true;
            this.rdoCurrentEvent.Checked = true;
            this.rdoCurrentEvent.Location = new System.Drawing.Point(6, 11);
            this.rdoCurrentEvent.Name = "rdoCurrentEvent";
            this.rdoCurrentEvent.Size = new System.Drawing.Size(97, 19);
            this.rdoCurrentEvent.TabIndex = 1;
            this.rdoCurrentEvent.TabStop = true;
            this.rdoCurrentEvent.Text = "Current Event";
            this.rdoCurrentEvent.UseVisualStyleBackColor = true;
            this.rdoCurrentEvent.CheckedChanged += new System.EventHandler(this.rdoCurrentEvent_CheckedChanged);
            // 
            // rdoPastEvent
            // 
            this.rdoPastEvent.AutoSize = true;
            this.rdoPastEvent.Location = new System.Drawing.Point(109, 11);
            this.rdoPastEvent.Name = "rdoPastEvent";
            this.rdoPastEvent.Size = new System.Drawing.Size(79, 19);
            this.rdoPastEvent.TabIndex = 0;
            this.rdoPastEvent.TabStop = true;
            this.rdoPastEvent.Text = "Past Event";
            this.rdoPastEvent.UseVisualStyleBackColor = true;
            this.rdoPastEvent.CheckedChanged += new System.EventHandler(this.rdoPastEvent_CheckedChanged);
            // 
            // pnlCurrentEvent
            // 
            this.pnlCurrentEvent.Controls.Add(this.btnCancelCurrent);
            this.pnlCurrentEvent.Controls.Add(this.btnMinusFive);
            this.pnlCurrentEvent.Controls.Add(this.lblActivityDisplay);
            this.pnlCurrentEvent.Controls.Add(this.btnAddFive);
            this.pnlCurrentEvent.Controls.Add(this.lblStartLabel);
            this.pnlCurrentEvent.Controls.Add(this.lblCurrentEventStart);
            this.pnlCurrentEvent.Controls.Add(this.lblCurrentDuration);
            this.pnlCurrentEvent.Location = new System.Drawing.Point(14, 95);
            this.pnlCurrentEvent.Name = "pnlCurrentEvent";
            this.pnlCurrentEvent.Size = new System.Drawing.Size(281, 188);
            this.pnlCurrentEvent.TabIndex = 20;
            this.pnlCurrentEvent.Visible = false;
            // 
            // btnCancelCurrent
            // 
            this.btnCancelCurrent.Location = new System.Drawing.Point(12, 151);
            this.btnCancelCurrent.Name = "btnCancelCurrent";
            this.btnCancelCurrent.Size = new System.Drawing.Size(75, 23);
            this.btnCancelCurrent.TabIndex = 28;
            this.btnCancelCurrent.Text = "Cancel";
            this.btnCancelCurrent.UseVisualStyleBackColor = true;
            this.btnCancelCurrent.Click += new System.EventHandler(this.btnCancelCurrent_Click);
            // 
            // btnMinusFive
            // 
            this.btnMinusFive.Location = new System.Drawing.Point(251, 50);
            this.btnMinusFive.Name = "btnMinusFive";
            this.btnMinusFive.Size = new System.Drawing.Size(30, 23);
            this.btnMinusFive.TabIndex = 27;
            this.btnMinusFive.Text = "-5";
            this.btnMinusFive.UseVisualStyleBackColor = true;
            this.btnMinusFive.Click += new System.EventHandler(this.btnMinusFive_Click);
            // 
            // btnAddFive
            // 
            this.btnAddFive.Location = new System.Drawing.Point(251, 30);
            this.btnAddFive.Name = "btnAddFive";
            this.btnAddFive.Size = new System.Drawing.Size(30, 23);
            this.btnAddFive.TabIndex = 26;
            this.btnAddFive.Text = "+5";
            this.btnAddFive.UseVisualStyleBackColor = true;
            this.btnAddFive.Click += new System.EventHandler(this.btnAddFive_Click);
            // 
            // pnlPassedEvent
            // 
            this.pnlPassedEvent.Controls.Add(this.lblPastEventDisplay);
            this.pnlPassedEvent.Controls.Add(this.btnCancelPastEvent);
            this.pnlPassedEvent.Controls.Add(this.dtpPastEventEnd);
            this.pnlPassedEvent.Controls.Add(this.lblOldEnd);
            this.pnlPassedEvent.Controls.Add(this.dtpPastEventStart);
            this.pnlPassedEvent.Controls.Add(this.lblOldStart);
            this.pnlPassedEvent.Location = new System.Drawing.Point(17, 92);
            this.pnlPassedEvent.Name = "pnlPassedEvent";
            this.pnlPassedEvent.Size = new System.Drawing.Size(281, 188);
            this.pnlPassedEvent.TabIndex = 21;
            this.pnlPassedEvent.Visible = false;
            // 
            // lblPastEventDisplay
            // 
            this.lblPastEventDisplay.AutoSize = true;
            this.lblPastEventDisplay.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPastEventDisplay.Location = new System.Drawing.Point(3, 7);
            this.lblPastEventDisplay.Name = "lblPastEventDisplay";
            this.lblPastEventDisplay.Size = new System.Drawing.Size(63, 25);
            this.lblPastEventDisplay.TabIndex = 10;
            this.lblPastEventDisplay.Text = "label2";
            // 
            // btnCancelPastEvent
            // 
            this.btnCancelPastEvent.Location = new System.Drawing.Point(169, 7);
            this.btnCancelPastEvent.Name = "btnCancelPastEvent";
            this.btnCancelPastEvent.Size = new System.Drawing.Size(28, 23);
            this.btnCancelPastEvent.TabIndex = 9;
            this.btnCancelPastEvent.Text = "X";
            this.btnCancelPastEvent.UseVisualStyleBackColor = true;
            this.btnCancelPastEvent.Click += new System.EventHandler(this.btnCancelPastEvent_Click);
            // 
            // dtpPastEventEnd
            // 
            this.dtpPastEventEnd.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpPastEventEnd.Location = new System.Drawing.Point(13, 125);
            this.dtpPastEventEnd.Name = "dtpPastEventEnd";
            this.dtpPastEventEnd.Size = new System.Drawing.Size(105, 23);
            this.dtpPastEventEnd.TabIndex = 7;
            this.dtpPastEventEnd.ValueChanged += new System.EventHandler(this.dtpPastEventEnd_ValueChanged);
            // 
            // lblOldEnd
            // 
            this.lblOldEnd.AutoSize = true;
            this.lblOldEnd.Location = new System.Drawing.Point(14, 107);
            this.lblOldEnd.Name = "lblOldEnd";
            this.lblOldEnd.Size = new System.Drawing.Size(38, 15);
            this.lblOldEnd.TabIndex = 6;
            this.lblOldEnd.Text = "label2";
            this.lblOldEnd.Visible = false;
            // 
            // dtpPastEventStart
            // 
            this.dtpPastEventStart.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpPastEventStart.Location = new System.Drawing.Point(13, 69);
            this.dtpPastEventStart.Name = "dtpPastEventStart";
            this.dtpPastEventStart.Size = new System.Drawing.Size(105, 23);
            this.dtpPastEventStart.TabIndex = 5;
            this.dtpPastEventStart.ValueChanged += new System.EventHandler(this.dtpPastEventStart_ValueChanged);
            // 
            // lblOldStart
            // 
            this.lblOldStart.AutoSize = true;
            this.lblOldStart.Location = new System.Drawing.Point(13, 51);
            this.lblOldStart.Name = "lblOldStart";
            this.lblOldStart.Size = new System.Drawing.Size(88, 15);
            this.lblOldStart.TabIndex = 4;
            this.lblOldStart.Text = "OldStartDisplay";
            this.lblOldStart.Visible = false;
            // 
            // pnlNewCatagory
            // 
            this.pnlNewCatagory.Controls.Add(this.label1);
            this.pnlNewCatagory.Controls.Add(this.btnColorSelect);
            this.pnlNewCatagory.Controls.Add(this.txtNewActivityName);
            this.pnlNewCatagory.Location = new System.Drawing.Point(17, 88);
            this.pnlNewCatagory.Name = "pnlNewCatagory";
            this.pnlNewCatagory.Size = new System.Drawing.Size(280, 181);
            this.pnlNewCatagory.TabIndex = 24;
            this.pnlNewCatagory.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 25;
            this.label1.Text = "Activity Name";
            // 
            // btnColorSelect
            // 
            this.btnColorSelect.Location = new System.Drawing.Point(33, 116);
            this.btnColorSelect.Name = "btnColorSelect";
            this.btnColorSelect.Size = new System.Drawing.Size(128, 23);
            this.btnColorSelect.TabIndex = 24;
            this.btnColorSelect.Text = "Choose Color";
            this.btnColorSelect.UseVisualStyleBackColor = true;
            this.btnColorSelect.Click += new System.EventHandler(this.btnColorSelect_Click);
            // 
            // txtNewActivityName
            // 
            this.txtNewActivityName.Location = new System.Drawing.Point(33, 76);
            this.txtNewActivityName.Name = "txtNewActivityName";
            this.txtNewActivityName.Size = new System.Drawing.Size(128, 23);
            this.txtNewActivityName.TabIndex = 23;
            // 
            // pnlLbx
            // 
            this.pnlLbx.Controls.Add(this.lbxAllActivities);
            this.pnlLbx.Location = new System.Drawing.Point(26, 59);
            this.pnlLbx.Name = "pnlLbx";
            this.pnlLbx.Size = new System.Drawing.Size(214, 152);
            this.pnlLbx.TabIndex = 25;
            // 
            // btnRecordPastEvent
            // 
            this.btnRecordPastEvent.Location = new System.Drawing.Point(14, 289);
            this.btnRecordPastEvent.Name = "btnRecordPastEvent";
            this.btnRecordPastEvent.Size = new System.Drawing.Size(281, 52);
            this.btnRecordPastEvent.TabIndex = 8;
            this.btnRecordPastEvent.Text = "Save Activity";
            this.btnRecordPastEvent.UseVisualStyleBackColor = true;
            this.btnRecordPastEvent.Visible = false;
            this.btnRecordPastEvent.Click += new System.EventHandler(this.btnRecordPastEvent_Click);
            // 
            // btnCreateNewType
            // 
            this.btnCreateNewType.Location = new System.Drawing.Point(17, 289);
            this.btnCreateNewType.Name = "btnCreateNewType";
            this.btnCreateNewType.Size = new System.Drawing.Size(281, 52);
            this.btnCreateNewType.TabIndex = 22;
            this.btnCreateNewType.Text = "Create New Catagory";
            this.btnCreateNewType.UseVisualStyleBackColor = true;
            this.btnCreateNewType.Visible = false;
            this.btnCreateNewType.Click += new System.EventHandler(this.btnCreateNewType_Click);
            // 
            // colorDialog1
            // 
            this.colorDialog1.AnyColor = true;
            // 
            // frmCurrentActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 431);
            this.Controls.Add(this.pnlLbx);
            this.Controls.Add(this.pnlNewCatagory);
            this.Controls.Add(this.pnlPassedEvent);
            this.Controls.Add(this.btnRecordPastEvent);
            this.Controls.Add(this.btnCreateNewType);
            this.Controls.Add(this.btnStartCurrent);
            this.Controls.Add(this.btnStopCurrentActivity);
            this.Controls.Add(this.pnlCurrentEvent);
            this.Controls.Add(this.gbModeSelect);
            this.Controls.Add(this.btnDone);
            this.Name = "frmCurrentActivity";
            this.Text = "frmCurrentActivity";
            this.Load += new System.EventHandler(this.frmCurrentActivity_Load);
            this.gbModeSelect.ResumeLayout(false);
            this.gbModeSelect.PerformLayout();
            this.pnlCurrentEvent.ResumeLayout(false);
            this.pnlCurrentEvent.PerformLayout();
            this.pnlPassedEvent.ResumeLayout(false);
            this.pnlPassedEvent.PerformLayout();
            this.pnlNewCatagory.ResumeLayout(false);
            this.pnlNewCatagory.PerformLayout();
            this.pnlLbx.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Label lblActivityDisplay;
        private Label lblStartLabel;
        private Label lblCurrentEventStart;
        private Label lblCurrentDuration;
        private Button btnStartCurrent;
        private Button btnStopCurrentActivity;
        private ListBox lbxAllActivities;
        private System.Windows.Forms.Timer timer1;
        private Button btnDone;
        private GroupBox gbModeSelect;
        private RadioButton rdoNewCatagory;
        private RadioButton rdoCurrentEvent;
        private RadioButton rdoPastEvent;
        private Panel pnlCurrentEvent;
        private Panel pnlPassedEvent;
        private Label lblOldStart;
        private DateTimePicker dtpPastEventStart;
        private Label lblOldEnd;
        private DateTimePicker dtpPastEventEnd;
        private Button btnRecordPastEvent;
        private Button btnCreateNewType;
        private TextBox txtNewActivityName;
        private Panel pnlNewCatagory;
        private ColorDialog colorDialog1;
        private Button btnColorSelect;
        private Panel pnlLbx;
        private Label label1;
        private Button btnCancelPastEvent;
        private Label lblPastEventDisplay;
        private Button btnMinusFive;
        private Button btnAddFive;
        private Button btnCancelCurrent;
    }
}