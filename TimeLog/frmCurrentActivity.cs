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
        public frmCurrentActivity()
        {
            InitializeComponent();
        }

        private void frmCurrentActivity_Load(object sender, EventArgs e)
        {
            activities = Activity.GetActivityList();
            foreach (Activity a in activities)
            {
                lbxAllActivities.Items.Add(a.Name);
            }
        }

        private void lbxAllActivities_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxAllActivities.SelectedIndex == -1)
            {
                btnStartCurrent.Enabled = false;
                btnStopCurrentActivity.Enabled = false;
                
            }
            if (lbxAllActivities.SelectedIndex >= 0)
            {
                if (rdoCurrentEvent.Checked)
                {
                    btnStartCurrent.Visible = true;
                    pnlCurrentEvent.Visible = true;
                    
                }
                if (rdoPastEvent.Checked)
                {
                    pnlPassedEvent.Visible = true;
                    lbxAllActivities.Visible = false;
                    pnlLbx.Visible = false;
                    lblPastEventDisplay.Text = lbxAllActivities.Text;
                    btnRecordPastEvent.Visible = true;
                }
                
                
            }
        }

        private void btnStartCurrent_Click(object sender, EventArgs e)
        {
            lblCurrentEventStart.Text = DateTime.Now.ToString("hh:mm:ss tt");
            lblActivityDisplay.Visible = true;
            lblActivityDisplay.Text = "You Are " + lbxAllActivities.Text;
            lblCurrentDuration.Visible = true;
            lblStartLabel.Visible = true;
            lblCurrentEventStart.Visible = true;
            lbxAllActivities.Visible = false;
            pnlLbx.Visible = false;
            btnStartCurrent.Visible = false;
            btnStopCurrentActivity.Visible = true;
            gbModeSelect.Visible = false;
            Color color = Activity.GetActivityColor(lbxAllActivities.Text);
            pnlCurrentEvent.BackColor = color;



            timer1.Enabled = true;
        }

        private void btnStopCurrentActivity_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            gbModeSelect.Visible=true;

            activities = Activity.GetActivityList();
            foreach (Activity activity in activities.Where(x => x.Name == lbxAllActivities.SelectedItem.ToString()))
            {
                activity.AddPastEvent(activity.Name, DateTime.Parse(lblCurrentEventStart.Text), DateTime.Now);

            }
            Activity.SaveActivityList(activities);
            lbxAllActivities.Visible = true;
            pnlLbx.Visible = true;
            pnlCurrentEvent.Visible = false;
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

        private void dtpPastEventStart_ValueChanged(object sender, EventArgs e)
        {
            lblOldStart.Visible = true;
            lblOldStart.Text = dtpPastEventStart.Value.ToString("dddd");
        }

        private void dtpPastEventEnd_ValueChanged(object sender, EventArgs e)
        {
            lblOldEnd.Visible = true;
            lblOldEnd.Text = dtpPastEventEnd.Value.ToString("dddd");
        }

        private void btnRecordPastEvent_Click(object sender, EventArgs e)
        {
            activities = Activity.GetActivityList();
            foreach (Activity a in activities.Where(x => x.Name == lbxAllActivities.Text))
            {
                a.AddPastEvent(a.Name, dtpPastEventStart.Value, dtpPastEventEnd.Value);
            }
            Activity.SaveActivityList(activities);
        }

        private void rdoNewCatagory_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoNewCatagory.Checked)
            {
                pnlCurrentEvent.Visible = false;
                pnlPassedEvent.Visible = false;
                lbxAllActivities.Visible = false;
                pnlLbx.Visible = false;
                pnlNewCatagory.Visible = true;
                btnCreateNewType.Visible = true;
                
            }
            if (!rdoNewCatagory.Checked)
            {
                pnlNewCatagory.Visible = false;
            }
        }

        private void btnCancelPastEvent_Click(object sender, EventArgs e)
        {
            pnlPassedEvent.Visible=false;
            lbxAllActivities.Visible=true;
            pnlLbx.Visible = true;
        }

        private void rdoCurrentEvent_CheckedChanged(object sender, EventArgs e)
        {
            
            if (rdoCurrentEvent.Checked)
            {
                lbxAllActivities.Visible = true;
                pnlLbx.Visible = true;
                pnlCurrentEvent.Visible = false;
                pnlPassedEvent.Visible = false;
                btnCreateNewType.Visible = false;
                btnRecordPastEvent.Visible = false;
                btnStartCurrent.Visible = false;
                btnStopCurrentActivity.Visible = false;
            }
        }

        private void rdoPastEvent_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoPastEvent.Checked)
            {
                lbxAllActivities.Visible = true;
                pnlLbx.Visible = true;
                pnlCurrentEvent.Visible=false;
                pnlPassedEvent.Visible = false;
                btnCreateNewType.Visible=false;
                btnRecordPastEvent.Visible = false;
                btnStartCurrent.Visible=false;
                btnStopCurrentActivity.Visible=false;
            }
            if (!rdoPastEvent.Checked)
            {
                btnRecordPastEvent.Visible=false;
            }

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
            lbxAllActivities.Visible=true;
            pnlLbx.Visible=true ;
            gbModeSelect.Visible=true ;
            btnStartCurrent.Visible = false;
        }

        private void btnColorSelect_Click(object sender, EventArgs e)
        {
            colorDialog1 = new ColorDialog();
            colorDialog1.ShowDialog();
            
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                
                pnlNewCatagory.BackColor = colorDialog1.Color;
                
            }
                
                
        }

        private void btnCreateNewType_Click(object sender, EventArgs e)
        {
            activities = Activity.GetActivityList();
            Activity a = new Activity();
            a.Name = txtNewActivityName.Text;
            a.Color = colorDialog1.Color;
            activities.Add(a);
            Activity.SaveActivityList(activities);
        }
    }
}
