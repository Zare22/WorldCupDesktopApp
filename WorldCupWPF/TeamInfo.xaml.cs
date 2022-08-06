using DataLayer.Models;
using System.Windows;

namespace WorldCupWPF
{
    public partial class TeamInfo : Window
    {
        public TeamFromResults SelectedTeam { get; set; }

        public TeamInfo(TeamFromResults team)
        {
            InitializeComponent();
            SelectedTeam = team;
        }

        private void TeamInfo_Loaded(object sender, RoutedEventArgs e)
        {
            country.Content = SelectedTeam.Country;
            fifaCode.Content = SelectedTeam.FifaCode;
            gamesPlayed.Content = SelectedTeam.GamesPlayed;
            wins.Content = SelectedTeam.Wins;
            losses.Content = SelectedTeam.Losses;
            draws.Content = SelectedTeam.Draws;
            goalsFor.Content = SelectedTeam.GoalsFor;
            goalsAgainst.Content = SelectedTeam.GoalsAgainst;
            goalDifferential.Content = SelectedTeam.GoalDifferential;
        }
    }
}
