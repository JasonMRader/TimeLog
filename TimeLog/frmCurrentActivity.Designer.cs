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
            this.btnStopCurrentActivity = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlCurrentEvent = new System.Windows.Forms.Panel();
            this.btnCancelCurrent = new System.Windows.Forms.Button();
            this.btnMinusFive = new System.Windows.Forms.Button();
            this.btnAddFive = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnStartAnother = new System.Windows.Forms.Button();
            this.flowCurrentSelection = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlCurrentEvent.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblActivityDisplay
            // 
            this.lblActivityDisplay.AutoSize = true;
            this.lblActivityDisplay.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblActivityDisplay.Location = new System.Drawing.Point(3, 3);
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
            this.lblCurrentDuration.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCurrentDuration.Location = new System.Drawing.Point(17, 66);
            this.lblCurrentDuration.Name = "lblCurrentDuration";
            this.lblCurrentDuration.Size = new System.Drawing.Size(60, 47);
            this.lblCurrentDuration.TabIndex = 14;
            this.lblCurrentDuration.Text = "00";
            this.lblCurrentDuration.Visible = false;
            // 
            // btnStopCurrentActivity
            // 
            this.btnStopCurrentActivity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStopCurrentActivity.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnStopCurrentActivity.Location = new System.Drawing.Point(12, 151);
            this.btnStopCurrentActivity.Name = "btnStopCurrentActivity";
            this.btnStopCurrentActivity.Size = new System.Drawing.Size(300, 47);
            this.btnStopCurrentActivity.TabIndex = 16;
            this.btnStopCurrentActivity.Text = "Stop!";
            this.btnStopCurrentActivity.UseVisualStyleBackColor = true;
            this.btnStopCurrentActivity.Visible = false;
            this.btnStopCurrentActivity.Click += new System.EventHandler(this.btnStopCurrentActivity_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pnlCurrentEvent
            // 
            this.pnlCurrentEvent.Controls.Add(this.lblCurrentDuration);
            this.pnlCurrentEvent.Controls.Add(this.btnCancelCurrent);
            this.pnlCurrentEvent.Controls.Add(this.lblActivityDisplay);
            this.pnlCurrentEvent.Controls.Add(this.btnMinusFive);
            this.pnlCurrentEvent.Controls.Add(this.btnAddFive);
            this.pnlCurrentEvent.Controls.Add(this.lblStartLabel);
            this.pnlCurrentEvent.Controls.Add(this.lblCurrentEventStart);
            this.pnlCurrentEvent.Location = new System.Drawing.Point(12, 22);
            this.pnlCurrentEvent.Name = "pnlCurrentEvent";
            this.pnlCurrentEvent.Size = new System.Drawing.Size(303, 123);
            this.pnlCurrentEvent.TabIndex = 20;
            this.pnlCurrentEvent.Visible = false;
            // 
            // btnCancelCurrent
            // 
            this.btnCancelCurrent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelCurrent.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancelCurrent.Location = new System.Drawing.Point(208, 85);
            this.btnCancelCurrent.Name = "btnCancelCurrent";
            this.btnCancelCurrent.Size = new System.Drawing.Size(92, 35);
            this.btnCancelCurrent.TabIndex = 28;
            this.btnCancelCurrent.Text = "Cancel";
            this.btnCancelCurrent.UseVisualStyleBackColor = true;
            this.btnCancelCurrent.Click += new System.EventHandler(this.btnCancelCurrent_Click);
            // 
            // btnMinusFive
            // 
            this.btnMinusFive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinusFive.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMinusFive.Location = new System.Drawing.Point(220, 41);
            this.btnMinusFive.Name = "btnMinusFive";
            this.btnMinusFive.Size = new System.Drawing.Size(51, 38);
            this.btnMinusFive.TabIndex = 27;
            this.btnMinusFive.Text = "-5";
            this.btnMinusFive.UseVisualStyleBackColor = true;
            this.btnMinusFive.Click += new System.EventHandler(this.btnMinusFive_Click);
            // 
            // btnAddFive
            // 
            this.btnAddFive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddFive.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddFive.Location = new System.Drawing.Point(220, 3);
            this.btnAddFive.Name = "btnAddFive";
            this.btnAddFive.Size = new System.Drawing.Size(51, 38);
            this.btnAddFive.TabIndex = 26;
            this.btnAddFive.Text = "+5";
            this.btnAddFive.UseVisualStyleBackColor = true;
            this.btnAddFive.Click += new System.EventHandler(this.btnAddFive_Click);
            // 
            // colorDialog1
            // 
            this.colorDialog1.AnyColor = true;
            // 
            // btnStartAnother
            // 
            this.btnStartAnother.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartAnother.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnStartAnother.Location = new System.Drawing.Point(12, 204);
            this.btnStartAnother.Name = "btnStartAnother";
            this.btnStartAnother.Size = new System.Drawing.Size(300, 46);
            this.btnStartAnother.TabIndex = 21;
            this.btnStartAnother.Text = "Finish and Start New";
            this.btnStartAnother.UseVisualStyleBackColor = true;
            this.btnStartAnother.Click += new System.EventHandler(this.btnStartAnother_Click);
            // 
            // flowCurrentSelection
            // 
            this.flowCurrentSelection.Location = new System.Drawing.Point(5, 12);
            this.flowCurrentSelection.Name = "flowCurrentSelection";
            this.flowCurrentSelection.Size = new System.Drawing.Size(310, 238);
            this.flowCurrentSelection.TabIndex = 22;
            this.flowCurrentSelection.Visible = false;
            // 
            // frmCurrentActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 262);
            this.Controls.Add(this.flowCurrentSelection);
            this.Controls.Add(this.btnStartAnother);
            this.Controls.Add(this.btnStopCurrentActivity);
            this.Controls.Add(this.pnlCurrentEvent);
            this.Name = "frmCurrentActivity";
            this.Text = "Events and Activities";
            this.Load += new System.EventHandler(this.frmCurrentActivity_Load);
            this.pnlCurrentEvent.ResumeLayout(false);
            this.pnlCurrentEvent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label lblActivityDisplay;
        private Label lblStartLabel;
        private Label lblCurrentEventStart;
        private Label lblCurrentDuration;
        private Button btnStopCurrentActivity;
        private System.Windows.Forms.Timer timer1;
        private Panel pnlCurrentEvent;
        private ColorDialog colorDialog1;
        private Button btnMinusFive;
        private Button btnAddFive;
        private Button btnCancelCurrent;
        private Button btnStartAnother;
        private FlowLayoutPanel flowCurrentSelection;
    }
}