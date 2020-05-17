namespace TrackerUI
{
    partial class CreateTournamentForm
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
            this.lblHeader = new System.Windows.Forms.Label();
            this.tbTournamentName = new System.Windows.Forms.TextBox();
            this.lblTournamentName = new System.Windows.Forms.Label();
            this.tbEntryFee = new System.Windows.Forms.TextBox();
            this.lblEntryFee = new System.Windows.Forms.Label();
            this.ddSelectTeam = new System.Windows.Forms.ComboBox();
            this.lblSelectTeam = new System.Windows.Forms.Label();
            this.llCreateNewTeam = new System.Windows.Forms.LinkLabel();
            this.btnAddTeam = new System.Windows.Forms.Button();
            this.btnCreatePrize = new System.Windows.Forms.Button();
            this.lbTournamentTeams = new System.Windows.Forms.ListBox();
            this.lblPlayers = new System.Windows.Forms.Label();
            this.lblPrizes = new System.Windows.Forms.Label();
            this.lbPrizes = new System.Windows.Forms.ListBox();
            this.btnRemoveSelectedTeam = new System.Windows.Forms.Button();
            this.btnRemoveSelectedPrize = new System.Windows.Forms.Button();
            this.btnCreateTournament = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI Light", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lblHeader.Location = new System.Drawing.Point(34, 35);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(411, 65);
            this.lblHeader.TabIndex = 1;
            this.lblHeader.Text = "Create Tournament";
            // 
            // tbTournamentName
            // 
            this.tbTournamentName.Location = new System.Drawing.Point(45, 160);
            this.tbTournamentName.Name = "tbTournamentName";
            this.tbTournamentName.Size = new System.Drawing.Size(368, 38);
            this.tbTournamentName.TabIndex = 10;
            // 
            // lblTournamentName
            // 
            this.lblTournamentName.AutoSize = true;
            this.lblTournamentName.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTournamentName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lblTournamentName.Location = new System.Drawing.Point(38, 116);
            this.lblTournamentName.Name = "lblTournamentName";
            this.lblTournamentName.Size = new System.Drawing.Size(264, 41);
            this.lblTournamentName.TabIndex = 9;
            this.lblTournamentName.Text = "Tournament Name";
            // 
            // tbEntryFee
            // 
            this.tbEntryFee.Location = new System.Drawing.Point(184, 230);
            this.tbEntryFee.Name = "tbEntryFee";
            this.tbEntryFee.Size = new System.Drawing.Size(100, 38);
            this.tbEntryFee.TabIndex = 12;
            this.tbEntryFee.Text = "0";
            // 
            // lblEntryFee
            // 
            this.lblEntryFee.AutoSize = true;
            this.lblEntryFee.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblEntryFee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lblEntryFee.Location = new System.Drawing.Point(38, 227);
            this.lblEntryFee.Name = "lblEntryFee";
            this.lblEntryFee.Size = new System.Drawing.Size(140, 41);
            this.lblEntryFee.TabIndex = 11;
            this.lblEntryFee.Text = "Entry Fee";
            // 
            // ddSelectTeam
            // 
            this.ddSelectTeam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.ddSelectTeam.FormattingEnabled = true;
            this.ddSelectTeam.Location = new System.Drawing.Point(45, 349);
            this.ddSelectTeam.Name = "ddSelectTeam";
            this.ddSelectTeam.Size = new System.Drawing.Size(369, 39);
            this.ddSelectTeam.TabIndex = 14;
            // 
            // lblSelectTeam
            // 
            this.lblSelectTeam.AutoSize = true;
            this.lblSelectTeam.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSelectTeam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lblSelectTeam.Location = new System.Drawing.Point(37, 305);
            this.lblSelectTeam.Name = "lblSelectTeam";
            this.lblSelectTeam.Size = new System.Drawing.Size(175, 41);
            this.lblSelectTeam.TabIndex = 13;
            this.lblSelectTeam.Text = "Select Team";
            // 
            // llCreateNewTeam
            // 
            this.llCreateNewTeam.AutoSize = true;
            this.llCreateNewTeam.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.llCreateNewTeam.LinkColor = System.Drawing.Color.Lime;
            this.llCreateNewTeam.Location = new System.Drawing.Point(280, 309);
            this.llCreateNewTeam.Name = "llCreateNewTeam";
            this.llCreateNewTeam.Size = new System.Drawing.Size(133, 32);
            this.llCreateNewTeam.TabIndex = 15;
            this.llCreateNewTeam.TabStop = true;
            this.llCreateNewTeam.Text = "Create new";
            this.llCreateNewTeam.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LlCreateNewTeam_LinkClicked);
            // 
            // btnAddTeam
            // 
            this.btnAddTeam.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnAddTeam.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnAddTeam.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnAddTeam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTeam.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAddTeam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnAddTeam.Location = new System.Drawing.Point(109, 405);
            this.btnAddTeam.Name = "btnAddTeam";
            this.btnAddTeam.Size = new System.Drawing.Size(262, 49);
            this.btnAddTeam.TabIndex = 16;
            this.btnAddTeam.Text = "Add Team";
            this.btnAddTeam.UseVisualStyleBackColor = true;
            this.btnAddTeam.Click += new System.EventHandler(this.BtnAddTeam_Click);
            // 
            // btnCreatePrize
            // 
            this.btnCreatePrize.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnCreatePrize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnCreatePrize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnCreatePrize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreatePrize.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCreatePrize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnCreatePrize.Location = new System.Drawing.Point(109, 504);
            this.btnCreatePrize.Name = "btnCreatePrize";
            this.btnCreatePrize.Size = new System.Drawing.Size(262, 49);
            this.btnCreatePrize.TabIndex = 17;
            this.btnCreatePrize.Text = "Create Prize";
            this.btnCreatePrize.UseVisualStyleBackColor = true;
            this.btnCreatePrize.Click += new System.EventHandler(this.BtnCreatePrize_Click);
            // 
            // lbTournamentTeams
            // 
            this.lbTournamentTeams.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbTournamentTeams.FormattingEnabled = true;
            this.lbTournamentTeams.ItemHeight = 31;
            this.lbTournamentTeams.Location = new System.Drawing.Point(496, 168);
            this.lbTournamentTeams.Name = "lbTournamentTeams";
            this.lbTournamentTeams.Size = new System.Drawing.Size(395, 157);
            this.lbTournamentTeams.TabIndex = 18;
            // 
            // lblPlayers
            // 
            this.lblPlayers.AutoSize = true;
            this.lblPlayers.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPlayers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lblPlayers.Location = new System.Drawing.Point(489, 116);
            this.lblPlayers.Name = "lblPlayers";
            this.lblPlayers.Size = new System.Drawing.Size(222, 41);
            this.lblPlayers.TabIndex = 19;
            this.lblPlayers.Text = "Players / Teams";
            // 
            // lblPrizes
            // 
            this.lblPrizes.AutoSize = true;
            this.lblPrizes.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPrizes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lblPrizes.Location = new System.Drawing.Point(489, 344);
            this.lblPrizes.Name = "lblPrizes";
            this.lblPrizes.Size = new System.Drawing.Size(95, 41);
            this.lblPrizes.TabIndex = 22;
            this.lblPrizes.Text = "Prizes";
            // 
            // lbPrizes
            // 
            this.lbPrizes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbPrizes.FormattingEnabled = true;
            this.lbPrizes.ItemHeight = 31;
            this.lbPrizes.Location = new System.Drawing.Point(496, 396);
            this.lbPrizes.Name = "lbPrizes";
            this.lbPrizes.Size = new System.Drawing.Size(395, 157);
            this.lbPrizes.TabIndex = 21;
            // 
            // btnRemoveSelectedTeam
            // 
            this.btnRemoveSelectedTeam.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnRemoveSelectedTeam.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnRemoveSelectedTeam.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnRemoveSelectedTeam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveSelectedTeam.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRemoveSelectedTeam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnRemoveSelectedTeam.Location = new System.Drawing.Point(730, 116);
            this.btnRemoveSelectedTeam.Name = "btnRemoveSelectedTeam";
            this.btnRemoveSelectedTeam.Size = new System.Drawing.Size(161, 41);
            this.btnRemoveSelectedTeam.TabIndex = 24;
            this.btnRemoveSelectedTeam.Text = "Remove selected";
            this.btnRemoveSelectedTeam.UseVisualStyleBackColor = true;
            this.btnRemoveSelectedTeam.Click += new System.EventHandler(this.BtnRemoveSelectedTeam_Click);
            // 
            // btnRemoveSelectedPrize
            // 
            this.btnRemoveSelectedPrize.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnRemoveSelectedPrize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnRemoveSelectedPrize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnRemoveSelectedPrize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveSelectedPrize.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRemoveSelectedPrize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnRemoveSelectedPrize.Location = new System.Drawing.Point(730, 349);
            this.btnRemoveSelectedPrize.Name = "btnRemoveSelectedPrize";
            this.btnRemoveSelectedPrize.Size = new System.Drawing.Size(161, 41);
            this.btnRemoveSelectedPrize.TabIndex = 25;
            this.btnRemoveSelectedPrize.Text = "Remove selected";
            this.btnRemoveSelectedPrize.UseVisualStyleBackColor = true;
            this.btnRemoveSelectedPrize.Click += new System.EventHandler(this.BtnRemoveSelectedPrize_Click);
            // 
            // btnCreateTournament
            // 
            this.btnCreateTournament.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnCreateTournament.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnCreateTournament.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnCreateTournament.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateTournament.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCreateTournament.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnCreateTournament.Location = new System.Drawing.Point(321, 613);
            this.btnCreateTournament.Name = "btnCreateTournament";
            this.btnCreateTournament.Size = new System.Drawing.Size(288, 72);
            this.btnCreateTournament.TabIndex = 26;
            this.btnCreateTournament.Text = "Create Tournament";
            this.btnCreateTournament.UseVisualStyleBackColor = true;
            this.btnCreateTournament.Click += new System.EventHandler(this.BtnCreateTournament_Click);
            // 
            // CreateTournamentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(952, 710);
            this.Controls.Add(this.btnCreateTournament);
            this.Controls.Add(this.btnRemoveSelectedPrize);
            this.Controls.Add(this.btnRemoveSelectedTeam);
            this.Controls.Add(this.lblPrizes);
            this.Controls.Add(this.lbPrizes);
            this.Controls.Add(this.lblPlayers);
            this.Controls.Add(this.lbTournamentTeams);
            this.Controls.Add(this.btnCreatePrize);
            this.Controls.Add(this.btnAddTeam);
            this.Controls.Add(this.llCreateNewTeam);
            this.Controls.Add(this.ddSelectTeam);
            this.Controls.Add(this.lblSelectTeam);
            this.Controls.Add(this.tbEntryFee);
            this.Controls.Add(this.lblEntryFee);
            this.Controls.Add(this.tbTournamentName);
            this.Controls.Add(this.lblTournamentName);
            this.Controls.Add(this.lblHeader);
            this.Font = new System.Drawing.Font("Segoe UI Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "CreateTournamentForm";
            this.Text = "Create Tournament";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.TextBox tbTournamentName;
        private System.Windows.Forms.Label lblTournamentName;
        private System.Windows.Forms.TextBox tbEntryFee;
        private System.Windows.Forms.Label lblEntryFee;
        private System.Windows.Forms.ComboBox ddSelectTeam;
        private System.Windows.Forms.Label lblSelectTeam;
        private System.Windows.Forms.LinkLabel llCreateNewTeam;
        private System.Windows.Forms.Button btnAddTeam;
        private System.Windows.Forms.Button btnCreatePrize;
        private System.Windows.Forms.ListBox lbTournamentTeams;
        private System.Windows.Forms.Label lblPlayers;
        private System.Windows.Forms.Label lblPrizes;
        private System.Windows.Forms.ListBox lbPrizes;
        private System.Windows.Forms.Button btnRemoveSelectedTeam;
        private System.Windows.Forms.Button btnRemoveSelectedPrize;
        private System.Windows.Forms.Button btnCreateTournament;
    }
}