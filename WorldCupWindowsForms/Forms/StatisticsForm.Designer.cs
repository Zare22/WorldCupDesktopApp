namespace WorldCupWindowsForms
{
    partial class StatisticsForm
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
            this.playersStats = new System.Windows.Forms.DataGridView();
            this.matchesStats = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.playersStats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchesStats)).BeginInit();
            this.SuspendLayout();
            // 
            // playersStats
            // 
            this.playersStats.AllowUserToAddRows = false;
            this.playersStats.AllowUserToDeleteRows = false;
            this.playersStats.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.playersStats.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.playersStats.ColumnHeadersHeight = 34;
            this.playersStats.Location = new System.Drawing.Point(13, 13);
            this.playersStats.Name = "playersStats";
            this.playersStats.ReadOnly = true;
            this.playersStats.RowHeadersWidth = 62;
            this.playersStats.RowTemplate.Height = 28;
            this.playersStats.Size = new System.Drawing.Size(543, 666);
            this.playersStats.TabIndex = 0;
            // 
            // matchesStats
            // 
            this.matchesStats.AllowUserToAddRows = false;
            this.matchesStats.AllowUserToDeleteRows = false;
            this.matchesStats.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.matchesStats.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.matchesStats.ColumnHeadersHeight = 34;
            this.matchesStats.Location = new System.Drawing.Point(684, 13);
            this.matchesStats.Name = "matchesStats";
            this.matchesStats.ReadOnly = true;
            this.matchesStats.RowHeadersWidth = 62;
            this.matchesStats.RowTemplate.Height = 28;
            this.matchesStats.Size = new System.Drawing.Size(543, 666);
            this.matchesStats.TabIndex = 1;
            // 
            // StatisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1239, 691);
            this.Controls.Add(this.matchesStats);
            this.Controls.Add(this.playersStats);
            this.Name = "StatisticsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Statistike <Reprezentacije>";
            this.Load += new System.EventHandler(this.StatisticsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.playersStats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchesStats)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView playersStats;
        private System.Windows.Forms.DataGridView matchesStats;
    }
}