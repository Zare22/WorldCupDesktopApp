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
using System.Resources;
using System.Drawing.Imaging;
using System.IO;

namespace WorldCupWindowsForms.UserControls
{
    public partial class PlayerUC : UserControl
    {
        public Player PlayerInUC { get; set; }

        //private static ResXResourceWriter resx = new ResXResourceWriter("C:\\Users\\Leo\\source\\repos\\WorldCupDesktopApp\\WorldCupWindowsForms\\Resources\\FavoritePlayers.resx");

        public PlayerUC(Player player)
        {
            InitializeComponent();

            PlayerInUC = player;

            //relative paths!!!
            if (File.Exists($"C:\\Users\\Leo\\source\\repos\\WorldCupDesktopApp\\WorldCupWindowsForms\\Resources\\PlayerImages\\{PlayerInUC.Name}.jpg"))
            {
                imgPlayer.ImageLocation = $"C:\\Users\\Leo\\source\\repos\\WorldCupDesktopApp\\WorldCupWindowsForms\\Resources\\PlayerImages\\{PlayerInUC.Name}.jpg";
            }
            else imgPlayer.Image = Properties.Resources.FootballPlayer;

            lblPlayerName.Text = PlayerInUC.Name;
            lblShirtNumberW.Text = PlayerInUC.ShirtNumber.ToString();
            lblPositionW.Text = PlayerInUC.Position.ToString();
            lblCaptainW.Text = PlayerInUC.IsCaptain ? "Yes" : "No";
        }

        private void PlayerUC_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                PlayerUC player = (PlayerUC)sender;
                player.DoDragDrop(player, DragDropEffects.Move | DragDropEffects.Copy);
            }
        }
        //Multiple DnD srediti



        private void imgPlayer_MouseClick(object sender, MouseEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = "Slike|*.bmp;*.jpg;*.png|Sve datoteke|*.*",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
            };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                imgPlayer.Image = new Bitmap(ofd.FileName);
                //relative path
                imgPlayer.Image.Save($"C:\\Users\\Leo\\source\\repos\\WorldCupDesktopApp\\WorldCupWindowsForms\\Resources\\PlayerImages\\{PlayerInUC.Name}.jpg");
            }
        }

        private void btnFavorite_Click(object sender, EventArgs e)
        {
            //if (FavoritePlayersCounter < 3)
            //{
            //    resx.AddResource($"Favorite Player {FavoritePlayersCounter}:", PlayerInUC.Name);
            //    FavoritePlayersCounter++;
            //}
            //else
            //{
            //    resx.Close();
            //    MessageBox.Show("Nije moguće dodati više favorita!");
            //    return;

            //}
            PlayerInUC.Favorite = !PlayerInUC.Favorite; 
            if (PlayerInUC.Favorite)
            {
                btnFavorite.Image = Properties.Resources.HeartsFIlledpng;
            }
            else btnFavorite.Image = Properties.Resources.Hearts_icon;
            //Pretplata mainforme na ovaj event??
        }
    }
}
