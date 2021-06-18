using System;
using System.Windows.Forms;

namespace ConanExilesModlistManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ColumnHeader header = new ColumnHeader();
            header.Text = "Mod Load Order";
            header.Name = "col1";
            header.Width = modListView.Width;
            modListView.Columns.Add(header);

            modListView.View = View.Details;
            modListView.Items.Add("Test 1");
            modListView.Items.Add("Test 2");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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
                urlLabel.Text = "URL: " + mod.url;
            }
        }
    }
}
