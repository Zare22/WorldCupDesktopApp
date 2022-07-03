using DataLayer.Constants;
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
using System.Xml.Linq;
using WorldCupWindowsForms.Protocols;

namespace WorldCupWindowsForms
{
    public partial class SettingsForm : Form
    {
        public string Championship => GetChampionship();
        public string Language => GetLanguage();


        private string GetChampionship() => rbMale.Checked ? "Men" : "Women";
        private string GetLanguage() => rbCroatian.Checked ? "hr" : "en";


        public SettingsForm()
        {
            InitializeComponent();

            CheckForChampionshipType();
            CheckForLanguage();
        }

        //relative
        private void CheckForLanguage()
        {
            if (File.Exists($"{PathConstants.Settings_WinFormApp}"))
            {
                using (ResXResourceSet reader = new ResXResourceSet($"{PathConstants.Settings_WinFormApp}"))
                {
                    if (reader.GetString("Language") == "hr")
                    {
                        rbCroatian.Checked = true;
                    }
                    else rbEnglish.Checked = true;
                }
            }
        }

        private void CheckForChampionshipType()
        {
            if (File.Exists($"{PathConstants.Settings_WinFormApp}"))
            {
                using (ResXResourceSet reader = new ResXResourceSet($"{PathConstants.Settings_WinFormApp}"))
                {
                    if (reader.GetString("Championship type") == "Men")
                    {
                        rbMale.Checked = true;
                    }
                    else rbFemale.Checked = true;
                }
            }
        }

        private void btnSaveSettings_Click(object sender, EventArgs e)
        {
            using (ResXResourceWriter writer = new ResXResourceWriter($"{PathConstants.Settings_WinFormApp}"))
            {
                writer.AddResource("Championship type", Championship);
                writer.AddResource("Language", Language);
            }
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
