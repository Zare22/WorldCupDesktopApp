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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ddlTeams = new System.Windows.Forms.ComboBox();
            this.pnlPlayers = new System.Windows.Forms.FlowLayoutPanel();
            this.lblPickCountry = new System.Windows.Forms.Label();
            this.pnlFavoritePlayers = new System.Windows.Forms.FlowLayoutPanel();
            this.btnOpenStatisticsForm = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ddlTeams
            // 
            resources.ApplyResources(this.ddlTeams, "ddlTeams");
            this.ddlTeams.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlTeams.FormattingEnabled = true;
            this.ddlTeams.Name = "ddlTeams";
            this.ddlTeams.SelectedIndexChanged += new System.EventHandler(this.ddlTeams_SelectedIndexChanged);
            // 
            // pnlPlayers
            // 
            this.pnlPlayers.AllowDrop = true;
            resources.ApplyResources(this.pnlPlayers, "pnlPlayers");
            this.pnlPlayers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPlayers.Name = "pnlPlayers";
            this.pnlPlayers.DragDrop += new System.Windows.Forms.DragEventHandler(this.pnlPlayers_DragDrop);
            this.pnlPlayers.DragEnter += new System.Windows.Forms.DragEventHandler(this.Panels_DragEnter);
            // 
            // lblPickCountry
            // 
            resources.ApplyResources(this.lblPickCountry, "lblPickCountry");
            this.lblPickCountry.Name = "lblPickCountry";
            // 
            // pnlFavoritePlayers
            // 
            this.pnlFavoritePlayers.AllowDrop = true;
            resources.ApplyResources(this.pnlFavoritePlayers, "pnlFavoritePlayers");
            this.pnlFavoritePlayers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFavoritePlayers.Name = "pnlFavoritePlayers";
            this.pnlFavoritePlayers.DragDrop += new System.Windows.Forms.DragEventHandler(this.pnlPlayers_DragDrop);
            this.pnlFavoritePlayers.DragEnter += new System.Windows.Forms.DragEventHandler(this.Panels_DragEnter);
            // 
            // btnOpenStatisticsForm
            // 
            resources.ApplyResources(this.btnOpenStatisticsForm, "btnOpenStatisticsForm");
            this.btnOpenStatisticsForm.Name = "btnOpenStatisticsForm";
            this.btnOpenStatisticsForm.UseVisualStyleBackColor = true;
            this.btnOpenStatisticsForm.Click += new System.EventHandler(this.btnOpenStatisticsForm_Click);
            // 
            // btnSettings
            // 
            resources.ApplyResources(this.btnSettings, "btnSettings");
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnOpenStatisticsForm);
            this.Controls.Add(this.pnlFavoritePlayers);
            this.Controls.Add(this.lblPickCountry);
            this.Controls.Add(this.pnlPlayers);
            this.Controls.Add(this.ddlTeams);
            this.Name = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
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
        private System.Windows.Forms.Button btnSettings;
    }
}

