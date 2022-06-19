namespace WorldCupWindowsForms
{
    partial class MainForm
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
            this.ddlTeams = new System.Windows.Forms.ComboBox();
            this.pnlPlayers = new System.Windows.Forms.FlowLayoutPanel();
            this.lblPickCountry = new System.Windows.Forms.Label();
            this.pnlFavoritePlayers = new System.Windows.Forms.FlowLayoutPanel();
            this.btnOpenStatisticsForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ddlTeams
            // 
            this.ddlTeams.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ddlTeams.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlTeams.FormattingEnabled = true;
            this.ddlTeams.Location = new System.Drawing.Point(559, 80);
            this.ddlTeams.Name = "ddlTeams";
            this.ddlTeams.Size = new System.Drawing.Size(346, 28);
            this.ddlTeams.TabIndex = 0;
            this.ddlTeams.SelectedIndexChanged += new System.EventHandler(this.ddlTeams_SelectedIndexChanged);
            // 
            // pnlPlayers
            // 
            this.pnlPlayers.AllowDrop = true;
            this.pnlPlayers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlPlayers.AutoScroll = true;
            this.pnlPlayers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPlayers.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnlPlayers.Location = new System.Drawing.Point(12, 163);
            this.pnlPlayers.Name = "pnlPlayers";
            this.pnlPlayers.Size = new System.Drawing.Size(578, 619);
            this.pnlPlayers.TabIndex = 2;
            this.pnlPlayers.WrapContents = false;
            this.pnlPlayers.DragDrop += new System.Windows.Forms.DragEventHandler(this.pnlPlayers_DragDrop);
            this.pnlPlayers.DragEnter += new System.Windows.Forms.DragEventHandler(this.Panels_DragEnter);
            // 
            // lblPickCountry
            // 
            this.lblPickCountry.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPickCountry.AutoSize = true;
            this.lblPickCountry.Location = new System.Drawing.Point(608, 57);
            this.lblPickCountry.Name = "lblPickCountry";
            this.lblPickCountry.Size = new System.Drawing.Size(249, 20);
            this.lblPickCountry.TabIndex = 3;
            this.lblPickCountry.Text = "Odaberite omiljenu reprezentaciju:";
            // 
            // pnlFavoritePlayers
            // 
            this.pnlFavoritePlayers.AllowDrop = true;
            this.pnlFavoritePlayers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFavoritePlayers.AutoScroll = true;
            this.pnlFavoritePlayers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFavoritePlayers.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnlFavoritePlayers.Location = new System.Drawing.Point(874, 163);
            this.pnlFavoritePlayers.Name = "pnlFavoritePlayers";
            this.pnlFavoritePlayers.Size = new System.Drawing.Size(578, 619);
            this.pnlFavoritePlayers.TabIndex = 3;
            this.pnlFavoritePlayers.WrapContents = false;
            this.pnlFavoritePlayers.DragDrop += new System.Windows.Forms.DragEventHandler(this.pnlFavoritePlayers_DragDrop);
            this.pnlFavoritePlayers.DragEnter += new System.Windows.Forms.DragEventHandler(this.Panels_DragEnter);
            // 
            // btnOpenStatisticsForm
            // 
            this.btnOpenStatisticsForm.AutoSize = true;
            this.btnOpenStatisticsForm.Location = new System.Drawing.Point(633, 114);
            this.btnOpenStatisticsForm.Name = "btnOpenStatisticsForm";
            this.btnOpenStatisticsForm.Size = new System.Drawing.Size(199, 30);
            this.btnOpenStatisticsForm.TabIndex = 4;
            this.btnOpenStatisticsForm.Text = "Statistika odabrane ekipe";
            this.btnOpenStatisticsForm.UseVisualStyleBackColor = true;
            this.btnOpenStatisticsForm.Click += new System.EventHandler(this.btnOpenStatisticsForm_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1464, 794);
            this.Controls.Add(this.btnOpenStatisticsForm);
            this.Controls.Add(this.pnlFavoritePlayers);
            this.Controls.Add(this.lblPickCountry);
            this.Controls.Add(this.pnlPlayers);
            this.Controls.Add(this.ddlTeams);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "World Cup";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ddlTeams;
        private System.Windows.Forms.FlowLayoutPanel pnlPlayers;
        private System.Windows.Forms.Label lblPickCountry;
        private System.Windows.Forms.FlowLayoutPanel pnlFavoritePlayers;
        private System.Windows.Forms.Button btnOpenStatisticsForm;
    }
}

