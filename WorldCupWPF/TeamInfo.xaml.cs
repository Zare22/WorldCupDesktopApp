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
using System.Windows.Shapes;

namespace WorldCupWPF
{
    /// <summary>
    /// Interaction logic for TeamInfo.xaml
    /// </summary>
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
