namespace TrackerUI
{
    partial class TournamentDashboardForm
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
            this.ddLoadExistingTournament = new System.Windows.Forms.ComboBox();
            this.lblLoadExistingTournament = new System.Windows.Forms.Label();
            this.btnLoadTournament = new System.Windows.Forms.Button();
            this.btnCreateNewTournament = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI Light", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lblHeader.Location = new System.Drawing.Point(59, 21);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(501, 65);
            this.lblHeader.TabIndex = 13;
            this.lblHeader.Text = "Tournament Dashboard";
            // 
            // ddLoadExistingTournament
            // 
            this.ddLoadExistingTournament.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.ddLoadExistingTournament.FormattingEnabled = true;
            this.ddLoadExistingTournament.Location = new System.Drawing.Point(138, 184);
            this.ddLoadExistingTournament.Name = "ddLoadExistingTournament";
            this.ddLoadExistingTournament.Size = new System.Drawing.Size(381, 45);
            this.ddLoadExistingTournament.TabIndex = 20;
            // 
            // lblLoadExistingTournament
            // 
            this.lblLoadExistingTournament.AutoSize = true;
            this.lblLoadExistingTournament.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblLoadExistingTournament.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lblLoadExistingTournament.Location = new System.Drawing.Point(149, 140);
            this.lblLoadExistingTournament.Name = "lblLoadExistingTournament";
            this.lblLoadExistingTournament.Size = new System.Drawing.Size(359, 41);
            this.lblLoadExistingTournament.TabIndex = 19;
            this.lblLoadExistingTournament.Text = "Load Existing Tournament";
            // 
            // btnLoadTournament
            // 
            this.btnLoadTournament.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnLoadTournament.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnLoadTournament.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnLoadTournament.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadTournament.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnLoadTournament.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnLoadTournament.Location = new System.Drawing.Point(145, 235);
            this.btnLoadTournament.Name = "btnLoadTournament";
            this.btnLoadTournament.Size = new System.Drawing.Size(363, 49);
            this.btnLoadTournament.TabIndex = 21;
            this.btnLoadTournament.Text = "Load Tournament";
            this.btnLoadTournament.UseVisualStyleBackColor = true;
            this.btnLoadTournament.Click += new System.EventHandler(this.BtnLoadTournament_Click);
            // 
            // btnCreateNewTournament
            // 
            this.btnCreateNewTournament.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnCreateNewTournament.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnCreateNewTournament.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnCreateNewTournament.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateNewTournament.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCreateNewTournament.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnCreateNewTournament.Location = new System.Drawing.Point(156, 380);
            this.btnCreateNewTournament.Name = "btnCreateNewTournament";
            this.btnCreateNewTournament.Size = new System.Drawing.Size(337, 72);
            this.btnCreateNewTournament.TabIndex = 29;
            this.btnCreateNewTournament.Text = "Create New Tournament";
            this.btnCreateNewTournament.UseVisualStyleBackColor = true;
            this.btnCreateNewTournament.Click += new System.EventHandler(this.BtnCreateNewTournament_Click);
            // 
            // TournamentDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(657, 510);
            this.Controls.Add(this.btnCreateNewTournament);
            this.Controls.Add(this.btnLoadTournament);
            this.Controls.Add(this.ddLoadExistingTournament);
            this.Controls.Add(this.lblLoadExistingTournament);
            this.Controls.Add(this.lblHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "TournamentDashboardForm";
            this.Text = "TournamentDashboardForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.ComboBox ddLoadExistingTournament;
        private System.Windows.Forms.Label lblLoadExistingTournament;
        private System.Windows.Forms.Button btnLoadTournament;
        private System.Windows.Forms.Button btnCreateNewTournament;
    }
}