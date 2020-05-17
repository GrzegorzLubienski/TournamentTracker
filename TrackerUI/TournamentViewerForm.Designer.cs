namespace TrackerUI
{
    partial class TournamentViewerForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblHeader = new System.Windows.Forms.Label();
            this.tournamentName = new System.Windows.Forms.Label();
            this.lblRound = new System.Windows.Forms.Label();
            this.ddRound = new System.Windows.Forms.ComboBox();
            this.cbUnplayedOnly = new System.Windows.Forms.CheckBox();
            this.lbMatchup = new System.Windows.Forms.ListBox();
            this.teamOneName = new System.Windows.Forms.Label();
            this.lblTeamOneScore = new System.Windows.Forms.Label();
            this.tbTeamOneScore = new System.Windows.Forms.TextBox();
            this.tbTeamTwoScore = new System.Windows.Forms.TextBox();
            this.lblTeamTwoScore = new System.Windows.Forms.Label();
            this.teamTwoName = new System.Windows.Forms.Label();
            this.lblVS = new System.Windows.Forms.Label();
            this.btnScore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI Light", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lblHeader.Location = new System.Drawing.Point(29, 37);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(291, 65);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Tournament :";
            // 
            // tournamentName
            // 
            this.tournamentName.AutoSize = true;
            this.tournamentName.Font = new System.Drawing.Font("Segoe UI Light", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tournamentName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.tournamentName.Location = new System.Drawing.Point(307, 37);
            this.tournamentName.Name = "tournamentName";
            this.tournamentName.Size = new System.Drawing.Size(452, 65);
            this.tournamentName.TabIndex = 1;
            this.tournamentName.Text = "<tournament name>";
            // 
            // lblRound
            // 
            this.lblRound.AutoSize = true;
            this.lblRound.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblRound.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lblRound.Location = new System.Drawing.Point(50, 123);
            this.lblRound.Name = "lblRound";
            this.lblRound.Size = new System.Drawing.Size(131, 45);
            this.lblRound.TabIndex = 2;
            this.lblRound.Text = "Round :";
            // 
            // ddRound
            // 
            this.ddRound.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.ddRound.FormattingEnabled = true;
            this.ddRound.Location = new System.Drawing.Point(189, 130);
            this.ddRound.Name = "ddRound";
            this.ddRound.Size = new System.Drawing.Size(257, 39);
            this.ddRound.TabIndex = 3;
            this.ddRound.SelectedIndexChanged += new System.EventHandler(this.DdRound_SelectedIndexChanged);
            // 
            // cbUnplayedOnly
            // 
            this.cbUnplayedOnly.AutoSize = true;
            this.cbUnplayedOnly.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbUnplayedOnly.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.cbUnplayedOnly.Location = new System.Drawing.Point(189, 188);
            this.cbUnplayedOnly.Name = "cbUnplayedOnly";
            this.cbUnplayedOnly.Size = new System.Drawing.Size(217, 42);
            this.cbUnplayedOnly.TabIndex = 4;
            this.cbUnplayedOnly.Text = "Unplayed only";
            this.cbUnplayedOnly.UseVisualStyleBackColor = true;
            this.cbUnplayedOnly.CheckedChanged += new System.EventHandler(this.CbUnplayedOnly_CheckedChanged);
            // 
            // lbMatchup
            // 
            this.lbMatchup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbMatchup.FormattingEnabled = true;
            this.lbMatchup.ItemHeight = 31;
            this.lbMatchup.Location = new System.Drawing.Point(58, 261);
            this.lbMatchup.Name = "lbMatchup";
            this.lbMatchup.Size = new System.Drawing.Size(388, 250);
            this.lbMatchup.TabIndex = 5;
            this.lbMatchup.SelectedIndexChanged += new System.EventHandler(this.LbMatchup_SelectedIndexChanged);
            // 
            // teamOneName
            // 
            this.teamOneName.AutoSize = true;
            this.teamOneName.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.teamOneName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.teamOneName.Location = new System.Drawing.Point(504, 245);
            this.teamOneName.Name = "teamOneName";
            this.teamOneName.Size = new System.Drawing.Size(183, 41);
            this.teamOneName.TabIndex = 6;
            this.teamOneName.Text = "<team one>";
            // 
            // lblTeamOneScore
            // 
            this.lblTeamOneScore.AutoSize = true;
            this.lblTeamOneScore.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTeamOneScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lblTeamOneScore.Location = new System.Drawing.Point(504, 286);
            this.lblTeamOneScore.Name = "lblTeamOneScore";
            this.lblTeamOneScore.Size = new System.Drawing.Size(92, 41);
            this.lblTeamOneScore.TabIndex = 7;
            this.lblTeamOneScore.Text = "Score";
            // 
            // tbTeamOneScore
            // 
            this.tbTeamOneScore.Location = new System.Drawing.Point(602, 289);
            this.tbTeamOneScore.Name = "tbTeamOneScore";
            this.tbTeamOneScore.Size = new System.Drawing.Size(100, 38);
            this.tbTeamOneScore.TabIndex = 8;
            // 
            // tbTeamTwoScore
            // 
            this.tbTeamTwoScore.Location = new System.Drawing.Point(602, 438);
            this.tbTeamTwoScore.Name = "tbTeamTwoScore";
            this.tbTeamTwoScore.Size = new System.Drawing.Size(100, 38);
            this.tbTeamTwoScore.TabIndex = 11;
            // 
            // lblTeamTwoScore
            // 
            this.lblTeamTwoScore.AutoSize = true;
            this.lblTeamTwoScore.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTeamTwoScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lblTeamTwoScore.Location = new System.Drawing.Point(504, 435);
            this.lblTeamTwoScore.Name = "lblTeamTwoScore";
            this.lblTeamTwoScore.Size = new System.Drawing.Size(92, 41);
            this.lblTeamTwoScore.TabIndex = 10;
            this.lblTeamTwoScore.Text = "Score";
            // 
            // teamTwoName
            // 
            this.teamTwoName.AutoSize = true;
            this.teamTwoName.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.teamTwoName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.teamTwoName.Location = new System.Drawing.Point(504, 394);
            this.teamTwoName.Name = "teamTwoName";
            this.teamTwoName.Size = new System.Drawing.Size(183, 41);
            this.teamTwoName.TabIndex = 9;
            this.teamTwoName.Text = "<team two>";
            // 
            // lblVS
            // 
            this.lblVS.AutoSize = true;
            this.lblVS.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblVS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lblVS.Location = new System.Drawing.Point(553, 344);
            this.lblVS.Name = "lblVS";
            this.lblVS.Size = new System.Drawing.Size(78, 32);
            this.lblVS.TabIndex = 12;
            this.lblVS.Text = "- VS -";
            // 
            // btnScore
            // 
            this.btnScore.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnScore.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnScore.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScore.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnScore.Location = new System.Drawing.Point(728, 344);
            this.btnScore.Name = "btnScore";
            this.btnScore.Size = new System.Drawing.Size(137, 49);
            this.btnScore.TabIndex = 13;
            this.btnScore.Text = "Score";
            this.btnScore.UseVisualStyleBackColor = true;
            this.btnScore.Click += new System.EventHandler(this.BtnScore_Click);
            // 
            // TournamentViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(877, 565);
            this.Controls.Add(this.btnScore);
            this.Controls.Add(this.lblVS);
            this.Controls.Add(this.tbTeamTwoScore);
            this.Controls.Add(this.lblTeamTwoScore);
            this.Controls.Add(this.teamTwoName);
            this.Controls.Add(this.tbTeamOneScore);
            this.Controls.Add(this.lblTeamOneScore);
            this.Controls.Add(this.teamOneName);
            this.Controls.Add(this.lbMatchup);
            this.Controls.Add(this.cbUnplayedOnly);
            this.Controls.Add(this.ddRound);
            this.Controls.Add(this.lblRound);
            this.Controls.Add(this.tournamentName);
            this.Controls.Add(this.lblHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "TournamentViewerForm";
            this.Text = "Tournament Viewer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label tournamentName;
        private System.Windows.Forms.Label lblRound;
        private System.Windows.Forms.ComboBox ddRound;
        private System.Windows.Forms.CheckBox cbUnplayedOnly;
        private System.Windows.Forms.ListBox lbMatchup;
        private System.Windows.Forms.Label teamOneName;
        private System.Windows.Forms.Label lblTeamOneScore;
        private System.Windows.Forms.TextBox tbTeamOneScore;
        private System.Windows.Forms.TextBox tbTeamTwoScore;
        private System.Windows.Forms.Label lblTeamTwoScore;
        private System.Windows.Forms.Label teamTwoName;
        private System.Windows.Forms.Label lblVS;
        private System.Windows.Forms.Button btnScore;
    }
}

