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
        private PlayersUC playerControl;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            FillDdl();
        }

        private void ddlTeams_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnlPlayers.Controls.Clear();
            FillPanelWithPlayersAsync();
        }

        private async void FillPanelWithPlayersAsync()
        {
            string team = ddlTeams.SelectedItem.ToString();
            string fifaCode = team.Substring(team.LastIndexOf('(') + 1, 3);

            var players = await manager.GetPlayers(fifaCode);

            players.ToList().ForEach(p => pnlPlayers.Controls.Add(playerControl = new PlayersUC(p)));
        }

        private async void FillDdl()
        {
            var teams = await manager.GetAllTeams();
            teams.ToList().ForEach(t => ddlTeams.Items.Add(t));
        }
    }
}