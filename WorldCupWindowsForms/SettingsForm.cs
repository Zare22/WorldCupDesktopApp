using DataLayer.Constants;
using DataLayer.Exceptions;
using DataLayer.Managers;
using System;
using System.IO;
using System.Windows.Forms;

namespace WorldCupWindowsForms
{

    public partial class SettingsForm : Form
    {
        private readonly SettingsManager settingsManager = new SettingsManager();
        private MainForm MainForm;

        private string Championship => GetChampionship();
        private string Language => GetLanguage();

        private string GetChampionship() => rbMale.Checked ? "Men" : "Women";
        private string GetLanguage() => rbCroatian.Checked ? "hr" : "en";

        public SettingsForm(MainForm mainForm)
        {
            InitializeComponent();
            MainForm = mainForm;
            this.AcceptButton = btnSaveSettings;
            this.CancelButton = btnCancel;
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
                    if (settingsManager.CheckForLanguage())
                    {
                        rbCroatian.Checked = true;
                    }
                    else
                        rbEnglish.Checked = true;
                }
            }
            catch (Exception)
            {
                MyException.ShowMessage(Resources.Messages.settingsMessage);
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
                    if (settingsManager.CheckForChampionshipType())
                    {
                        rbMale.Checked = true;
                    }
                    else
                        rbFemale.Checked = true;
                }
            }
            catch (Exception)
            {
                MyException.ShowMessage(Resources.Messages.settingsMessage);
                return;
            }
        }

        public void SaveSettingsToResources() => settingsManager.SaveSettingsToResources(Championship, Language);

        private void btnSaveSettings_Click(object sender, EventArgs e)
        {
            if (rbMale.Checked == false && rbFemale.Checked == false)
            {
                MessageBox.Show(Resources.Messages.settingsChooseChamp);
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
