using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace ConanExilesModlistManager
{
    public partial class Form1 : Form
    {
        List<ConanMod> mods = new List<ConanMod>();
        private bool _installLocationSet = false;
        private string modlistLocation = "";
        public bool InstallLocationSet
        {
            set
            {
                _installLocationSet = value;
                loadFromCurrent.Enabled = value;
            }
            get
            {
                return _installLocationSet;
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ColumnHeader header = new ColumnHeader();
            header.Text = "Mod Load Order";
            header.Name = "col1";
            header.Width = modListView.Width - 10;
            modLink.Text = "";
            modListView.Columns.Add(header);

            modListView.View = View.Details;

            if (Properties.Settings.Default.InstallLocation != "")
            {
                installConfirmLabel.Text = Properties.Settings.Default.InstallLocation;
                InstallLocationSet = true;
                FillLocations();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Click(object send, EventArgs e)
        {
            textBox1.SelectAll();
            //textBox1.Focus();
        }

        private void appIDLabel_Click(object sender, EventArgs e)
        {

        }

        private void GetInfoButton_Click(object sender, EventArgs e)
        {
            long appID;

            string text = textBox1.Text.Replace(ConanMod.WORKSHOP_TEMPLATE, "");
            bool isNum = long.TryParse(text, out appID);

            if (isNum)
            {
                ConanMod mod = new ConanMod(appID);
                titleLabel.Text = "Title: " + mod.title;
                modLink.Text = mod.url;

                if (!mods.Contains(mod))
                {
                    mods.Add(mod);
                    modListView.Items.Add(mod.appID.ToString() + " - " + mod.title);
                }
            }
        }

        private void modLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                VisitLink();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void VisitLink()
        {
            System.Diagnostics.Process.Start(modLink.Text);
        }

        private void shiftUp_Click(object sender, EventArgs e)
        {
            int index = modListView.SelectedIndices[0];
            if (index > 0)
            {
                int newIndex = index - 1;
                ShiftModOrder(index, newIndex);
            }
            modListView.Focus();
        }

        private void shiftDown_Click(object sender, EventArgs e)
        {
            int index = modListView.SelectedIndices[0];
            if (index < mods.Count - 1)
            {
                int newIndex = index + 1;
                ShiftModOrder(index, newIndex);
            }
            modListView.Focus();
        }

        private void chooseInstallLocation_Click(object sender, EventArgs e)
        {
            var locationSetter = new LocationForm();
            locationSetter.Show();
        }

        private void loadFromCurrent_Click(object sender, EventArgs e)
        {
            if (File.Exists(modlistLocation))
            {
                mods.Clear();
                modListView.Items.Clear();
                List<int> appIDs = new List<int>();
                string location = Properties.Settings.Default.InstallLocation.Replace("common\\Conan Exiles", "workshop\\content\\440900\\");
                string content = File.ReadAllText(modlistLocation);
                content = content.Replace("*" + location, "");
                string[] lines = content.Split("\n");
                foreach (string line in lines)
                {
                    int id;
                    string idString = line.Split("/")[0];
                    bool result = int.TryParse(idString, out id);
                    if (result)
                        appIDs.Add(id);
                }
                foreach (int id in appIDs)
                {
                    ConanMod mod = new ConanMod(id);

                    if (!mods.Contains(mod))
                    {
                        mods.Add(mod);
                        modListView.Items.Add(mod.appID.ToString() + " - " + mod.title);
                    }
                }
            }
        }

        private void ShiftModOrder(int index, int newIndex)
        {
            ConanMod modToChange = mods[index];
            ListViewItem listingToChange = modListView.Items[index];
            mods.Remove(modToChange);
            modListView.Items.Remove(listingToChange);

            mods.Insert(newIndex, modToChange);
            modListView.Items.Insert(newIndex, listingToChange);

            modListView.SelectedItems.Clear();
            modListView.Items[newIndex].Selected = true;
        }

        private void FillLocations()
        {
            string installLocation = Properties.Settings.Default.InstallLocation;
            modlistLocation = installLocation + "/ConanSandbox/Mods/modlist.txt";
        }
    }
}
