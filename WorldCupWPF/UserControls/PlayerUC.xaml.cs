using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WorldCupWPF.UserControls
{
    /// <summary>
    /// Interaction logic for PlayerUC.xaml
    /// </summary>
    public partial class PlayerUC : UserControl
    {
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
            playerInfo.Show();
        }
    }
}
