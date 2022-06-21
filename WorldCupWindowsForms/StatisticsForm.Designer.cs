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
            this.playersStats.AllowUserToAddRows = false;
            this.playersStats.AllowUserToDeleteRows = false;
            this.playersStats.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.playersStats.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.playersStats.ColumnHeadersHeight = 34;
            this.playersStats.Location = new System.Drawing.Point(13, 45);
            this.playersStats.Name = "playersStats";
            this.playersStats.ReadOnly = true;
            this.playersStats.RowHeadersWidth = 62;
            this.playersStats.RowTemplate.Height = 28;
            this.playersStats.Size = new System.Drawing.Size(543, 634);
            this.playersStats.TabIndex = 0;
            // 
            // matchesStats
            // 
            this.matchesStats.AllowUserToAddRows = false;
            this.matchesStats.AllowUserToDeleteRows = false;
            this.matchesStats.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.matchesStats.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.matchesStats.ColumnHeadersHeight = 34;
            this.matchesStats.Location = new System.Drawing.Point(684, 45);
            this.matchesStats.Name = "matchesStats";
            this.matchesStats.ReadOnly = true;
            this.matchesStats.RowHeadersWidth = 62;
            this.matchesStats.RowTemplate.Height = 28;
            this.matchesStats.Size = new System.Drawing.Size(543, 634);
            this.matchesStats.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(194, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Statistike igrača";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(884, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Statistike utakmica";
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(561, 275);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(116, 116);
            this.btnPrint.TabIndex = 4;
            this.btnPrint.Text = "Isprintaj statistiku";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // printPreviewDialog
            // 
            this.printPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog.Document = this.printDocument;
            this.printPreviewDialog.Enabled = true;
            this.printPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog.Icon")));
            this.printPreviewDialog.Name = "printPreviewDialog";
            this.printPreviewDialog.Visible = false;
            // 
            // printDocument
            // 
            this.printDocument.DocumentName = "statistics";
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // StatisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1239, 691);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.matchesStats);
            this.Controls.Add(this.playersStats);
            this.Name = "StatisticsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Statistike <Reprezentacije>";
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