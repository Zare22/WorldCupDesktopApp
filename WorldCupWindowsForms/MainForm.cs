using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer.Models;
using DataLayer.Constants;
using DataLayer.JsonHandling;
using DataLayer.Repository;
using DataLayer.Managers;
using WorldCupWindowsForms.UserControls;
using System.Net.NetworkInformation;

namespace WorldCupWindowsForms
{
    public partial class MainForm : Form
    {
        private readonly Manager manager = new Manager();
        private PlayerUC playerControl;

        private ISet<Player> players;
        private IList<Match> matches;
        

        public MainForm() => InitializeComponent();

        private void MainForm_Load(object sender, EventArgs e) => FillDdl();


        //Main Form Work
        private async void FillDdl()
        {
            var teams = await manager.GetAllTeams();
            teams.ToList().ForEach(t => ddlTeams.Items.Add(t));
        }

        private void ddlTeams_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnlPlayers.Controls.Clear();
            FillPanelWithPlayers();
        }

        private async void FillPanelWithPlayers()
        {
            string team = ddlTeams.SelectedItem.ToString();
            string fifaCode = team.Substring(team.LastIndexOf('(') + 1, 3);

            players = await manager.GetPlayers(fifaCode);
            
            players.ToList().ForEach(p => pnlPlayers.Controls.Add(playerControl = new PlayerUC(p)));
        }


        //Statistics form call
        private async void btnOpenStatisticsForm_Click(object sender, EventArgs e)
        {
            try
            {
                string team = ddlTeams.SelectedItem.ToString();
                string fifaCode = team.Substring(team.LastIndexOf('(') + 1, 3);

                matches = await manager.GetAllMatches(fifaCode);
            }
            catch (Exception)
            {
                ShowMessage("Niste odabrali reprezentaciju");
                return;
            }

            StatisticsForm statisticsForm = new StatisticsForm();
            statisticsForm.Matches = matches;
            statisticsForm.Players = players;
            statisticsForm.ShowDialog();
        }


        //Drag and drop
        private void Panels_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(PlayerUC)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
                e.Effect = DragDropEffects.None;
        }

        private void pnlFavoritePlayers_DragDrop(object sender, DragEventArgs e)
        {
            var player = (PlayerUC)e.Data.GetData(typeof(PlayerUC));
            pnlFavoritePlayers.Controls.Add(player);
        }

        private void pnlPlayers_DragDrop(object sender, DragEventArgs e)
        {
            var player = (PlayerUC)e.Data.GetData(typeof(PlayerUC));
            pnlPlayers.Controls.Add(player);
        }

        //Exception message
        private static void ShowMessage(string message)
        {
            MessageBox.Show(message);
            return;
        }
    }
}