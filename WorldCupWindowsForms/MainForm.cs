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

namespace WorldCupWindowsForms
{
    public partial class MainForm : Form
    {
        private readonly Manager manager = new Manager();
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            FillDdl();
        }

        private async void ddlTeams_SelectedIndexChangedAsync(object sender, EventArgs e)
        {
            lbPlayers.Items.Clear();
            pnlPlayers.Controls.Clear();

            string team = ddlTeams.SelectedItem.ToString();
            string fifaCode = team.Substring(team.LastIndexOf('(') + 1, 3);

            var players = await manager.GetPlayers(fifaCode);
            var sortedPlayers = new SortedSet<Player>(players).OrderByDescending(p => p.GoalsScored);

            foreach (var p in sortedPlayers)
            {
                lbPlayers.Items.Add($"{p.Name} - {p.GoalsScored}");
            }
            foreach (var p in players)
            {
                var playerControl = new PlayersUC(p);
                pnlPlayers.Controls.Add(playerControl);
            }
        }

        private async void FillDdl()
        {
            var teams = await manager.GetAllTeams();
            foreach (var t in teams)
            {
                ddlTeams.Items.Add(t);
            }
        }
    }
}