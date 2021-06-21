using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ConanExilesModlistManager
{
    public partial class Form1 : Form
    {
        List<ConanMod> mods = new List<ConanMod>();
        bool installLocationSet = false;
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
                installLocationSet = true;
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
                shiftModOrder(index, newIndex);
            }
        }

        private void shiftDown_Click(object sender, EventArgs e)
        {
            int index = modListView.SelectedIndices[0];
            if (index < mods.Count - 1)
            {
                int newIndex = index + 1;
                shiftModOrder(index, newIndex);
            }
        }

        private void shiftModOrder(int index, int newIndex)
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

        private void chooseInstallLocation_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                Properties.Settings.Default.InstallLocation = folderBrowserDialog1.SelectedPath;
                Properties.Settings.Default.Save();
                installConfirmLabel.Text = folderBrowserDialog1.SelectedPath;
                installLocationSet = true;
            }
        }
    }
}
