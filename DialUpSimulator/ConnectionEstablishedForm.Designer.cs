namespace DialUpSimulator
{
    partial class ConnectionEstablishedForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConnectionEstablishedForm));
            this.connectedTo_Label = new System.Windows.Forms.Label();
            this.description_label_1 = new System.Windows.Forms.Label();
            this.description_label_2 = new System.Windows.Forms.Label();
            this.doNotShow_Checkbox = new System.Windows.Forms.CheckBox();
            this.moreInfo_button = new System.Windows.Forms.Button();
            this.close_button = new System.Windows.Forms.Button();
            this.taskbar_image = new System.Windows.Forms.PictureBox();
            this.dialup_icon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.taskbar_image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dialup_icon)).BeginInit();
            this.SuspendLayout();
            // 
            // connectedTo_Label
            // 
            this.connectedTo_Label.AutoSize = true;
            this.connectedTo_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectedTo_Label.Location = new System.Drawing.Point(12, 19);
            this.connectedTo_Label.Name = "connectedTo_Label";
            this.connectedTo_Label.Size = new System.Drawing.Size(217, 13);
            this.connectedTo_Label.TabIndex = 0;
            this.connectedTo_Label.Text = "You are connected to NetworkName.";
            // 
            // description_label_1
            // 
            this.description_label_1.Location = new System.Drawing.Point(12, 51);
            this.description_label_1.Name = "description_label_1";
            this.description_label_1.Size = new System.Drawing.Size(231, 46);
            this.description_label_1.TabIndex = 1;
            this.description_label_1.Text = "To disconnect or view status information, double-click the dial-up icon in the st" +
    "atus area of the taskbar.";
            // 
            // description_label_2
            // 
            this.description_label_2.Location = new System.Drawing.Point(12, 105);
            this.description_label_2.Name = "description_label_2";
            this.description_label_2.Size = new System.Drawing.Size(234, 32);
            this.description_label_2.TabIndex = 2;
            this.description_label_2.Text = "You can also double-click the connection icon in the Dial-Up Networking folder.";
            // 
            // doNotShow_Checkbox
            // 
            this.doNotShow_Checkbox.AutoSize = true;
            this.doNotShow_Checkbox.Location = new System.Drawing.Point(15, 154);
            this.doNotShow_Checkbox.Name = "doNotShow_Checkbox";
            this.doNotShow_Checkbox.Size = new System.Drawing.Size(218, 17);
            this.doNotShow_Checkbox.TabIndex = 3;
            this.doNotShow_Checkbox.Text = "&Do not show this dialog box in the future.";
            this.doNotShow_Checkbox.UseVisualStyleBackColor = true;
            this.doNotShow_Checkbox.CheckedChanged += new System.EventHandler(this.doNotShow_Checkbox_CheckedChanged);
            // 
            // moreInfo_button
            // 
            this.moreInfo_button.Location = new System.Drawing.Point(314, 192);
            this.moreInfo_button.Name = "moreInfo_button";
            this.moreInfo_button.Size = new System.Drawing.Size(117, 23);
            this.moreInfo_button.TabIndex = 4;
            this.moreInfo_button.Text = "&More Information...";
            this.moreInfo_button.UseVisualStyleBackColor = true;
            this.moreInfo_button.Click += new System.EventHandler(this.moreInfo_button_Click);
            // 
            // close_button
            // 
            this.close_button.Location = new System.Drawing.Point(233, 192);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(75, 23);
            this.close_button.TabIndex = 5;
            this.close_button.Text = "Close";
            this.close_button.UseVisualStyleBackColor = true;
            this.close_button.Click += new System.EventHandler(this.close_button_Click);
            // 
            // taskbar_image
            // 
            this.taskbar_image.Image = global::DialUpSimulator.Properties.Resources.taskbar;
            this.taskbar_image.Location = new System.Drawing.Point(257, 51);
            this.taskbar_image.Name = "taskbar_image";
            this.taskbar_image.Size = new System.Drawing.Size(174, 46);
            this.taskbar_image.TabIndex = 7;
            this.taskbar_image.TabStop = false;
            // 
            // dialup_icon
            // 
            this.dialup_icon.Image = global::DialUpSimulator.Properties.Resources.icon;
            this.dialup_icon.Location = new System.Drawing.Point(257, 109);
            this.dialup_icon.Name = "dialup_icon";
            this.dialup_icon.Size = new System.Drawing.Size(32, 32);
            this.dialup_icon.TabIndex = 6;
            this.dialup_icon.TabStop = false;
            // 
            // ConnectionEstablishedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 227);
            this.Controls.Add(this.taskbar_image);
            this.Controls.Add(this.dialup_icon);
            this.Controls.Add(this.close_button);
            this.Controls.Add(this.moreInfo_button);
            this.Controls.Add(this.doNotShow_Checkbox);
            this.Controls.Add(this.description_label_2);
            this.Controls.Add(this.description_label_1);
            this.Controls.Add(this.connectedTo_Label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConnectionEstablishedForm";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connection Established";
            ((System.ComponentModel.ISupportInitialize)(this.taskbar_image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dialup_icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label connectedTo_Label;
        private System.Windows.Forms.Label description_label_1;
        private System.Windows.Forms.Label description_label_2;
        private System.Windows.Forms.CheckBox doNotShow_Checkbox;
        private System.Windows.Forms.Button moreInfo_button;
        private System.Windows.Forms.Button close_button;
        private System.Windows.Forms.PictureBox dialup_icon;
        private System.Windows.Forms.PictureBox taskbar_image;
    }
}