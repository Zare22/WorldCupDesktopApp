using DataLayer.Constants;
using DataLayer.Exceptions;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace WorldCupWindowsForms
{
    public partial class StatisticsForm : Form
    {
        private IList<Match> Matches { get; set; }
        private ISet<Player> Players { get; set; }

        private string savedImage = PathConstants.Player_Images;
        private string defaultImage = PathConstants.FootbalPlayerImage;

        public StatisticsForm(IList<Match> matches, ISet<Player> players)
        {
            InitializeComponent();
            Matches = matches;
            Players = players;
        }

        private void StatisticsForm_Load(object sender, EventArgs e)
        {
            try
            {
                FillPlayersStats();
                FillMatchesStats();
            }
            catch (Exception)
            {
                MyException.ShowMessage(Resources.Messages.settingsMessage);
                return;
            }

        }

        private void FillMatchesStats()
        {
            matchesStats.Columns.Add("location", Resources.DataGridLabels.location);
            matchesStats.Columns.Add("attendance", Resources.DataGridLabels.attendance);
            matchesStats.Columns.Add("homeTeam", Resources.DataGridLabels.homeTeam);
            matchesStats.Columns.Add("awayTeam", Resources.DataGridLabels.awayTeam);

            Matches.ToList().ForEach(m => matchesStats.Rows.Add(m.Location, m.Attendance, m.HomeTeam.Country, m.AwayTeam.Country));
        }

        private void FillPlayersStats()
        {
            DataGridViewImageColumn playerImage = new DataGridViewImageColumn
            {
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
                ImageLayout = DataGridViewImageCellLayout.Zoom,
                DataPropertyName = "playerImage",
                Visible = true,
                Name = "playerImage",
                HeaderText = Resources.DataGridLabels.picture
            };


            playersStats.Columns.Add(playerImage);
            playersStats.Columns.Add("name", Resources.DataGridLabels.name);
            playersStats.Columns.Add("goals", Resources.DataGridLabels.goals);
            playersStats.Columns.Add("yellows", Resources.DataGridLabels.yellowCards);

            foreach (var p in Players)
            {
                try
                {
                    if (File.Exists($"{savedImage}{p.Name}.jpg"))
                    {
                        playersStats.Rows.Add(
                            Image.FromFile($"{savedImage}{p.Name}.jpg"),
                            p.Name,
                            p.GoalsScored,
                            p.YellowCards);
                    }
                    else
                    {
                        playersStats.Rows.Add(
                                Image.FromFile($"{defaultImage}"),
                                p.Name,
                                p.GoalsScored,
                                p.YellowCards);
                    }
                }
                catch (Exception)
                {
                    MyException.ShowMessage(Resources.Messages.fileException);
                    return;
                }
            }

        }

        private void btnPrint_Click(object sender, EventArgs e) => printPreviewDialog.ShowDialog();

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bitmapMatches = new Bitmap(matchesStats.Width, matchesStats.Height);
            matchesStats.DrawToBitmap(bitmapMatches, new Rectangle(0, 0, matchesStats.Width, matchesStats.Height));
            e.Graphics.DrawImage(bitmapMatches, 0, 0);

            Bitmap bitmapPlayers = new Bitmap(playersStats.Width, playersStats.Height);
            playersStats.DrawToBitmap(bitmapPlayers, new Rectangle(0, 0, playersStats.Width, playersStats.Height));
            e.Graphics.DrawImage(bitmapPlayers, 0, 250);
        }
    }
}
