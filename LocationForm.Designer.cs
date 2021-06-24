
namespace ConanExilesModlistManager
{
    partial class LocationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainLocationLabel = new System.Windows.Forms.Label();
            this.modlistLocation = new System.Windows.Forms.Label();
            this.mainLocationTextbox = new System.Windows.Forms.TextBox();
            this.modlistLocationTextbox = new System.Windows.Forms.TextBox();
            this.mainInstallButton = new System.Windows.Forms.Button();
            this.modlistLocationButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // mainLocationLabel
            // 
            this.mainLocationLabel.AutoSize = true;
            this.mainLocationLabel.Location = new System.Drawing.Point(12, 27);
            this.mainLocationLabel.Name = "mainLocationLabel";
            this.mainLocationLabel.Size = new System.Drawing.Size(123, 15);
            this.mainLocationLabel.TabIndex = 0;
            this.mainLocationLabel.Text = "Conan Exiles Location";
            // 
            // modlistLocation
            // 
            this.modlistLocation.AutoSize = true;
            this.modlistLocation.Location = new System.Drawing.Point(12, 61);
            this.modlistLocation.Name = "modlistLocation";
            this.modlistLocation.Size = new System.Drawing.Size(113, 15);
            this.modlistLocation.TabIndex = 1;
            this.modlistLocation.Text = "modlist.txt Location";
            // 
            // mainLocationTextbox
            // 
            this.mainLocationTextbox.Location = new System.Drawing.Point(142, 24);
            this.mainLocationTextbox.Name = "mainLocationTextbox";
            this.mainLocationTextbox.Size = new System.Drawing.Size(265, 23);
            this.mainLocationTextbox.TabIndex = 2;
            // 
            // modlistLocationTextbox
            // 
            this.modlistLocationTextbox.Location = new System.Drawing.Point(142, 58);
            this.modlistLocationTextbox.Name = "modlistLocationTextbox";
            this.modlistLocationTextbox.Size = new System.Drawing.Size(265, 23);
            this.modlistLocationTextbox.TabIndex = 3;
            // 
            // mainInstallButton
            // 
            this.mainInstallButton.Location = new System.Drawing.Point(413, 24);
            this.mainInstallButton.Name = "mainInstallButton";
            this.mainInstallButton.Size = new System.Drawing.Size(24, 23);
            this.mainInstallButton.TabIndex = 4;
            this.mainInstallButton.Text = "...";
            this.mainInstallButton.UseVisualStyleBackColor = true;
            this.mainInstallButton.Click += new System.EventHandler(this.mainInstallButton_Click);
            // 
            // modlistLocationButton
            // 
            this.modlistLocationButton.Location = new System.Drawing.Point(413, 58);
            this.modlistLocationButton.Name = "modlistLocationButton";
            this.modlistLocationButton.Size = new System.Drawing.Size(24, 23);
            this.modlistLocationButton.TabIndex = 5;
            this.modlistLocationButton.Text = "...";
            this.modlistLocationButton.UseVisualStyleBackColor = true;
            this.modlistLocationButton.Click += new System.EventHandler(this.modlistLocationButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(190, 102);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 6;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "txt";
            this.openFileDialog1.FileName = "modlist.txt";
            // 
            // LocationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 137);
            this.ControlBox = false;
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.modlistLocationButton);
            this.Controls.Add(this.mainInstallButton);
            this.Controls.Add(this.modlistLocationTextbox);
            this.Controls.Add(this.mainLocationTextbox);
            this.Controls.Add(this.modlistLocation);
            this.Controls.Add(this.mainLocationLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LocationForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.LocationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mainLocationLabel;
        private System.Windows.Forms.Label modlistLocation;
        private System.Windows.Forms.TextBox mainLocationTextbox;
        private System.Windows.Forms.TextBox modlistLocationTextbox;
        private System.Windows.Forms.Button mainInstallButton;
        private System.Windows.Forms.Button modlistLocationButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}