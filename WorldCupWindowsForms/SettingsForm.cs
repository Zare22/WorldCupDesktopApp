using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorldCupWindowsForms
{
    public partial class SettingsForm : Form
    {
        public string Championship => GetChampionship();
        public bool Language => GetLanguage();


        private string GetChampionship() => rbMale.Checked ? "Men" : "Women";
        private bool GetLanguage() => rbCroatian.Checked ? true : false;


        public SettingsForm()
        {
            InitializeComponent();
            CheckForChampionshipType();
        }

        private void CheckForChampionshipType()
        {
            if (File.Exists("C:\\Users\\Leo\\source\\repos\\WorldCupDesktopApp\\WorldCupWindowsForms\\Resources\\Settings.resx"))
            {
                using (ResXResourceSet reader = new ResXResourceSet("C:\\Users\\Leo\\source\\repos\\WorldCupDesktopApp\\WorldCupWindowsForms\\Resources\\Settings.resx"))
                {
                    if (reader.GetString("Championship type") == "Men")
                    {
                        rbMale.Checked = true;
                    }
                    else rbFemale.Checked = true;
                }
            }
            else rbMale.Checked = true;
        }

        private void btnSaveSettings_Click(object sender, EventArgs e)
        {
            using (ResXResourceWriter writer = new ResXResourceWriter("C:\\Users\\Leo\\source\\repos\\WorldCupDesktopApp\\WorldCupWindowsForms\\Resources\\Settings.resx"))
            {
                writer.AddResource("Championship type", Championship);
                writer.AddResource("Language", Language.ToString());
            }
            Close();
        }
    }
}
