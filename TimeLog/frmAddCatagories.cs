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
    public partial class frmAddCatagories : Form
    {
        public frmAddCatagories()
        {
            InitializeComponent();
        }

        private void frmAddCatagories_Load(object sender, EventArgs e)
        {
            List <Activity> activities = new List <Activity>(Activity.GetActivityList());
            PopulateButtons(activities);
        }

        private void PopulateButtons(List<Activity> list)
        {
            flowLayoutPanel1.Controls.Clear();
            foreach (Activity a in list)
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
                btn.Click += new EventHandler(Btn_Click);
                flowLayoutPanel1.Controls.Add(btn);

                //lbxFinishedEvent.Items.Add(a.Name);
            }
           

        }
        private void Btn_Click(object sender, EventArgs e)
        {
            
            Button btn = sender as Button;
            btnSelectedActivity.Text = btn.Text;
            btnEditSelection.Enabled = true;
            button2.Enabled = true;
            
            btnSelectedActivity.BackColor = btn.BackColor;
            
           
            if (btn.ForeColor == Color.White)
            {
                //cbWhiteText.Checked = true;
                btnSelectedActivity.ForeColor = Color.White;
            }
            else
            {
                //cbWhiteText.Checked = false;
                btnSelectedActivity.ForeColor = Color.Black;
            }
            
        }

        private void btnColorSelection_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog1 = new ColorDialog();
            colorDialog1.ShowDialog();
            btnNewCatagoryDisplay.BackColor = colorDialog1.Color;
            //if (colorDialog1.ShowDialog() == DialogResult.OK)
            //{

            //    btnNewCatagoryDisplay.BackColor = colorDialog1.Color;

            //}
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            btnNewCatagoryDisplay.Text = txtNewActivityName.Text;
        }

        private void cbWhiteText_CheckedChanged(object sender, EventArgs e)
        {
            if (cbWhiteText.Checked)
            {
                btnNewCatagoryDisplay.ForeColor = Color.White;
            }
            else
            {
                btnNewCatagoryDisplay.ForeColor = Color.Black;
            }
        }

        private void btnCreateNewCatagory_Click(object sender, EventArgs e)
        {

            List<Activity> activities = new List<Activity>(Activity.GetActivityList());
            Activity a = new Activity();
            string newActivityName = txtNewActivityName.Text;
            newActivityName = Thread.CurrentThread.CurrentCulture.
                TextInfo.ToTitleCase(newActivityName.ToLower());
            Color newColor = btnNewCatagoryDisplay.BackColor;
            int uniqueColorCheck = 0;
            int uniqueNameCheck = 0;
            foreach (Activity activity in activities.ToList())
            {
                var itemToAdd = activities.SingleOrDefault(x => x.Name == newActivityName);
                var colorToAdd = activities.SingleOrDefault(x => x.Color == newColor);
                if (itemToAdd == null && colorToAdd == null)
                {
                    
                }
                if (colorToAdd != null)
                {
                   uniqueColorCheck++;
                }
                if (itemToAdd != null)
                {
                    uniqueNameCheck++;
                }
            }
            if (uniqueColorCheck == 0 & uniqueNameCheck == 00)
            {
                a.Name = newActivityName;
                a.Color = btnNewCatagoryDisplay.BackColor;
                if (cbWhiteText.Checked)
                {
                    a.TextColorString = "white";
                }
                activities.Add(a);
                Activity.SaveActivityList(activities);
                txtNewActivityName.Clear();
                flowLayoutPanel1.Controls.Clear();
                PopulateButtons(activities);
                ResetForm();
            }
            if (uniqueColorCheck > 0)
            {
                MessageBox.Show("That Color is Taken!");
            }
            if (uniqueNameCheck >0 )
            {
                MessageBox.Show("That Activity Name is Taken!");
            }




            //btnCreateNewType.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            btnEditSelection.Enabled = false;
            lblConfirmDelete.Location = new Point(25, 65);
            btnColorSelection.Visible = false;
            cbWhiteText.Visible = false;
            lblConfirmDelete.Text = "Delete " + btnSelectedActivity.Text + "?";
            btnCancel.Visible = true;
            txtNewActivityName.ReadOnly = true;
            txtNewActivityName.Text = btnSelectedActivity.Text;
            btnNewCatagoryDisplay.BackColor = btnSelectedActivity.BackColor;
            btnNewCatagoryDisplay.Text = btnSelectedActivity.Text;
            if (btnSelectedActivity.ForeColor == Color.White)
            {
                cbWhiteText.Checked = true;
            }
            else
            {
                cbWhiteText.Checked = false;
            }
            btnSubmitEdit.Visible = false;
            btnCreateNewCatagory.Visible = false;
            btnConfirmDelete.Visible = true;
            gbConfirm.Visible = true;

            
            
        }

        private void btnEditSelection_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            btnEditSelection.Enabled = false;
            btnCancel.Visible = true;
            txtNewActivityName.ReadOnly = true;
            txtNewActivityName.Text = btnSelectedActivity.Text;
            btnNewCatagoryDisplay.BackColor = btnSelectedActivity.BackColor;
            btnNewCatagoryDisplay.Text = btnSelectedActivity.Text;
            if (btnSelectedActivity.ForeColor == Color.White)
            {
                cbWhiteText.Checked = true;
            }
            else
            {
                cbWhiteText.Checked = false;
            }
            btnSubmitEdit.Visible = true;
            btnCreateNewCatagory.Visible = false;
            btnConfirmDelete.Visible = false;
            gbConfirm.Visible = true;
        }

        private void rbYesDelete_CheckedChanged(object sender, EventArgs e)
        {
            if (rbYesDelete.Checked)
            {
                btnConfirmDelete.Enabled = true;
                btnSubmitEdit.Enabled = true;
            }
            if (!rbYesDelete.Checked)
            {
                btnConfirmDelete.Enabled = false;
                btnSubmitEdit.Enabled = false;
            }
        }

        private void btnSubmitEdit_Click(object sender, EventArgs e)
        {
            List<Activity> activities = new List<Activity>(Activity.GetActivityList());
            if (txtNewActivityName.Text == "")
            {
                MessageBox.Show("Please enter a name for the activity");
            }
            else
            {
                //activities = Activity.GetActivityList();
                foreach (Activity a in activities.Where(x => x.Name == txtNewActivityName.Text))
                {
                    a.Name = txtNewActivityName.Text;
                    a.Color = btnNewCatagoryDisplay.BackColor;
                    if (cbWhiteText.Checked)
                    {
                        a.TextColorString = "white";
                    }
                    if (!cbWhiteText.Checked)
                    {
                        a.TextColorString = "black";
                    }
                }
                Activity.SaveActivityList(activities);
                flowLayoutPanel1.Controls.Clear();
                PopulateButtons(activities);


            }
            ResetForm();

        }

        private void ResetForm()
        {
            btnCreateNewCatagory.Visible = true;
            gbConfirm.Visible = false;
            btnSubmitEdit.Visible = false;
            btnSubmitEdit.Enabled = false;
            cbWhiteText.Checked = false;
            btnNewCatagoryDisplay.BackColor = Color.White;
            btnNewCatagoryDisplay.Text = "";
            txtNewActivityName.ReadOnly = false;
            txtNewActivityName.Text = "";
            btnConfirmDelete.Visible = false;
            btnConfirmDelete.Enabled = false;
            btnSelectedActivity.BackColor = Color.White;
            btnSelectedActivity.Text = "Select A Catagory";
            btnCancel.Visible = false;
            button2.Enabled = false;
            btnEditSelection.Enabled = false;

            lblConfirmDelete.Location = new Point(25, 333);
            btnColorSelection.Visible = true;
            cbWhiteText.Visible = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void btnConfirmDelete_Click(object sender, EventArgs e)
        {
            List<Activity> activities = new List<Activity>(Activity.GetActivityList());



            foreach (Activity activity in activities.ToList())
            {
                var itemToRemove = activities.SingleOrDefault(x => x.Name == btnSelectedActivity.Text);
                if (itemToRemove != null)
                    activities.Remove(itemToRemove);


            }


            Activity.SaveActivityList(activities);
            PopulateButtons(activities); 
            ResetForm();

        }
        static string UppercaseFirst(string s)
        {
            // Check for empty string.
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }
            // Return char and concat substring.
            return char.ToUpper(s[0]) + s.Substring(1);
        }
    }
}

