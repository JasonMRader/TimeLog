namespace TimeLog
{
    partial class frmAddCatagories
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNewActivityName = new System.Windows.Forms.TextBox();
            this.btnColorSelection = new System.Windows.Forms.Button();
            this.btnNewCatagoryDisplay = new System.Windows.Forms.Button();
            this.cbWhiteText = new System.Windows.Forms.CheckBox();
            this.btnCreateNewCatagory = new System.Windows.Forms.Button();
            this.btnEditSelection = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnSelectedActivity = new System.Windows.Forms.Button();
            this.btnConfirmDelete = new System.Windows.Forms.Button();
            this.btnSubmitEdit = new System.Windows.Forms.Button();
            this.gbConfirm = new System.Windows.Forms.GroupBox();
            this.rbNoDelete = new System.Windows.Forms.RadioButton();
            this.rbYesDelete = new System.Windows.Forms.RadioButton();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblConfirmDelete = new System.Windows.Forms.Label();
            this.gbConfirm.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(336, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(339, 166);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Catagory Name";
            // 
            // txtNewActivityName
            // 
            this.txtNewActivityName.Location = new System.Drawing.Point(100, 30);
            this.txtNewActivityName.Name = "txtNewActivityName";
            this.txtNewActivityName.Size = new System.Drawing.Size(100, 23);
            this.txtNewActivityName.TabIndex = 2;
            this.txtNewActivityName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnColorSelection
            // 
            this.btnColorSelection.Location = new System.Drawing.Point(19, 85);
            this.btnColorSelection.Name = "btnColorSelection";
            this.btnColorSelection.Size = new System.Drawing.Size(181, 23);
            this.btnColorSelection.TabIndex = 3;
            this.btnColorSelection.Text = "Select Color";
            this.btnColorSelection.UseVisualStyleBackColor = true;
            this.btnColorSelection.Click += new System.EventHandler(this.btnColorSelection_Click);
            // 
            // btnNewCatagoryDisplay
            // 
            this.btnNewCatagoryDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewCatagoryDisplay.Location = new System.Drawing.Point(213, 30);
            this.btnNewCatagoryDisplay.Name = "btnNewCatagoryDisplay";
            this.btnNewCatagoryDisplay.Size = new System.Drawing.Size(86, 23);
            this.btnNewCatagoryDisplay.TabIndex = 4;
            this.btnNewCatagoryDisplay.UseVisualStyleBackColor = true;
            // 
            // cbWhiteText
            // 
            this.cbWhiteText.AutoSize = true;
            this.cbWhiteText.Location = new System.Drawing.Point(213, 89);
            this.cbWhiteText.Name = "cbWhiteText";
            this.cbWhiteText.Size = new System.Drawing.Size(86, 19);
            this.cbWhiteText.TabIndex = 5;
            this.cbWhiteText.Text = "White Text?";
            this.cbWhiteText.UseVisualStyleBackColor = true;
            this.cbWhiteText.CheckedChanged += new System.EventHandler(this.cbWhiteText_CheckedChanged);
            // 
            // btnCreateNewCatagory
            // 
            this.btnCreateNewCatagory.Location = new System.Drawing.Point(19, 163);
            this.btnCreateNewCatagory.Name = "btnCreateNewCatagory";
            this.btnCreateNewCatagory.Size = new System.Drawing.Size(280, 53);
            this.btnCreateNewCatagory.TabIndex = 6;
            this.btnCreateNewCatagory.Text = "Create New Catagory";
            this.btnCreateNewCatagory.UseVisualStyleBackColor = true;
            this.btnCreateNewCatagory.Click += new System.EventHandler(this.btnCreateNewCatagory_Click);
            // 
            // btnEditSelection
            // 
            this.btnEditSelection.Enabled = false;
            this.btnEditSelection.Location = new System.Drawing.Point(456, 184);
            this.btnEditSelection.Name = "btnEditSelection";
            this.btnEditSelection.Size = new System.Drawing.Size(107, 23);
            this.btnEditSelection.TabIndex = 7;
            this.btnEditSelection.Text = "Edit";
            this.btnEditSelection.UseVisualStyleBackColor = true;
            this.btnEditSelection.Click += new System.EventHandler(this.btnEditSelection_Click);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(569, 184);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSelectedActivity
            // 
            this.btnSelectedActivity.BackColor = System.Drawing.Color.White;
            this.btnSelectedActivity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectedActivity.Location = new System.Drawing.Point(336, 184);
            this.btnSelectedActivity.Name = "btnSelectedActivity";
            this.btnSelectedActivity.Size = new System.Drawing.Size(114, 32);
            this.btnSelectedActivity.TabIndex = 8;
            this.btnSelectedActivity.Text = "Select A Catagory";
            this.btnSelectedActivity.UseVisualStyleBackColor = false;
            // 
            // btnConfirmDelete
            // 
            this.btnConfirmDelete.Enabled = false;
            this.btnConfirmDelete.Location = new System.Drawing.Point(19, 163);
            this.btnConfirmDelete.Name = "btnConfirmDelete";
            this.btnConfirmDelete.Size = new System.Drawing.Size(175, 53);
            this.btnConfirmDelete.TabIndex = 9;
            this.btnConfirmDelete.Text = "Delete";
            this.btnConfirmDelete.UseVisualStyleBackColor = true;
            this.btnConfirmDelete.Visible = false;
            this.btnConfirmDelete.Click += new System.EventHandler(this.btnConfirmDelete_Click);
            // 
            // btnSubmitEdit
            // 
            this.btnSubmitEdit.Enabled = false;
            this.btnSubmitEdit.Location = new System.Drawing.Point(19, 163);
            this.btnSubmitEdit.Name = "btnSubmitEdit";
            this.btnSubmitEdit.Size = new System.Drawing.Size(175, 53);
            this.btnSubmitEdit.TabIndex = 10;
            this.btnSubmitEdit.Text = "Submit Edit";
            this.btnSubmitEdit.UseVisualStyleBackColor = true;
            this.btnSubmitEdit.Visible = false;
            this.btnSubmitEdit.Click += new System.EventHandler(this.btnSubmitEdit_Click);
            // 
            // gbConfirm
            // 
            this.gbConfirm.Controls.Add(this.rbNoDelete);
            this.gbConfirm.Controls.Add(this.rbYesDelete);
            this.gbConfirm.Location = new System.Drawing.Point(19, 114);
            this.gbConfirm.Name = "gbConfirm";
            this.gbConfirm.Size = new System.Drawing.Size(106, 41);
            this.gbConfirm.TabIndex = 11;
            this.gbConfirm.TabStop = false;
            this.gbConfirm.Text = "Are You Sure?";
            this.gbConfirm.Visible = false;
            // 
            // rbNoDelete
            // 
            this.rbNoDelete.AutoSize = true;
            this.rbNoDelete.Checked = true;
            this.rbNoDelete.Location = new System.Drawing.Point(6, 16);
            this.rbNoDelete.Name = "rbNoDelete";
            this.rbNoDelete.Size = new System.Drawing.Size(41, 19);
            this.rbNoDelete.TabIndex = 12;
            this.rbNoDelete.TabStop = true;
            this.rbNoDelete.Text = "No";
            this.rbNoDelete.UseVisualStyleBackColor = true;
            // 
            // rbYesDelete
            // 
            this.rbYesDelete.AutoSize = true;
            this.rbYesDelete.Location = new System.Drawing.Point(53, 16);
            this.rbYesDelete.Name = "rbYesDelete";
            this.rbYesDelete.Size = new System.Drawing.Size(42, 19);
            this.rbYesDelete.TabIndex = 0;
            this.rbYesDelete.Text = "Yes";
            this.rbYesDelete.UseVisualStyleBackColor = true;
            this.rbYesDelete.CheckedChanged += new System.EventHandler(this.rbYesDelete_CheckedChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(200, 163);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(99, 53);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblConfirmDelete
            // 
            this.lblConfirmDelete.AutoSize = true;
            this.lblConfirmDelete.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblConfirmDelete.Location = new System.Drawing.Point(25, 233);
            this.lblConfirmDelete.Name = "lblConfirmDelete";
            this.lblConfirmDelete.Size = new System.Drawing.Size(118, 32);
            this.lblConfirmDelete.TabIndex = 13;
            this.lblConfirmDelete.Text = "Confirm?";
            this.lblConfirmDelete.Visible = false;
            // 
            // frmAddCatagories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 274);
            this.Controls.Add(this.lblConfirmDelete);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.gbConfirm);
            this.Controls.Add(this.btnSubmitEdit);
            this.Controls.Add(this.btnConfirmDelete);
            this.Controls.Add(this.btnSelectedActivity);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnEditSelection);
            this.Controls.Add(this.btnCreateNewCatagory);
            this.Controls.Add(this.cbWhiteText);
            this.Controls.Add(this.btnNewCatagoryDisplay);
            this.Controls.Add(this.btnColorSelection);
            this.Controls.Add(this.txtNewActivityName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "frmAddCatagories";
            this.Text = "frmAddCatagories";
            this.Load += new System.EventHandler(this.frmAddCatagories_Load);
            this.gbConfirm.ResumeLayout(false);
            this.gbConfirm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private TextBox txtNewActivityName;
        private Button btnColorSelection;
        private Button btnNewCatagoryDisplay;
        private CheckBox cbWhiteText;
        private Button btnCreateNewCatagory;
        private Button btnEditSelection;
        private Button button2;
        private Button btnSelectedActivity;
        private Button btnConfirmDelete;
        private Button btnSubmitEdit;
        private GroupBox gbConfirm;
        private RadioButton rbNoDelete;
        private RadioButton rbYesDelete;
        private Button btnCancel;
        private Label lblConfirmDelete;
    }
}