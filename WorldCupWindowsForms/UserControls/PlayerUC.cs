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
using WorldCupWindowsForms.Protocols;
using DataLayer.Constants;
using System.Collections;

namespace WorldCupWindowsForms.UserControls
{
    public partial class PlayerUC : UserControl
    {
        public Player PlayerInUC { get; set; }

        private IPlayerMovable playerMovable;

        private string imagesFolderPath = $"{PathConstants.Player_Images}";

        public PlayerUC(Player player, IPlayerMovable playerMovable)
        {
            InitializeComponent();


            this.playerMovable = playerMovable;
            PlayerInUC = player;

            this.Name = PlayerInUC.Name;

            if (File.Exists(PathConstants.FavoritePlayers_WinFormApp))
            {
                using (ResourceSet reader = new ResXResourceSet(PathConstants.FavoritePlayers_WinFormApp))
                {
                    IDictionaryEnumerator dict = reader.GetEnumerator();
                    while(dict.MoveNext())
                        if (dict.Key.ToString() == PlayerInUC.Name)
                        {
                            PlayerInUC.Favorite = (bool)dict.Value;
                        }
                }
            }

            this.CheckFavorite();

            string imagePath = $"{imagesFolderPath}{PlayerInUC.Name}.jpg";

            if (File.Exists(imagePath))
            {
                imgPlayer.ImageLocation = imagePath;
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
                player.DoDragDrop(player, DragDropEffects.Move | DragDropEffects.None);
            }
        }
        //Multiple DnD

        private void imgPlayer_MouseClick(object sender, MouseEventArgs e)
        {
            OpenFileDialog imageDialog = new OpenFileDialog
            {
                Filter = "Slike|*.bmp;*.jpg;*.png|Sve datoteke|*.*",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
            };
            if (imageDialog.ShowDialog() == DialogResult.OK)
            {
                imgPlayer.Image = new Bitmap(imageDialog.FileName);
                imgPlayer.Image.Save($"{imagesFolderPath}{PlayerInUC.Name}.jpg");
            }
        }

        private void btnFavorite_Click(object sender, EventArgs e)
        {
            PlayerInUC.Favorite = !PlayerInUC.Favorite;
            playerMovable.MovePlayerControl(this);
        }

        public void CheckFavorite()
        {
            if (PlayerInUC.Favorite)
            {
                btnFavorite.Image = Properties.Resources.HeartsFIlledpng;
            }
            else btnFavorite.Image = Properties.Resources.Hearts_icon;
        }
    }
}
