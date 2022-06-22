﻿namespace WorldCupWindowsForms.UserControls
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
            this.components = new System.ComponentModel.Container();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.lblShirtNumber = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblShirtNumberW = new System.Windows.Forms.Label();
            this.lblPositionW = new System.Windows.Forms.Label();
            this.lblCaptainW = new System.Windows.Forms.Label();
            this.btnFavoritePlayer = new System.Windows.Forms.Button();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.changePicture = new System.Windows.Forms.ToolStripMenuItem();
            this.imgPlayer = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerName.Location = new System.Drawing.Point(118, 3);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(165, 29);
            this.lblPlayerName.TabIndex = 1;
            this.lblPlayerName.Text = "<Ime igrača>";
            // 
            // lblShirtNumber
            // 
            this.lblShirtNumber.AutoSize = true;
            this.lblShirtNumber.Location = new System.Drawing.Point(118, 63);
            this.lblShirtNumber.Name = "lblShirtNumber";
            this.lblShirtNumber.Size = new System.Drawing.Size(85, 20);
            this.lblShirtNumber.TabIndex = 2;
            this.lblShirtNumber.Text = "Broj dresa:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kapetan:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Pozicija:";
            // 
            // lblShirtNumberW
            // 
            this.lblShirtNumberW.AutoSize = true;
            this.lblShirtNumberW.Location = new System.Drawing.Point(210, 63);
            this.lblShirtNumberW.Name = "lblShirtNumberW";
            this.lblShirtNumberW.Size = new System.Drawing.Size(51, 20);
            this.lblShirtNumberW.TabIndex = 6;
            this.lblShirtNumberW.Text = "label3";
            // 
            // lblPositionW
            // 
            this.lblPositionW.AutoSize = true;
            this.lblPositionW.Location = new System.Drawing.Point(210, 89);
            this.lblPositionW.Name = "lblPositionW";
            this.lblPositionW.Size = new System.Drawing.Size(51, 20);
            this.lblPositionW.TabIndex = 7;
            this.lblPositionW.Text = "label4";
            // 
            // lblCaptainW
            // 
            this.lblCaptainW.AutoSize = true;
            this.lblCaptainW.Location = new System.Drawing.Point(210, 115);
            this.lblCaptainW.Name = "lblCaptainW";
            this.lblCaptainW.Size = new System.Drawing.Size(51, 20);
            this.lblCaptainW.TabIndex = 8;
            this.lblCaptainW.Text = "label5";
            // 
            // btnFavoritePlayer
            // 
            this.btnFavoritePlayer.AutoSize = true;
            this.btnFavoritePlayer.FlatAppearance.BorderSize = 0;
            this.btnFavoritePlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFavoritePlayer.Location = new System.Drawing.Point(382, 34);
            this.btnFavoritePlayer.Name = "btnFavoritePlayer";
            this.btnFavoritePlayer.Size = new System.Drawing.Size(78, 78);
            this.btnFavoritePlayer.TabIndex = 4;
            this.btnFavoritePlayer.UseVisualStyleBackColor = true;
            this.btnFavoritePlayer.Click += new System.EventHandler(this.btnFavoritePlayer_Click);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changePicture});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(185, 36);
            // 
            // changePicture
            // 
            this.changePicture.Name = "changePicture";
            this.changePicture.Size = new System.Drawing.Size(184, 32);
            this.changePicture.Text = "Izmijeni sliku";
            this.changePicture.Click += new System.EventHandler(this.izmijeniSlikuToolStripMenuItem_Click);
            // 
            // imgPlayer
            // 
            this.imgPlayer.Location = new System.Drawing.Point(3, 3);
            this.imgPlayer.Name = "imgPlayer";
            this.imgPlayer.Size = new System.Drawing.Size(108, 144);
            this.imgPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgPlayer.TabIndex = 0;
            this.imgPlayer.TabStop = false;
            this.imgPlayer.MouseClick += new System.Windows.Forms.MouseEventHandler(this.imgPlayer_MouseClick);
            // 
            // PlayerUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.lblCaptainW);
            this.Controls.Add(this.lblPositionW);
            this.Controls.Add(this.lblShirtNumberW);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnFavoritePlayer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblShirtNumber);
            this.Controls.Add(this.lblPlayerName);
            this.Controls.Add(this.imgPlayer);
            this.Name = "PlayerUC";
            this.Size = new System.Drawing.Size(500, 150);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PlayerUC_MouseDown);
            this.contextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.Label lblShirtNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFavoritePlayer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblShirtNumberW;
        private System.Windows.Forms.Label lblPositionW;
        private System.Windows.Forms.Label lblCaptainW;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem changePicture;
        private System.Windows.Forms.PictureBox imgPlayer;
    }
}
