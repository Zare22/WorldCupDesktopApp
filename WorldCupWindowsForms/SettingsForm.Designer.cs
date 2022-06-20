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
            this.chBoxMale = new System.Windows.Forms.CheckBox();
            this.chBoxWomen = new System.Windows.Forms.CheckBox();
            this.chBoxEnglish = new System.Windows.Forms.CheckBox();
            this.chBoxCroatian = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblChampionship
            // 
            this.lblChampionship.AutoSize = true;
            this.lblChampionship.Location = new System.Drawing.Point(157, 69);
            this.lblChampionship.Name = "lblChampionship";
            this.lblChampionship.Size = new System.Drawing.Size(155, 20);
            this.lblChampionship.TabIndex = 0;
            this.lblChampionship.Text = "Odaberite prvenstvo:";
            // 
            // lblLanguage
            // 
            this.lblLanguage.AutoSize = true;
            this.lblLanguage.Location = new System.Drawing.Point(175, 295);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(118, 20);
            this.lblLanguage.TabIndex = 1;
            this.lblLanguage.Text = "Odaberite jezik:";
            // 
            // chBoxMale
            // 
            this.chBoxMale.Location = new System.Drawing.Point(102, 124);
            this.chBoxMale.Name = "chBoxMale";
            this.chBoxMale.Size = new System.Drawing.Size(265, 24);
            this.chBoxMale.TabIndex = 2;
            this.chBoxMale.Text = "Muško Svjetsko Prvenstvo 2018";
            this.chBoxMale.UseVisualStyleBackColor = true;
            // 
            // chBoxWomen
            // 
            this.chBoxWomen.Checked = true;
            this.chBoxWomen.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chBoxWomen.Location = new System.Drawing.Point(102, 183);
            this.chBoxWomen.Name = "chBoxWomen";
            this.chBoxWomen.Size = new System.Drawing.Size(265, 24);
            this.chBoxWomen.TabIndex = 3;
            this.chBoxWomen.Text = "Žensko Svjetsko Prvenstvo 2019";
            this.chBoxWomen.UseVisualStyleBackColor = true;
            // 
            // chBoxEnglish
            // 
            this.chBoxEnglish.Location = new System.Drawing.Point(102, 400);
            this.chBoxEnglish.Name = "chBoxEnglish";
            this.chBoxEnglish.Size = new System.Drawing.Size(265, 24);
            this.chBoxEnglish.TabIndex = 5;
            this.chBoxEnglish.Text = "Engleski";
            this.chBoxEnglish.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chBoxEnglish.UseVisualStyleBackColor = true;
            // 
            // chBoxCroatian
            // 
            this.chBoxCroatian.Location = new System.Drawing.Point(102, 345);
            this.chBoxCroatian.Name = "chBoxCroatian";
            this.chBoxCroatian.Size = new System.Drawing.Size(265, 24);
            this.chBoxCroatian.TabIndex = 4;
            this.chBoxCroatian.Text = "Hrvatski";
            this.chBoxCroatian.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chBoxCroatian.UseVisualStyleBackColor = true;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 525);
            this.Controls.Add(this.chBoxEnglish);
            this.Controls.Add(this.chBoxCroatian);
            this.Controls.Add(this.chBoxWomen);
            this.Controls.Add(this.chBoxMale);
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
        private System.Windows.Forms.CheckBox chBoxMale;
        private System.Windows.Forms.CheckBox chBoxWomen;
        private System.Windows.Forms.CheckBox chBoxEnglish;
        private System.Windows.Forms.CheckBox chBoxCroatian;
    }
}