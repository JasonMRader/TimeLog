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
    public partial class frmCurrentActivity : Form
    {
        List<Activity> activities = new List<Activity>();
        Activity activity = new Activity();
        public frmCurrentActivity(Activity a)
        {
            InitializeComponent();
            activity = a;
        }


        private void PopulateCurrentFlow(List<Activity> list)
        {
            flowCurrentSelection.Controls.Clear();
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
                btn.Font = new Font("Arial", 10, FontStyle.Regular);
                btn.Click += new EventHandler(CurrentEventBtn_Click);
                flowCurrentSelection.Controls.Add(btn);


            }


        }

        private void CurrentEventBtn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            activity = Activity.GetActivity(btn.Text);

            StartCurrentActivity();
            
            
            //lblActivityDisplay.Text = btnStartCurrent.Tag.ToString();
        }
        private void StartCurrentActivity()
        {
            activities = Activity.GetActivityList();


            //PopulateCurrentFlow(activities);
            pnlCurrentEvent.Visible = true;
            lblCurrentEventStart.Text = DateTime.Now.ToString("hh:mm:ss tt");
            lblActivityDisplay.Visible = true;
            lblActivityDisplay.Text = activity.Name;
            //lblActivityDisplay.Text = btnStartCurrent.Tag.ToString();
            lblCurrentDuration.Visible = true;
            lblStartLabel.Visible = true;
            lblCurrentEventStart.Visible = true;
            //btnStartCurrent.Visible = false;
            btnStopCurrentActivity.Visible = true;
            this.BackColor = activity.Color;
            this.ForeColor = activity.TextColor;
            //flowCurrentSelection.Visible = false;
            timer1.Enabled = true;
            flowCurrentSelection.Visible = false;
        }

        private void frmCurrentActivity_Load(object sender, EventArgs e)
        {
            StartCurrentActivity();
            //activities = Activity.GetActivityList();
            
            
            ////PopulateCurrentFlow(activities);
            //pnlCurrentEvent.Visible = true;
            //lblCurrentEventStart.Text = DateTime.Now.ToString("hh:mm:ss tt");
            //lblActivityDisplay.Visible = true;
            //lblActivityDisplay.Text = activity.Name;
            ////lblActivityDisplay.Text = btnStartCurrent.Tag.ToString();
            //lblCurrentDuration.Visible = true;
            //lblStartLabel.Visible = true;
            //lblCurrentEventStart.Visible = true;
            ////btnStartCurrent.Visible = false;
            //btnStopCurrentActivity.Visible = true;
            //this.BackColor = activity.Color;
            //this.ForeColor = activity.TextColor;
            ////flowCurrentSelection.Visible = false;
            //timer1.Enabled = true;

        }


        private void btnStartCurrent_Click(object sender, EventArgs e)
        {
            pnlCurrentEvent.Visible = true;
            lblCurrentEventStart.Text = DateTime.Now.ToString("hh:mm:ss tt");
            lblActivityDisplay.Visible = true;
            //lblActivityDisplay.Text = btnStartCurrent.Tag.ToString();
            lblCurrentDuration.Visible = true;
            lblStartLabel.Visible = true;
            lblCurrentEventStart.Visible = true;
            
           
            //btnStartCurrent.Visible = false;
            btnStopCurrentActivity.Visible = true;
            //gbModeSelect.Visible = false;
            //Color color = Activity.GetActivityColor(btnStartCurrent.Tag.ToString());
            this.BackColor = activity.Color;
            //flowCurrentSelection.Visible = false;




            timer1.Enabled = true;
        }

        private void btnStopCurrentActivity_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            //gbModeSelect.Visible=true;

            activities = Activity.GetActivityList();
            foreach (Activity activity in activities.Where(x => x.Name == activity.Name))
            {
                activity.AddPastEvent(activity.Name, DateTime.Parse(lblCurrentEventStart.Text), DateTime.Now);

            }
            Activity.SaveActivityList(activities);
            
            
            pnlCurrentEvent.Visible = false;
            btnStopCurrentActivity.Visible=false;
            //btnStartCurrent.Visible = true;
            this.Close();

            Form frm = Application.OpenForms["Form1"]; //it should works
            frm.Show();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan duration = DateTime.Now - DateTime.Parse(lblCurrentEventStart.Text);
            lblCurrentDuration.Text = duration.ToString("hh':'mm':'ss");
             
            
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            this.Close();

            Form frm = Application.OpenForms["Form1"]; //it should works
            frm.Show();          

        }
      
        private void btnAddFive_Click(object sender, EventArgs e)
        {
            lblCurrentEventStart.Text = DateTime.Parse(lblCurrentEventStart.Text).AddMinutes(5).ToString("hh:mm:ss tt");
        }
        private void btnMinusFive_Click(object sender, EventArgs e)
        {
            lblCurrentEventStart.Text = DateTime.Parse(lblCurrentEventStart.Text).AddMinutes(-5).ToString("hh:mm:ss tt");
        }

        private void btnCancelCurrent_Click(object sender, EventArgs e)
        {
            pnlCurrentEvent.Visible = false ;
            btnStopCurrentActivity.Visible = false;
            timer1.Stop();
            this.Close();

            Form frm = Application.OpenForms["Form1"]; //it should works
            frm.Show();
            //lbxAllActivities.Visible=true;

            //gbModeSelect.Visible=true ;
            //btnStartCurrent.Visible = false;
        }

        
        private void btnFocusMode_Click(object sender, EventArgs e)
        {
            FocusedMode();
        }
        private void FocusedMode()
        {
            Panel panel = new Panel();
            panel = pnlCurrentEvent;
            panel.Size = new Size(1050, 125);
            panel.Location = new Point(0, 0);
            this.Controls.Add(panel);
            lblStartLabel.Visible = false;
            
            lblCurrentEventStart.Font = new Font("Arial", 16, FontStyle.Bold);
            btnAddFive.Visible = false;
            btnMinusFive.Visible = false;
            lblActivityDisplay.Location = new Point(10, 10);
            btnStopCurrentActivity.Location = new Point(850, 15);
            lblCurrentEventStart.Location = new Point(75, 10);
            lblCurrentDuration.Location = new Point(375, 10);
            lblActivityDisplay.Font = new Font("Arial", 16, FontStyle.Bold);

            this.Size = new Size(1050, 125);
            //this.ControlBox = false;
            
            
            lblCurrentDuration.Font = new Font("Arial", 40, FontStyle.Bold);

            //Label lblFocusStart = new Label();
            //lblFocusStart.Text = DateTime.Now.ToString("hh:mm:ss tt");
            //lblFocusStart.Location = new Point(10,10);
            //this.Controls.Add(lblFocusStart);
            //Label lbl = new Label();
            //lbl.Text = lblActivityDisplay.Text + "  " + lblCurrentDuration.Text;
            //lbl.Location = new Point(450, 10);
            //lbl.AutoSize = true;
            //lbl.Font = new Font("Arial", 25, FontStyle.Bold);
            //timer1.Enabled = true;
            //this.Controls.Add(lbl);
        }

        private void btnStartAnother_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            //gbModeSelect.Visible=true;

            activities = Activity.GetActivityList();
            foreach (Activity activity in activities.Where(x => x.Name == activity.Name))
            {
                activity.AddPastEvent(activity.Name, DateTime.Parse(lblCurrentEventStart.Text), DateTime.Now);

            }
            Activity.SaveActivityList(activities);
            
            PopulateCurrentFlow(activities);
            flowCurrentSelection.Visible = true;
        }
    }
}

