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
using DataLayer.Managers;

namespace WorldCupWindowsForms.UserControls
{
    public partial class PlayerUC : UserControl
    {
        private readonly SettingsManager settingsManager = new SettingsManager();
        public Player PlayerInUC { get; set; }

        private IPlayerMovable playerMovable;

        private string imagesFolderPath = $"{PathConstants.Player_Images}";

        private static IList<PlayerUC> dndList = new List<PlayerUC>();

        public PlayerUC(Player player, IPlayerMovable playerMovable)
        {
            InitializeComponent();


            this.playerMovable = playerMovable;
            PlayerInUC = player;

            this.Name = PlayerInUC.Name;


            settingsManager.CheckFavoritePlayer(player);

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
            object data = dndList.Count == 0 ? new List<PlayerUC> { this } : dndList;

            if (e.Button == MouseButtons.Left)
            {
                if (sender is PlayerUC puc)
                {
                    puc.DoDragDrop(data, DragDropEffects.Move);
                }
            }

            if (e.Button == MouseButtons.Left && (ModifierKeys & Keys.Control) == Keys.Control)
            {
                if (!(BackColor == Color.AliceBlue) && dndList.Count < 3)
                {
                    BackColor = Color.AliceBlue;
                    dndList.Add(this);
                }
                else if (!(BackColor == DefaultBackColor))
                {
                    BackColor = DefaultBackColor;
                    dndList.Remove(this);
                }
            }
        }

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
