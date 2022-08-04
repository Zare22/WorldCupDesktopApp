using DataLayer.Constants;
using DataLayer.Enums;
using DataLayer.Managers;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.IO;
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
using WorldCupWPF.UserControls;

namespace WorldCupWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private IList<TeamFromResults> teamsFromResults;
        private IList<Match> matches;
        private Match Match { get; set; }

        private TeamFromResults HomeTeam;
        private TeamFromResults AwayTeam;

        private readonly Manager manager = new Manager();

        public MainWindow()
        {
            if (!File.Exists(PathConstants.Settings))
            {
                ShowSettingsWindow();
            }
            InitializeComponent();
        }

        private void ShowSettingsWindow()
        {
            var settingsWindow = new Settings();
            settingsWindow.Show();
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            FillDdl();
        }

        private async void FillOpponents()
        {
            matches = await manager.GetAllMatches(HomeTeam.FifaCode);

            foreach (var m in matches)
            {
                if (m.HomeTeam.Code == HomeTeam.FifaCode)
                {
                    ddlOpponent.Items.Add(m.AwayTeam.ToString());
                }
                else
                    ddlOpponent.Items.Add(m.HomeTeam.ToString());
            }
        }

        private async void FillDdl()
        {
            
            teamsFromResults = await manager.GetAllTeams();
            teamsFromResults.ToList().ForEach(t => ddlTeams.Items.Add(t));
        }

        private void ddlTeams_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ddlOpponent.Items.Clear();
            lblResult.Content = string.Empty;
            SetTeam(ddlTeams);
            FillOpponents();
        }

        private void btnHomeTeam_Click(object sender, RoutedEventArgs e)
        {
            Window window = new TeamInfo(HomeTeam);
            window.ShowDialog();
        }

        private void btnAwayTeam_Click(object sender, RoutedEventArgs e)
        {
            Window window = new TeamInfo(AwayTeam);
            window.ShowDialog();
        }

        private void ddlOpponents_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SetTeam(ddlOpponent);
            SetResult();
            ClearFootballField();
            FillFieldWithPlayers();
        }

        private void ClearFootballField()
        {
            foreach (StackPanel stackPanel in footballFieldGrid.Children)
            {
                stackPanel.Children.Clear();
            }
        }

        private void FillFieldWithPlayers()
        {
            List<Player> startingElevenHome = new List<Player>();
            List<Player> startingElevenAway = new List<Player>();

            if (HomeTeam.FifaCode == Match.HomeTeam.Code)
            {
                startingElevenHome = Match.HomeTeamStatistics.StartingEleven.ToList();
                startingElevenAway = Match.AwayTeamStatistics.StartingEleven.ToList();
            }
            else
            {
                startingElevenHome = Match.AwayTeamStatistics.StartingEleven.ToList();
                startingElevenAway = Match.HomeTeamStatistics.StartingEleven.ToList();
            }

            foreach (var p in startingElevenHome)
            {
                PlayerUC playerUC = new PlayerUC(p, Match);
                switch (p.Position)
                {
                    case Position.Goalie:
                        pnlGoalkeeperHome.Children.Add(playerUC);
                        break;
                    case Position.Defender:
                        pnlDefendersHome.Children.Add(playerUC);
                        break;
                    case Position.Midfield:
                        pnlMidfieldersHome.Children.Add(playerUC);
                        break;
                    case Position.Forward:
                        pnlForwardsHome.Children.Add(playerUC);
                        break;
                }
            }
            foreach (var p in startingElevenAway)
            {
                PlayerUC playerUC = new PlayerUC(p, Match);
                switch (p.Position)
                {
                    case Position.Goalie:
                        pnlGoalkeeperAway.Children.Add(playerUC);
                        break;
                    case Position.Defender:
                        pnlDefendersAway.Children.Add(playerUC);
                        break;
                    case Position.Midfield:
                        pnlMidfieldersAway.Children.Add(playerUC);
                        break;
                    case Position.Forward:
                        pnlForwardsAway.Children.Add(playerUC);
                        break;
                }
            }
        }

        private void SetResult()
        {
            foreach (var m in matches)
            {
                if (m.AwayTeam.Code == AwayTeam.FifaCode)
                {
                    lblResult.Content = $"{m.HomeTeam.Goals} - {m.AwayTeam.Goals}";
                    Match = m;
                }
                else if (m.HomeTeam.Code == AwayTeam.FifaCode)
                {
                    lblResult.Content = $"{m.AwayTeam.Goals} - {m.HomeTeam.Goals}";
                    Match = m;
                }
            }
        }

        private void SetTeam(ComboBox ddl)
        {
            try
            {
                string team = ddl.SelectedItem.ToString();
                string fifaCode = team.Substring(team.LastIndexOf('(') + 1, 3);

                foreach (var t in teamsFromResults)
                {
                    if (t.FifaCode == fifaCode)
                    {
                        if (ddl.Name == "ddlTeams")
                        {
                            HomeTeam = t;
                        }
                        else
                        {
                            AwayTeam = t;
                        }
                    }
                }
            }
            catch (Exception)
            {
                return;
            }


        }

        private void btnPostavke_Click(object sender, RoutedEventArgs e)
        {
            Window settings = new Settings();
            settings.ShowDialog();
        }
    }
}
