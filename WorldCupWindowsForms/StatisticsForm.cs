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
        public IList<Match> Matches { get; set; }
        public ISet<Player> Players { get; set; }
        public StatisticsForm()
        {
            InitializeComponent();
        }

        private void StatisticsForm_Load(object sender, EventArgs e)
        {
            FillPlayersStats(playersStats, Players);
            FillMatchesStats(matchesStats, Matches);

        }

        private void FillMatchesStats(DataGridView playersStats, IList<Match> matches)
        {

        }

        private void FillPlayersStats(DataGridView playersStats, ISet<Player> players)
        {
            playersStats.Columns.Add("name", "Ime");
            playersStats.Columns.Add("goals", "Zabijeni golovi");
            playersStats.Columns.Add("yellows", "Žuti kartoni");

            foreach (var p in Players)
            {
                playersStats.Rows.Add(p.Name, p.GoalsScored, p.YellowCards);
            }
        }
    }
}
