namespace TimeLog
{
    partial class frmAddPastEvent
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
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.btnStartMinusHour = new System.Windows.Forms.Button();
            this.btnStartMinus15Min = new System.Windows.Forms.Button();
            this.btnStartMinus5Min = new System.Windows.Forms.Button();
            this.btnStartAddHour = new System.Windows.Forms.Button();
            this.btnStartAdd15Min = new System.Windows.Forms.Button();
            this.btnStartAdd5Min = new System.Windows.Forms.Button();
            this.btnEndMinusHour = new System.Windows.Forms.Button();
            this.btnEndMinus15Min = new System.Windows.Forms.Button();
            this.btnEndAddHour = new System.Windows.Forms.Button();
            this.btnEndAdd15Min = new System.Windows.Forms.Button();
            this.btnEndMinus5Min = new System.Windows.Forms.Button();
            this.btnEndAdd5Min = new System.Windows.Forms.Button();
            this.lblStartDisplay = new System.Windows.Forms.Label();
            this.lblEndDisplay = new System.Windows.Forms.Label();
            this.btnAddEvent = new System.Windows.Forms.Button();
            this.lblEventDisplay = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnPreviousDay = new System.Windows.Forms.Button();
            this.btnNextDay = new System.Windows.Forms.Button();
            this.flowEvents = new System.Windows.Forms.FlowLayoutPanel();
            this.btnDeleteEvents = new System.Windows.Forms.Button();
            this.flowActDisplay = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTimeFrame = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.rdoWeek = new System.Windows.Forms.RadioButton();
            this.rdoDay = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpStart
            // 
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpStart.Location = new System.Drawing.Point(78, 110);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(111, 23);
            this.dtpStart.TabIndex = 0;
            this.dtpStart.ValueChanged += new System.EventHandler(this.dtpStart_ValueChanged);
            // 
            // dtpEnd
            // 
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpEnd.Location = new System.Drawing.Point(78, 247);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(111, 23);
            this.dtpEnd.TabIndex = 0;
            this.dtpEnd.ValueChanged += new System.EventHandler(this.dtpEnd_ValueChanged);
            // 
            // btnStartMinusHour
            // 
            this.btnStartMinusHour.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnStartMinusHour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartMinusHour.Location = new System.Drawing.Point(91, 141);
            this.btnStartMinusHour.Name = "btnStartMinusHour";
            this.btnStartMinusHour.Size = new System.Drawing.Size(25, 25);
            this.btnStartMinusHour.TabIndex = 1;
            this.btnStartMinusHour.Text = "-";
            this.btnStartMinusHour.UseVisualStyleBackColor = true;
            this.btnStartMinusHour.Click += new System.EventHandler(this.btnStartMinusHour_Click);
            // 
            // btnStartMinus15Min
            // 
            this.btnStartMinus15Min.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnStartMinus15Min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartMinus15Min.Location = new System.Drawing.Point(91, 166);
            this.btnStartMinus15Min.Name = "btnStartMinus15Min";
            this.btnStartMinus15Min.Size = new System.Drawing.Size(25, 25);
            this.btnStartMinus15Min.TabIndex = 1;
            this.btnStartMinus15Min.Text = "-";
            this.btnStartMinus15Min.UseVisualStyleBackColor = true;
            this.btnStartMinus15Min.Click += new System.EventHandler(this.btnStartMinus15Min_Click);
            // 
            // btnStartMinus5Min
            // 
            this.btnStartMinus5Min.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnStartMinus5Min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartMinus5Min.Location = new System.Drawing.Point(91, 188);
            this.btnStartMinus5Min.Name = "btnStartMinus5Min";
            this.btnStartMinus5Min.Size = new System.Drawing.Size(25, 25);
            this.btnStartMinus5Min.TabIndex = 1;
            this.btnStartMinus5Min.Text = "-";
            this.btnStartMinus5Min.UseVisualStyleBackColor = true;
            this.btnStartMinus5Min.Click += new System.EventHandler(this.btnStartMinus5Min_Click);
            // 
            // btnStartAddHour
            // 
            this.btnStartAddHour.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnStartAddHour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartAddHour.Location = new System.Drawing.Point(152, 141);
            this.btnStartAddHour.Name = "btnStartAddHour";
            this.btnStartAddHour.Size = new System.Drawing.Size(25, 25);
            this.btnStartAddHour.TabIndex = 1;
            this.btnStartAddHour.Text = "+";
            this.btnStartAddHour.UseVisualStyleBackColor = true;
            this.btnStartAddHour.Click += new System.EventHandler(this.btnStartAddHour_Click);
            // 
            // btnStartAdd15Min
            // 
            this.btnStartAdd15Min.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnStartAdd15Min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartAdd15Min.Location = new System.Drawing.Point(152, 166);
            this.btnStartAdd15Min.Name = "btnStartAdd15Min";
            this.btnStartAdd15Min.Size = new System.Drawing.Size(25, 25);
            this.btnStartAdd15Min.TabIndex = 1;
            this.btnStartAdd15Min.Text = "+";
            this.btnStartAdd15Min.UseVisualStyleBackColor = true;
            this.btnStartAdd15Min.Click += new System.EventHandler(this.btnStartAdd15Min_Click);
            // 
            // btnStartAdd5Min
            // 
            this.btnStartAdd5Min.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnStartAdd5Min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartAdd5Min.Location = new System.Drawing.Point(152, 188);
            this.btnStartAdd5Min.Name = "btnStartAdd5Min";
            this.btnStartAdd5Min.Size = new System.Drawing.Size(25, 25);
            this.btnStartAdd5Min.TabIndex = 1;
            this.btnStartAdd5Min.Text = "+";
            this.btnStartAdd5Min.UseVisualStyleBackColor = true;
            this.btnStartAdd5Min.Click += new System.EventHandler(this.btnStartAdd5Min_Click);
            // 
            // btnEndMinusHour
            // 
            this.btnEndMinusHour.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEndMinusHour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEndMinusHour.Location = new System.Drawing.Point(91, 285);
            this.btnEndMinusHour.Name = "btnEndMinusHour";
            this.btnEndMinusHour.Size = new System.Drawing.Size(25, 25);
            this.btnEndMinusHour.TabIndex = 1;
            this.btnEndMinusHour.Text = "-";
            this.btnEndMinusHour.UseVisualStyleBackColor = true;
            this.btnEndMinusHour.Click += new System.EventHandler(this.btnEndMinusHour_Click);
            // 
            // btnEndMinus15Min
            // 
            this.btnEndMinus15Min.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEndMinus15Min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEndMinus15Min.Location = new System.Drawing.Point(91, 308);
            this.btnEndMinus15Min.Name = "btnEndMinus15Min";
            this.btnEndMinus15Min.Size = new System.Drawing.Size(25, 25);
            this.btnEndMinus15Min.TabIndex = 1;
            this.btnEndMinus15Min.Text = "-";
            this.btnEndMinus15Min.UseVisualStyleBackColor = true;
            this.btnEndMinus15Min.Click += new System.EventHandler(this.btnEndMinus15Min_Click);
            // 
            // btnEndAddHour
            // 
            this.btnEndAddHour.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEndAddHour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEndAddHour.Location = new System.Drawing.Point(152, 285);
            this.btnEndAddHour.Name = "btnEndAddHour";
            this.btnEndAddHour.Size = new System.Drawing.Size(25, 25);
            this.btnEndAddHour.TabIndex = 1;
            this.btnEndAddHour.Text = "+";
            this.btnEndAddHour.UseVisualStyleBackColor = true;
            this.btnEndAddHour.Click += new System.EventHandler(this.btnEndAddHour_Click);
            // 
            // btnEndAdd15Min
            // 
            this.btnEndAdd15Min.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEndAdd15Min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEndAdd15Min.Location = new System.Drawing.Point(152, 306);
            this.btnEndAdd15Min.Name = "btnEndAdd15Min";
            this.btnEndAdd15Min.Size = new System.Drawing.Size(25, 25);
            this.btnEndAdd15Min.TabIndex = 1;
            this.btnEndAdd15Min.Text = "+";
            this.btnEndAdd15Min.UseVisualStyleBackColor = true;
            this.btnEndAdd15Min.Click += new System.EventHandler(this.btnEndAdd15Min_Click);
            // 
            // btnEndMinus5Min
            // 
            this.btnEndMinus5Min.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEndMinus5Min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEndMinus5Min.Location = new System.Drawing.Point(91, 339);
            this.btnEndMinus5Min.Name = "btnEndMinus5Min";
            this.btnEndMinus5Min.Size = new System.Drawing.Size(25, 25);
            this.btnEndMinus5Min.TabIndex = 1;
            this.btnEndMinus5Min.Text = "-";
            this.btnEndMinus5Min.UseVisualStyleBackColor = true;
            this.btnEndMinus5Min.Click += new System.EventHandler(this.btnEndMinus5Min_Click);
            // 
            // btnEndAdd5Min
            // 
            this.btnEndAdd5Min.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEndAdd5Min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEndAdd5Min.Location = new System.Drawing.Point(152, 339);
            this.btnEndAdd5Min.Name = "btnEndAdd5Min";
            this.btnEndAdd5Min.Size = new System.Drawing.Size(25, 25);
            this.btnEndAdd5Min.TabIndex = 1;
            this.btnEndAdd5Min.Text = "+";
            this.btnEndAdd5Min.UseVisualStyleBackColor = true;
            this.btnEndAdd5Min.Click += new System.EventHandler(this.btnEndAdd5Min_Click);
            // 
            // lblStartDisplay
            // 
            this.lblStartDisplay.AutoSize = true;
            this.lblStartDisplay.Location = new System.Drawing.Point(78, 92);
            this.lblStartDisplay.Name = "lblStartDisplay";
            this.lblStartDisplay.Size = new System.Drawing.Size(38, 15);
            this.lblStartDisplay.TabIndex = 2;
            this.lblStartDisplay.Text = "label1";
            // 
            // lblEndDisplay
            // 
            this.lblEndDisplay.AutoSize = true;
            this.lblEndDisplay.Location = new System.Drawing.Point(78, 229);
            this.lblEndDisplay.Name = "lblEndDisplay";
            this.lblEndDisplay.Size = new System.Drawing.Size(38, 15);
            this.lblEndDisplay.TabIndex = 2;
            this.lblEndDisplay.Text = "label1";
            // 
            // btnAddEvent
            // 
            this.btnAddEvent.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAddEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddEvent.Location = new System.Drawing.Point(31, 421);
            this.btnAddEvent.Name = "btnAddEvent";
            this.btnAddEvent.Size = new System.Drawing.Size(208, 53);
            this.btnAddEvent.TabIndex = 3;
            this.btnAddEvent.Text = "Add Event";
            this.btnAddEvent.UseVisualStyleBackColor = true;
            this.btnAddEvent.Click += new System.EventHandler(this.btnAddEvent_Click);
            // 
            // lblEventDisplay
            // 
            this.lblEventDisplay.AutoSize = true;
            this.lblEventDisplay.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEventDisplay.Location = new System.Drawing.Point(156, 50);
            this.lblEventDisplay.Name = "lblEventDisplay";
            this.lblEventDisplay.Size = new System.Drawing.Size(83, 32);
            this.lblEventDisplay.TabIndex = 4;
            this.lblEventDisplay.Text = "label1";
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDuration.Location = new System.Drawing.Point(88, 373);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(28, 32);
            this.lblDuration.TabIndex = 5;
            this.lblDuration.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "1hr";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "15m";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(122, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "5m";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(122, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "1hr";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(122, 313);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "15m";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(122, 344);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "5m";
            // 
            // btnPreviousDay
            // 
            this.btnPreviousDay.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPreviousDay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreviousDay.Location = new System.Drawing.Point(34, 110);
            this.btnPreviousDay.Name = "btnPreviousDay";
            this.btnPreviousDay.Size = new System.Drawing.Size(38, 23);
            this.btnPreviousDay.TabIndex = 9;
            this.btnPreviousDay.Text = "<";
            this.btnPreviousDay.UseVisualStyleBackColor = true;
            this.btnPreviousDay.Click += new System.EventHandler(this.btnPreviousDay_Click);
            // 
            // btnNextDay
            // 
            this.btnNextDay.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnNextDay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextDay.Location = new System.Drawing.Point(194, 110);
            this.btnNextDay.Name = "btnNextDay";
            this.btnNextDay.Size = new System.Drawing.Size(38, 23);
            this.btnNextDay.TabIndex = 9;
            this.btnNextDay.Text = ">";
            this.btnNextDay.UseVisualStyleBackColor = true;
            this.btnNextDay.Click += new System.EventHandler(this.btnNextDay_Click);
            // 
            // flowEvents
            // 
            this.flowEvents.Location = new System.Drawing.Point(315, 147);
            this.flowEvents.Name = "flowEvents";
            this.flowEvents.Size = new System.Drawing.Size(275, 273);
            this.flowEvents.TabIndex = 10;
            // 
            // btnDeleteEvents
            // 
            this.btnDeleteEvents.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDeleteEvents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteEvents.Location = new System.Drawing.Point(315, 436);
            this.btnDeleteEvents.Name = "btnDeleteEvents";
            this.btnDeleteEvents.Size = new System.Drawing.Size(275, 23);
            this.btnDeleteEvents.TabIndex = 11;
            this.btnDeleteEvents.Text = "Delete Events";
            this.btnDeleteEvents.UseVisualStyleBackColor = true;
            this.btnDeleteEvents.Click += new System.EventHandler(this.btnDeleteEvents_Click);
            // 
            // flowActDisplay
            // 
            this.flowActDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowActDisplay.AutoSize = true;
            this.flowActDisplay.Location = new System.Drawing.Point(3, 0);
            this.flowActDisplay.Margin = new System.Windows.Forms.Padding(0);
            this.flowActDisplay.Name = "flowActDisplay";
            this.flowActDisplay.Size = new System.Drawing.Size(597, 50);
            this.flowActDisplay.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTimeFrame);
            this.groupBox1.Controls.Add(this.btnNext);
            this.groupBox1.Controls.Add(this.btnPrevious);
            this.groupBox1.Controls.Add(this.rdoWeek);
            this.groupBox1.Controls.Add(this.rdoDay);
            this.groupBox1.Location = new System.Drawing.Point(315, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 80);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Time Frame";
            // 
            // lblTimeFrame
            // 
            this.lblTimeFrame.AutoSize = true;
            this.lblTimeFrame.Location = new System.Drawing.Point(92, 51);
            this.lblTimeFrame.Name = "lblTimeFrame";
            this.lblTimeFrame.Size = new System.Drawing.Size(71, 15);
            this.lblTimeFrame.TabIndex = 3;
            this.lblTimeFrame.Text = "TimeDisplay";
            // 
            // btnNext
            // 
            this.btnNext.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Location = new System.Drawing.Point(181, 47);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(45, 23);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.Location = new System.Drawing.Point(22, 47);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(47, 23);
            this.btnPrevious.TabIndex = 1;
            this.btnPrevious.Text = "<";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // rdoWeek
            // 
            this.rdoWeek.AutoSize = true;
            this.rdoWeek.Location = new System.Drawing.Point(161, 22);
            this.rdoWeek.Name = "rdoWeek";
            this.rdoWeek.Size = new System.Drawing.Size(54, 19);
            this.rdoWeek.TabIndex = 0;
            this.rdoWeek.Text = "Week";
            this.rdoWeek.UseVisualStyleBackColor = true;
            this.rdoWeek.CheckedChanged += new System.EventHandler(this.rdoWeek_CheckedChanged);
            // 
            // rdoDay
            // 
            this.rdoDay.AutoSize = true;
            this.rdoDay.Checked = true;
            this.rdoDay.Location = new System.Drawing.Point(63, 22);
            this.rdoDay.Name = "rdoDay";
            this.rdoDay.Size = new System.Drawing.Size(45, 19);
            this.rdoDay.TabIndex = 0;
            this.rdoDay.TabStop = true;
            this.rdoDay.Text = "Day";
            this.rdoDay.UseVisualStyleBackColor = true;
            this.rdoDay.CheckedChanged += new System.EventHandler(this.rdoDay_CheckedChanged);
            // 
            // frmAddPastEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 490);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.flowActDisplay);
            this.Controls.Add(this.btnDeleteEvents);
            this.Controls.Add(this.flowEvents);
            this.Controls.Add(this.btnNextDay);
            this.Controls.Add(this.btnPreviousDay);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDuration);
            this.Controls.Add(this.lblEventDisplay);
            this.Controls.Add(this.btnAddEvent);
            this.Controls.Add(this.lblEndDisplay);
            this.Controls.Add(this.lblStartDisplay);
            this.Controls.Add(this.btnEndAdd5Min);
            this.Controls.Add(this.btnStartAdd5Min);
            this.Controls.Add(this.btnEndMinus5Min);
            this.Controls.Add(this.btnStartMinus5Min);
            this.Controls.Add(this.btnEndAdd15Min);
            this.Controls.Add(this.btnStartAdd15Min);
            this.Controls.Add(this.btnEndAddHour);
            this.Controls.Add(this.btnStartAddHour);
            this.Controls.Add(this.btnEndMinus15Min);
            this.Controls.Add(this.btnStartMinus15Min);
            this.Controls.Add(this.btnEndMinusHour);
            this.Controls.Add(this.btnStartMinusHour);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.dtpStart);
            this.Name = "frmAddPastEvent";
            this.Text = "frmAddPastEvent";
            this.Load += new System.EventHandler(this.frmAddPastEvent_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DateTimePicker dtpStart;
        private DateTimePicker dtpEnd;
        private Button btnStartMinusHour;
        private Button btnStartMinus15Min;
        private Button btnStartMinus5Min;
        private Button btnStartAddHour;
        private Button btnStartAdd15Min;
        private Button btnStartAdd5Min;
        private Button btnEndMinusHour;
        private Button btnEndMinus15Min;
        private Button btnEndAddHour;
        private Button btnEndAdd15Min;
        private Button btnEndMinus5Min;
        private Button btnEndAdd5Min;
        private Label lblStartDisplay;
        private Label lblEndDisplay;
        private Button btnAddEvent;
        private Label lblEventDisplay;
        private Label lblDuration;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnPreviousDay;
        private Button btnNextDay;
        private FlowLayoutPanel flowEvents;
        private Button btnDeleteEvents;
        private FlowLayoutPanel flowActDisplay;
        private GroupBox groupBox1;
        private Label lblTimeFrame;
        private Button btnNext;
        private Button btnPrevious;
        private RadioButton rdoWeek;
        private RadioButton rdoDay;
    }
}