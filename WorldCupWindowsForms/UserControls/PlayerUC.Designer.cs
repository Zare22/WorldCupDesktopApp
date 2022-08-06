namespace WorldCupWindowsForms.UserControls
{
    partial class PlayerUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayerUC));
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.lblShirtNumber = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblShirtNumberW = new System.Windows.Forms.Label();
            this.lblPositionW = new System.Windows.Forms.Label();
            this.lblCaptainW = new System.Windows.Forms.Label();
            this.btnFavorite = new System.Windows.Forms.Button();
            this.imgPlayer = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPlayerName
            // 
            resources.ApplyResources(this.lblPlayerName, "lblPlayerName");
            this.lblPlayerName.Name = "lblPlayerName";
            // 
            // lblShirtNumber
            // 
            resources.ApplyResources(this.lblShirtNumber, "lblShirtNumber");
            this.lblShirtNumber.Name = "lblShirtNumber";
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
            // lblShirtNumberW
            // 
            resources.ApplyResources(this.lblShirtNumberW, "lblShirtNumberW");
            this.lblShirtNumberW.Name = "lblShirtNumberW";
            // 
            // lblPositionW
            // 
            resources.ApplyResources(this.lblPositionW, "lblPositionW");
            this.lblPositionW.Name = "lblPositionW";
            // 
            // lblCaptainW
            // 
            resources.ApplyResources(this.lblCaptainW, "lblCaptainW");
            this.lblCaptainW.Name = "lblCaptainW";
            // 
            // btnFavorite
            // 
            resources.ApplyResources(this.btnFavorite, "btnFavorite");
            this.btnFavorite.FlatAppearance.BorderSize = 0;
            this.btnFavorite.Image = global::WorldCupWindowsForms.Properties.Resources.Hearts_icon;
            this.btnFavorite.Name = "btnFavorite";
            this.btnFavorite.UseVisualStyleBackColor = true;
            this.btnFavorite.Click += new System.EventHandler(this.btnFavorite_Click);
            // 
            // imgPlayer
            // 
            resources.ApplyResources(this.imgPlayer, "imgPlayer");
            this.imgPlayer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.imgPlayer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgPlayer.Name = "imgPlayer";
            this.imgPlayer.TabStop = false;
            this.imgPlayer.MouseClick += new System.Windows.Forms.MouseEventHandler(this.imgPlayer_MouseClick);
            // 
            // PlayerUC
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.lblCaptainW);
            this.Controls.Add(this.lblPositionW);
            this.Controls.Add(this.lblShirtNumberW);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnFavorite);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblShirtNumber);
            this.Controls.Add(this.lblPlayerName);
            this.Controls.Add(this.imgPlayer);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "PlayerUC";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PlayerUC_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.imgPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.Label lblShirtNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFavorite;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblShirtNumberW;
        private System.Windows.Forms.Label lblPositionW;
        private System.Windows.Forms.Label lblCaptainW;
        private System.Windows.Forms.PictureBox imgPlayer;
    }
}
