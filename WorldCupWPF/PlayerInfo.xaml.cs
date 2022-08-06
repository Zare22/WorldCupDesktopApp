using DataLayer.Constants;
using DataLayer.Exceptions;
using System;
using System.IO;
using System.Windows;
using System.Windows.Media.Imaging;
using WorldCupWPF.UserControls;

namespace WorldCupWPF
{
    public partial class PlayerInfo : Window
    {
        private PlayerUC PlayerUC { get; set; }
        private string imagesFolderPath = $"{PathConstants.Player_Images}";

        public PlayerInfo(PlayerUC player)
        {
            InitializeComponent();
            PlayerUC = player;
        }

        private void PlayerInfo_Loaded(object sender, RoutedEventArgs e)
        {
            string imagePath = $"{imagesFolderPath}{PlayerUC.PlayerInUC.Name}.jpg";
            try
            {
                if (File.Exists(imagePath))
                {
                    playerImg.Source = new BitmapImage(new Uri(imagePath));
                }
                else
                    playerImg.Source = new BitmapImage(new Uri(PathConstants.FootbalPlayerImage));
            }
            catch (Exception)
            {
                MyException.ShowMessage(Properties.Resources.exceptionFile);
                return;
            }
            lblName.Content = PlayerUC.PlayerInUC.Name;
            lblNumber.Content = PlayerUC.PlayerInUC.ShirtNumber;
            lblCaptain.Content = PlayerUC.PlayerInUC.IsCaptain ? "Captain" : "";
            lblPosition.Content = PlayerUC.PlayerInUC.Position;

            lblGoalsScored.Content = PlayerUC.GoalsScored;
            lblYellowCards.Content = PlayerUC.YellowCards;
        }
    }
}
