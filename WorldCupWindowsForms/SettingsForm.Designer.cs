namespace WorldCupWindowsForms
{
    partial class SettingsForm
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
            this.lblChampionship = new System.Windows.Forms.Label();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblChampionship
            // 
            this.lblChampionship.AutoSize = true;
            this.lblChampionship.Location = new System.Drawing.Point(12, 75);
            this.lblChampionship.Name = "lblChampionship";
            this.lblChampionship.Size = new System.Drawing.Size(155, 20);
            this.lblChampionship.TabIndex = 0;
            this.lblChampionship.Text = "Odaberite prvenstvo:";
            // 
            // lblLanguage
            // 
            this.lblLanguage.AutoSize = true;
            this.lblLanguage.Location = new System.Drawing.Point(12, 149);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(118, 20);
            this.lblLanguage.TabIndex = 1;
            this.lblLanguage.Text = "Odaberite jezik:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Odaberite vrstu konekcije:";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 525);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblLanguage);
            this.Controls.Add(this.lblChampionship);
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Postavke";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblChampionship;
        private System.Windows.Forms.Label lblLanguage;
        private System.Windows.Forms.Label label1;
    }
}