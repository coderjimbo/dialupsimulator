namespace DialUpSimulator
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.ok_button = new System.Windows.Forms.Button();
            this.icon = new System.Windows.Forms.PictureBox();
            this.appTitle_label = new System.Windows.Forms.Label();
            this.createdby_label = new System.Windows.Forms.Label();
            this.github_link = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
            this.SuspendLayout();
            // 
            // ok_button
            // 
            this.ok_button.Location = new System.Drawing.Point(297, 12);
            this.ok_button.Name = "ok_button";
            this.ok_button.Size = new System.Drawing.Size(75, 23);
            this.ok_button.TabIndex = 0;
            this.ok_button.Text = "&OK";
            this.ok_button.UseVisualStyleBackColor = true;
            this.ok_button.Click += new System.EventHandler(this.ok_button_Click);
            // 
            // icon
            // 
            this.icon.Image = global::DialUpSimulator.Properties.Resources.icon;
            this.icon.Location = new System.Drawing.Point(12, 12);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(32, 32);
            this.icon.TabIndex = 1;
            this.icon.TabStop = false;
            // 
            // appTitle_label
            // 
            this.appTitle_label.AutoSize = true;
            this.appTitle_label.Location = new System.Drawing.Point(90, 12);
            this.appTitle_label.Name = "appTitle_label";
            this.appTitle_label.Size = new System.Drawing.Size(106, 13);
            this.appTitle_label.TabIndex = 2;
            this.appTitle_label.Text = "Dial-Up Simulator 1.0";
            // 
            // createdby_label
            // 
            this.createdby_label.AutoSize = true;
            this.createdby_label.Location = new System.Drawing.Point(90, 47);
            this.createdby_label.Name = "createdby_label";
            this.createdby_label.Size = new System.Drawing.Size(140, 13);
            this.createdby_label.TabIndex = 3;
            this.createdby_label.Text = "Programmed by James Keith";
            // 
            // github_link
            // 
            this.github_link.AutoSize = true;
            this.github_link.Location = new System.Drawing.Point(90, 109);
            this.github_link.Name = "github_link";
            this.github_link.Size = new System.Drawing.Size(40, 13);
            this.github_link.TabIndex = 4;
            this.github_link.TabStop = true;
            this.github_link.Text = "GitHub";
            this.github_link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.github_link_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Sounds from Freesound.org";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Graphics from Microsoft";
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 140);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.github_link);
            this.Controls.Add(this.createdby_label);
            this.Controls.Add(this.appTitle_label);
            this.Controls.Add(this.icon);
            this.Controls.Add(this.ok_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About Dial-Up Simulator";
            ((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ok_button;
        private System.Windows.Forms.PictureBox icon;
        private System.Windows.Forms.Label appTitle_label;
        private System.Windows.Forms.Label createdby_label;
        private System.Windows.Forms.LinkLabel github_link;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}