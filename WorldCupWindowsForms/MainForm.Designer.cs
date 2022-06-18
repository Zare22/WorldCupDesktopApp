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
            this.lbPlayers = new System.Windows.Forms.ListBox();
            this.pnlPlayers = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // ddlTeams
            // 
            this.ddlTeams.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlTeams.FormattingEnabled = true;
            this.ddlTeams.Location = new System.Drawing.Point(12, 12);
            this.ddlTeams.Name = "ddlTeams";
            this.ddlTeams.Size = new System.Drawing.Size(301, 28);
            this.ddlTeams.TabIndex = 0;
            this.ddlTeams.SelectedIndexChanged += new System.EventHandler(this.ddlTeams_SelectedIndexChangedAsync);
            // 
            // lbPlayers
            // 
            this.lbPlayers.FormattingEnabled = true;
            this.lbPlayers.ItemHeight = 20;
            this.lbPlayers.Location = new System.Drawing.Point(12, 46);
            this.lbPlayers.Name = "lbPlayers";
            this.lbPlayers.Size = new System.Drawing.Size(441, 484);
            this.lbPlayers.TabIndex = 1;
            // 
            // pnlPlayers
            // 
            this.pnlPlayers.AutoScroll = true;
            this.pnlPlayers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPlayers.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnlPlayers.Location = new System.Drawing.Point(502, 46);
            this.pnlPlayers.Name = "pnlPlayers";
            this.pnlPlayers.Size = new System.Drawing.Size(584, 484);
            this.pnlPlayers.TabIndex = 2;
            this.pnlPlayers.WrapContents = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1464, 794);
            this.Controls.Add(this.pnlPlayers);
            this.Controls.Add(this.lbPlayers);
            this.Controls.Add(this.ddlTeams);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox ddlTeams;
        private System.Windows.Forms.ListBox lbPlayers;
        private System.Windows.Forms.FlowLayoutPanel pnlPlayers;
    }
}

