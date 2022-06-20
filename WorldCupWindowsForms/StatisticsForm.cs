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
            FillPlayersStats();
            FillMatchesStats();

        }

        private void FillMatchesStats()
        {
            matchesStats.Columns.Add("location", "Lokacija");
            matchesStats.Columns.Add("attendance", "Broj posjetitelja");
            matchesStats.Columns.Add("homeTeam", "Domaćin");
            matchesStats.Columns.Add("awayTeam", "Gost");

            Matches.ToList().ForEach(m => matchesStats.Rows.Add(m.Location, m.Attendance, m.HomeTeam.Country, m.AwayTeam.Country));
        }

        private void FillPlayersStats()
        {
            playersStats.Columns.Add("name", "Ime");
            playersStats.Columns.Add("goals", "Zabijeni golovi");
            playersStats.Columns.Add("yellows", "Žuti kartoni");

            Players.ToList().ForEach(p => playersStats.Rows.Add(p.Name, p.GoalsScored, p.YellowCards));

        }
    }
}
