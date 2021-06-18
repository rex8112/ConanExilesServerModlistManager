
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
            this.textBox1.Size = new System.Drawing.Size(157, 23);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // GetInfoButton
            // 
            this.GetInfoButton.Location = new System.Drawing.Point(235, 12);
            this.GetInfoButton.Name = "GetInfoButton";
            this.GetInfoButton.Size = new System.Drawing.Size(75, 23);
            this.GetInfoButton.TabIndex = 2;
            this.GetInfoButton.Text = "Get Info";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 474);
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
    }
}

