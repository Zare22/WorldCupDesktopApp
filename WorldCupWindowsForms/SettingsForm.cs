using DataLayer.Constants;
using DataLayer.Exceptions;
using DataLayer.Managers;
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
        private readonly SettingsManager resourceManager = new SettingsManager();
        private MainForm MainForm;

        private string Championship => GetChampionship();
        private string Language => GetLanguage();

        private string GetChampionship() => rbMale.Checked ? "Men" : "Women";
        private string GetLanguage() => rbCroatian.Checked ? "hr" : "en";


        public SettingsForm(MainForm mainForm)
        {
            InitializeComponent();
            MainForm = mainForm;
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            CheckForLanguage();
            CheckForChampionshipType();
        }


        private void CheckForLanguage()
        {
            try
            {
                if (!File.Exists($"{PathConstants.Settings}"))
                {
                    rbCroatian.Checked = true;
                    rbEnglish.Checked = false;
                }
                else
                {
                    if (resourceManager.CheckForLanguage())
                    {
                        rbCroatian.Checked = true;
                    }
                    else
                        rbEnglish.Checked = true;
                }
            }
            catch (Exception)
            {
                MyException.ShowMessage("Došlo je do pogreške sa postavkama");
                return;
            }

        }

        private void CheckForChampionshipType()
        {
            try
            {
                if (!File.Exists($"{PathConstants.Settings}"))
                {
                    rbMale.Checked = false;
                    rbFemale.Checked = false;
                }
                else
                {
                    if (resourceManager.CheckForChampionshipType())
                    {
                        rbMale.Checked = true;
                    }
                    else
                        rbFemale.Checked = true;
                }
            }
            catch (Exception)
            {
                MyException.ShowMessage("Došlo je do pogreške sa postavkama");
                return;
            }
        }

        public void SaveSettingsToResources() => resourceManager.SaveSettingsToResources(Championship, Language);

        private void btnSaveSettings_Click(object sender, EventArgs e)
        {
            if (rbMale.Checked == false && rbFemale.Checked == false)
            {
                MessageBox.Show("Niste odabrali reprezentaciju!");
                return;
            }
            else
            {
                SaveSettingsToResources();
                MainForm.SetForm();
                Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
