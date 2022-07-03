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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatisticsForm));
            this.playersStats = new System.Windows.Forms.DataGridView();
            this.matchesStats = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.playersStats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchesStats)).BeginInit();
            this.SuspendLayout();
            // 
            // playersStats
            // 
            resources.ApplyResources(this.playersStats, "playersStats");
            this.playersStats.AllowUserToAddRows = false;
            this.playersStats.AllowUserToDeleteRows = false;
            this.playersStats.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.playersStats.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.playersStats.Name = "playersStats";
            this.playersStats.ReadOnly = true;
            this.playersStats.RowTemplate.Height = 28;
            // 
            // matchesStats
            // 
            resources.ApplyResources(this.matchesStats, "matchesStats");
            this.matchesStats.AllowUserToAddRows = false;
            this.matchesStats.AllowUserToDeleteRows = false;
            this.matchesStats.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.matchesStats.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.matchesStats.Name = "matchesStats";
            this.matchesStats.ReadOnly = true;
            this.matchesStats.RowTemplate.Height = 28;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // btnPrint
            // 
            resources.ApplyResources(this.btnPrint, "btnPrint");
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // printPreviewDialog
            // 
            resources.ApplyResources(this.printPreviewDialog, "printPreviewDialog");
            this.printPreviewDialog.Document = this.printDocument;
            this.printPreviewDialog.Name = "printPreviewDialog";
            // 
            // printDocument
            // 
            this.printDocument.DocumentName = "statistics";
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // StatisticsForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.matchesStats);
            this.Controls.Add(this.playersStats);
            this.Name = "StatisticsForm";
            this.Load += new System.EventHandler(this.StatisticsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.playersStats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchesStats)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView playersStats;
        private System.Windows.Forms.DataGridView matchesStats;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
        private System.Drawing.Printing.PrintDocument printDocument;
    }
}