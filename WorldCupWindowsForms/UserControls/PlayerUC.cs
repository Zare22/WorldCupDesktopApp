using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorldCupWindowsForms.UserControls
{
    public partial class PlayerUC : UserControl
    {


        public PlayerUC(Player player)
        {
            InitializeComponent();

            if (player.ImagePath == String.Empty)
            {
                imgPlayer.Image = Properties.Resources.FootballPlayer;
            }

            lblPlayerName.Text = player.Name;
            lblShirtNumberW.Text = player.ShirtNumber.ToString();
            lblPositionW.Text = player.Position.ToString();
            lblCaptainW.Text = player.IsCaptain ? "Yes" : "No";

            if (player.Favorite)
            {
                btnFavoritePlayer.Image = Properties.Resources.HeartsFIlledpng;
            }
            else btnFavoritePlayer.Image = Properties.Resources.Hearts_icon;

        }

        private void PlayerUC_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                PlayerUC player = (PlayerUC)sender;
                player.DoDragDrop(player, DragDropEffects.Move | DragDropEffects.Copy);
            }

        }

        

        private void imgPlayer_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip.Show();
            }
        }

        private void izmijeniSlikuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = "Slike|*.bmp;*.jpg;*.png|Sve datoteke|*.*",
                InitialDirectory = Application.StartupPath,
            };
        }

        private void btnFavoritePlayer_Click(object sender, EventArgs e)
        {
            
        }
    }
}
