using DataLayer.Constants;
using DataLayer.Exceptions;
using DataLayer.Models;
using System;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Imaging;

namespace WorldCupWPF.UserControls
{
    public partial class PlayerUC : UserControl
    {
        private string imagesFolderPath = $"{PathConstants.Player_Images}";
        internal Player PlayerInUC { get; set; }
        internal Match SelectedMatch { get; set; }

        internal int GoalsScored { get; set; }
        internal int YellowCards { get; set; }
        public PlayerUC(Player playerInUC, Match match)
        {
            InitializeComponent();
            PlayerInUC = playerInUC;
            SelectedMatch = match;
        }

        private void PlayUC_Loaded(object sender, RoutedEventArgs e)
        {
            SetGoalsAndYellows();
            lblNumber.Content = PlayerInUC.ShirtNumber;
            lblPlayerName.Content = PlayerInUC.Name;
            string imagePath = $"{imagesFolderPath}{PlayerInUC.Name}.jpg";
            try
            {
                if (File.Exists(imagePath))
                {
                    imgPlayer.Source = new BitmapImage(new Uri(imagePath));
                }
                else
                    imgPlayer.Source = new BitmapImage(new Uri(PathConstants.FootbalPlayerImage));
            }
            catch (Exception)
            {
                MyException.ShowMessage($"{Properties.Resources.exceptionFile}");
            }
        }

        private void SetGoalsAndYellows()
        {
            var events = SelectedMatch.HomeTeamEvents.Concat(SelectedMatch.AwayTeamEvents);
            foreach (var e in events)
            {
                if (e.TypeOfEvent == DataLayer.Enums.TypeOfEvent.Goal && e.Player.ToLower() == PlayerInUC.Name.ToLower())
                {
                    GoalsScored++;
                }
                
                if (e.TypeOfEvent == DataLayer.Enums.TypeOfEvent.YellowCard && e.Player.ToLower() == PlayerInUC.Name.ToLower())
                {
                    YellowCards++;
                }
            }
        }

        private void PlayerUC_Click(object sender, MouseButtonEventArgs e)
        {
            Window playerInfo = new PlayerInfo(this);
            playerInfo.ShowDialog();
        }
    }
}
