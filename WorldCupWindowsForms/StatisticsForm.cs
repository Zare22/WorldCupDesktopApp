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

namespace WorldCupWindowsForms
{
    public partial class StatisticsForm : Form
    {
        private IList<Match> matches;
        private ISet<Player> players;
        public StatisticsForm(IList<Match> matchesFromMain, ISet<Player> playersFromMain)
        {
            InitializeComponent();
            LoadData(matchesFromMain, playersFromMain);
        }

        private void LoadData(IList<Match> matchesFromMain, ISet<Player> playersFromMain)
        {
            matches = matchesFromMain;
            players = playersFromMain;
        }

        private void StatisticsForm_Load(object sender, EventArgs e)
        {
            playersStats.Columns.Add("name", "Ime");
            playersStats.Columns.Add("goals", "Zabijeni golovi");
            playersStats.Columns.Add("yellows", "Žuti kartoni");

            foreach (var p in players)
            {
                playersStats.Rows.Add(p.Name, p.GoalsScored, p.YellowCards);
            }
        }
    }
}
