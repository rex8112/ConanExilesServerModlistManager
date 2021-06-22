
namespace ConanExilesModlistManager
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.appIDLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.GetInfoButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.urlLabel = new System.Windows.Forms.Label();
            this.modListView = new System.Windows.Forms.ListView();
            this.modLink = new System.Windows.Forms.LinkLabel();
            this.shiftUp = new System.Windows.Forms.Button();
            this.shiftDown = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.chooseInstallLocation = new System.Windows.Forms.Button();
            this.installConfirmLabel = new System.Windows.Forms.Label();
            this.loadFromCurrent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // appIDLabel
            // 
            this.appIDLabel.AutoSize = true;
            this.appIDLabel.Location = new System.Drawing.Point(14, 15);
            this.appIDLabel.Name = "appIDLabel";
            this.appIDLabel.Size = new System.Drawing.Size(40, 15);
            this.appIDLabel.TabIndex = 0;
            this.appIDLabel.Text = "AppID";
            this.appIDLabel.Click += new System.EventHandler(this.appIDLabel_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(72, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(284, 23);
            this.textBox1.TabIndex = 1;
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // GetInfoButton
            // 
            this.GetInfoButton.Location = new System.Drawing.Point(362, 12);
            this.GetInfoButton.Name = "GetInfoButton";
            this.GetInfoButton.Size = new System.Drawing.Size(75, 23);
            this.GetInfoButton.TabIndex = 2;
            this.GetInfoButton.Text = "Add Mod";
            this.GetInfoButton.UseVisualStyleBackColor = true;
            this.GetInfoButton.Click += new System.EventHandler(this.GetInfoButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(14, 75);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(32, 15);
            this.titleLabel.TabIndex = 3;
            this.titleLabel.Text = "Title:";
            // 
            // urlLabel
            // 
            this.urlLabel.AutoSize = true;
            this.urlLabel.Location = new System.Drawing.Point(14, 114);
            this.urlLabel.Name = "urlLabel";
            this.urlLabel.Size = new System.Drawing.Size(31, 15);
            this.urlLabel.TabIndex = 4;
            this.urlLabel.Text = "URL:";
            // 
            // modListView
            // 
            this.modListView.FullRowSelect = true;
            this.modListView.GridLines = true;
            this.modListView.HideSelection = false;
            this.modListView.Location = new System.Drawing.Point(14, 149);
            this.modListView.MultiSelect = false;
            this.modListView.Name = "modListView";
            this.modListView.Size = new System.Drawing.Size(423, 313);
            this.modListView.TabIndex = 5;
            this.modListView.UseCompatibleStateImageBehavior = false;
            // 
            // modLink
            // 
            this.modLink.AutoSize = true;
            this.modLink.Location = new System.Drawing.Point(52, 114);
            this.modLink.Name = "modLink";
            this.modLink.Size = new System.Drawing.Size(41, 15);
            this.modLink.TabIndex = 6;
            this.modLink.TabStop = true;
            this.modLink.Text = "empty";
            this.modLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.modLink_LinkClicked);
            // 
            // shiftUp
            // 
            this.shiftUp.Location = new System.Drawing.Point(443, 257);
            this.shiftUp.Name = "shiftUp";
            this.shiftUp.Size = new System.Drawing.Size(40, 40);
            this.shiftUp.TabIndex = 7;
            this.shiftUp.Text = "↑";
            this.shiftUp.UseVisualStyleBackColor = true;
            this.shiftUp.Click += new System.EventHandler(this.shiftUp_Click);
            // 
            // shiftDown
            // 
            this.shiftDown.Location = new System.Drawing.Point(443, 303);
            this.shiftDown.Name = "shiftDown";
            this.shiftDown.Size = new System.Drawing.Size(40, 40);
            this.shiftDown.TabIndex = 8;
            this.shiftDown.Text = "↓";
            this.shiftDown.UseVisualStyleBackColor = true;
            this.shiftDown.Click += new System.EventHandler(this.shiftDown_Click);
            // 
            // chooseInstallLocation
            // 
            this.chooseInstallLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chooseInstallLocation.Location = new System.Drawing.Point(806, 12);
            this.chooseInstallLocation.Name = "chooseInstallLocation";
            this.chooseInstallLocation.Size = new System.Drawing.Size(28, 23);
            this.chooseInstallLocation.TabIndex = 9;
            this.chooseInstallLocation.Text = "...";
            this.chooseInstallLocation.UseVisualStyleBackColor = true;
            this.chooseInstallLocation.Click += new System.EventHandler(this.chooseInstallLocation_Click);
            // 
            // installConfirmLabel
            // 
            this.installConfirmLabel.Location = new System.Drawing.Point(443, 38);
            this.installConfirmLabel.Name = "installConfirmLabel";
            this.installConfirmLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.installConfirmLabel.Size = new System.Drawing.Size(391, 52);
            this.installConfirmLabel.TabIndex = 10;
            this.installConfirmLabel.Text = "Conan Install Location Unset";
            this.installConfirmLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // loadFromCurrent
            // 
            this.loadFromCurrent.Enabled = false;
            this.loadFromCurrent.Location = new System.Drawing.Point(670, 149);
            this.loadFromCurrent.Name = "loadFromCurrent";
            this.loadFromCurrent.Size = new System.Drawing.Size(164, 23);
            this.loadFromCurrent.TabIndex = 11;
            this.loadFromCurrent.Text = "Load from Current Modlist";
            this.loadFromCurrent.UseVisualStyleBackColor = true;
            this.loadFromCurrent.Click += new System.EventHandler(this.loadFromCurrent_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 474);
            this.Controls.Add(this.loadFromCurrent);
            this.Controls.Add(this.installConfirmLabel);
            this.Controls.Add(this.chooseInstallLocation);
            this.Controls.Add(this.shiftDown);
            this.Controls.Add(this.shiftUp);
            this.Controls.Add(this.modLink);
            this.Controls.Add(this.modListView);
            this.Controls.Add(this.urlLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.GetInfoButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.appIDLabel);
            this.MinimumSize = new System.Drawing.Size(500, 300);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label appIDLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button GetInfoButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label urlLabel;
        private System.Windows.Forms.ListView modListView;
        private System.Windows.Forms.LinkLabel modLink;
        private System.Windows.Forms.Button shiftUp;
        private System.Windows.Forms.Button shiftDown;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button chooseInstallLocation;
        private System.Windows.Forms.Label installConfirmLabel;
        private System.Windows.Forms.Button loadFromCurrent;
    }
}

