namespace TrackerUI
{
    partial class CreateTeamForm
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
            this.tbTeamName = new System.Windows.Forms.TextBox();
            this.lblTeamName = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.btnAddTeamMember = new System.Windows.Forms.Button();
            this.ddSelectTeamMember = new System.Windows.Forms.ComboBox();
            this.lblSelectTeamMember = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCreateMember = new System.Windows.Forms.Button();
            this.tbCellphone = new System.Windows.Forms.TextBox();
            this.lblCellphone = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lbTeamMembers = new System.Windows.Forms.ListBox();
            this.btnRemoveSelectedTeamMember = new System.Windows.Forms.Button();
            this.btnCreateTeam = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbTeamName
            // 
            this.tbTeamName.Location = new System.Drawing.Point(44, 160);
            this.tbTeamName.Name = "tbTeamName";
            this.tbTeamName.Size = new System.Drawing.Size(381, 43);
            this.tbTeamName.TabIndex = 13;
            // 
            // lblTeamName
            // 
            this.lblTeamName.AutoSize = true;
            this.lblTeamName.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTeamName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lblTeamName.Location = new System.Drawing.Point(37, 116);
            this.lblTeamName.Name = "lblTeamName";
            this.lblTeamName.Size = new System.Drawing.Size(175, 41);
            this.lblTeamName.TabIndex = 12;
            this.lblTeamName.Text = "Team Name";
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI Light", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lblHeader.Location = new System.Drawing.Point(33, 35);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(276, 65);
            this.lblHeader.TabIndex = 11;
            this.lblHeader.Text = "Create Team";
            // 
            // btnAddTeamMember
            // 
            this.btnAddTeamMember.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnAddTeamMember.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnAddTeamMember.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnAddTeamMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTeamMember.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAddTeamMember.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnAddTeamMember.Location = new System.Drawing.Point(108, 324);
            this.btnAddTeamMember.Name = "btnAddTeamMember";
            this.btnAddTeamMember.Size = new System.Drawing.Size(262, 49);
            this.btnAddTeamMember.TabIndex = 19;
            this.btnAddTeamMember.Text = "Add Member";
            this.btnAddTeamMember.UseVisualStyleBackColor = true;
            this.btnAddTeamMember.Click += new System.EventHandler(this.BtnAddTeamMember_Click);
            // 
            // ddSelectTeamMember
            // 
            this.ddSelectTeamMember.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.ddSelectTeamMember.FormattingEnabled = true;
            this.ddSelectTeamMember.Location = new System.Drawing.Point(44, 273);
            this.ddSelectTeamMember.Name = "ddSelectTeamMember";
            this.ddSelectTeamMember.Size = new System.Drawing.Size(381, 45);
            this.ddSelectTeamMember.TabIndex = 18;
            // 
            // lblSelectTeamMember
            // 
            this.lblSelectTeamMember.AutoSize = true;
            this.lblSelectTeamMember.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSelectTeamMember.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lblSelectTeamMember.Location = new System.Drawing.Point(36, 224);
            this.lblSelectTeamMember.Name = "lblSelectTeamMember";
            this.lblSelectTeamMember.Size = new System.Drawing.Size(296, 41);
            this.lblSelectTeamMember.TabIndex = 17;
            this.lblSelectTeamMember.Text = "Select Team Member";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCreateMember);
            this.groupBox1.Controls.Add(this.tbCellphone);
            this.groupBox1.Controls.Add(this.lblCellphone);
            this.groupBox1.Controls.Add(this.tbEmail);
            this.groupBox1.Controls.Add(this.lblEmail);
            this.groupBox1.Controls.Add(this.tbLastName);
            this.groupBox1.Controls.Add(this.lblLastName);
            this.groupBox1.Controls.Add(this.tbFirstName);
            this.groupBox1.Controls.Add(this.lblFirstName);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.groupBox1.Location = new System.Drawing.Point(43, 390);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(807, 384);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add New Member";
            // 
            // btnCreateMember
            // 
            this.btnCreateMember.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnCreateMember.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnCreateMember.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnCreateMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateMember.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCreateMember.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnCreateMember.Location = new System.Drawing.Point(320, 319);
            this.btnCreateMember.Name = "btnCreateMember";
            this.btnCreateMember.Size = new System.Drawing.Size(229, 49);
            this.btnCreateMember.TabIndex = 20;
            this.btnCreateMember.Text = "Create Member";
            this.btnCreateMember.UseVisualStyleBackColor = true;
            this.btnCreateMember.Click += new System.EventHandler(this.BtnCreateMember_Click);
            // 
            // tbCellphone
            // 
            this.tbCellphone.Location = new System.Drawing.Point(192, 252);
            this.tbCellphone.Name = "tbCellphone";
            this.tbCellphone.Size = new System.Drawing.Size(573, 47);
            this.tbCellphone.TabIndex = 16;
            // 
            // lblCellphone
            // 
            this.lblCellphone.AutoSize = true;
            this.lblCellphone.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCellphone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lblCellphone.Location = new System.Drawing.Point(9, 252);
            this.lblCellphone.Name = "lblCellphone";
            this.lblCellphone.Size = new System.Drawing.Size(153, 41);
            this.lblCellphone.TabIndex = 15;
            this.lblCellphone.Text = "Cellphone";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(192, 186);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(573, 47);
            this.tbEmail.TabIndex = 14;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lblEmail.Location = new System.Drawing.Point(9, 186);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(88, 41);
            this.lblEmail.TabIndex = 13;
            this.lblEmail.Text = "Email";
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(192, 122);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(573, 47);
            this.tbLastName.TabIndex = 12;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lblLastName.Location = new System.Drawing.Point(9, 122);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(157, 41);
            this.lblLastName.TabIndex = 11;
            this.lblLastName.Text = "Last Name";
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(192, 57);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(573, 47);
            this.tbFirstName.TabIndex = 10;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblFirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lblFirstName.Location = new System.Drawing.Point(9, 57);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(160, 41);
            this.lblFirstName.TabIndex = 9;
            this.lblFirstName.Text = "First Name";
            // 
            // lbTeamMembers
            // 
            this.lbTeamMembers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbTeamMembers.FormattingEnabled = true;
            this.lbTeamMembers.ItemHeight = 37;
            this.lbTeamMembers.Location = new System.Drawing.Point(482, 160);
            this.lbTeamMembers.Name = "lbTeamMembers";
            this.lbTeamMembers.Size = new System.Drawing.Size(395, 224);
            this.lbTeamMembers.TabIndex = 21;
            // 
            // btnRemoveSelectedTeamMember
            // 
            this.btnRemoveSelectedTeamMember.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnRemoveSelectedTeamMember.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnRemoveSelectedTeamMember.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnRemoveSelectedTeamMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveSelectedTeamMember.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRemoveSelectedTeamMember.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnRemoveSelectedTeamMember.Location = new System.Drawing.Point(721, 113);
            this.btnRemoveSelectedTeamMember.Name = "btnRemoveSelectedTeamMember";
            this.btnRemoveSelectedTeamMember.Size = new System.Drawing.Size(156, 41);
            this.btnRemoveSelectedTeamMember.TabIndex = 26;
            this.btnRemoveSelectedTeamMember.Text = "Remove selected";
            this.btnRemoveSelectedTeamMember.UseVisualStyleBackColor = true;
            this.btnRemoveSelectedTeamMember.Click += new System.EventHandler(this.BtnRemoveSelectedTeamMember_Click);
            // 
            // btnCreateTeam
            // 
            this.btnCreateTeam.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnCreateTeam.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnCreateTeam.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnCreateTeam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateTeam.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCreateTeam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnCreateTeam.Location = new System.Drawing.Point(327, 780);
            this.btnCreateTeam.Name = "btnCreateTeam";
            this.btnCreateTeam.Size = new System.Drawing.Size(288, 72);
            this.btnCreateTeam.TabIndex = 27;
            this.btnCreateTeam.Text = "Create Team";
            this.btnCreateTeam.UseVisualStyleBackColor = true;
            this.btnCreateTeam.Click += new System.EventHandler(this.BtnCreateTeam_Click);
            // 
            // CreateTeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(902, 857);
            this.Controls.Add(this.btnCreateTeam);
            this.Controls.Add(this.btnRemoveSelectedTeamMember);
            this.Controls.Add(this.lbTeamMembers);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAddTeamMember);
            this.Controls.Add(this.ddSelectTeamMember);
            this.Controls.Add(this.lblSelectTeamMember);
            this.Controls.Add(this.tbTeamName);
            this.Controls.Add(this.lblTeamName);
            this.Controls.Add(this.lblHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "CreateTeamForm";
            this.Text = "Create Team";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbTeamName;
        private System.Windows.Forms.Label lblTeamName;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btnAddTeamMember;
        private System.Windows.Forms.ComboBox ddSelectTeamMember;
        private System.Windows.Forms.Label lblSelectTeamMember;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCreateMember;
        private System.Windows.Forms.TextBox tbCellphone;
        private System.Windows.Forms.Label lblCellphone;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.ListBox lbTeamMembers;
        private System.Windows.Forms.Button btnRemoveSelectedTeamMember;
        private System.Windows.Forms.Button btnCreateTeam;
    }
}