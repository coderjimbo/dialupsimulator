namespace DialUpSimulator
{
    partial class DialPropertiesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DialPropertiesForm));
            this.name_label = new System.Windows.Forms.Label();
            this.connection_name_textbox = new System.Windows.Forms.TextBox();
            this.device_label = new System.Windows.Forms.Label();
            this.device_list_combobox = new System.Windows.Forms.ComboBox();
            this.control_device_checkbox = new System.Windows.Forms.CheckBox();
            this.cancel_button = new System.Windows.Forms.Button();
            this.ok_button = new System.Windows.Forms.Button();
            this.about_button = new System.Windows.Forms.Button();
            this.device_icon = new System.Windows.Forms.PictureBox();
            this.monitor_icon = new System.Windows.Forms.PictureBox();
            this.showInformational_checkBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.device_icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monitor_icon)).BeginInit();
            this.SuspendLayout();
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Location = new System.Drawing.Point(155, 12);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(223, 13);
            this.name_label.TabIndex = 1;
            this.name_label.Text = "&Type a name for the computer you are dialing:";
            // 
            // connection_name_textbox
            // 
            this.connection_name_textbox.Location = new System.Drawing.Point(158, 29);
            this.connection_name_textbox.MaxLength = 32;
            this.connection_name_textbox.Name = "connection_name_textbox";
            this.connection_name_textbox.Size = new System.Drawing.Size(254, 20);
            this.connection_name_textbox.TabIndex = 2;
            this.connection_name_textbox.TextChanged += new System.EventHandler(this.connection_name_textbox_TextChanged);
            // 
            // device_label
            // 
            this.device_label.AutoSize = true;
            this.device_label.Location = new System.Drawing.Point(155, 76);
            this.device_label.Name = "device_label";
            this.device_label.Size = new System.Drawing.Size(84, 13);
            this.device_label.TabIndex = 3;
            this.device_label.Text = "Select &a device:";
            // 
            // device_list_combobox
            // 
            this.device_list_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.device_list_combobox.FormattingEnabled = true;
            this.device_list_combobox.Location = new System.Drawing.Point(196, 92);
            this.device_list_combobox.Name = "device_list_combobox";
            this.device_list_combobox.Size = new System.Drawing.Size(216, 21);
            this.device_list_combobox.TabIndex = 5;
            // 
            // control_device_checkbox
            // 
            this.control_device_checkbox.AutoSize = true;
            this.control_device_checkbox.Location = new System.Drawing.Point(214, 119);
            this.control_device_checkbox.Name = "control_device_checkbox";
            this.control_device_checkbox.Size = new System.Drawing.Size(198, 17);
            this.control_device_checkbox.TabIndex = 6;
            this.control_device_checkbox.Text = "Control this &device when connecting";
            this.control_device_checkbox.UseVisualStyleBackColor = true;
            // 
            // cancel_button
            // 
            this.cancel_button.Location = new System.Drawing.Point(337, 246);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(75, 23);
            this.cancel_button.TabIndex = 7;
            this.cancel_button.Text = "&Cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // ok_button
            // 
            this.ok_button.Enabled = false;
            this.ok_button.Location = new System.Drawing.Point(256, 246);
            this.ok_button.Name = "ok_button";
            this.ok_button.Size = new System.Drawing.Size(75, 23);
            this.ok_button.TabIndex = 8;
            this.ok_button.Text = "&OK";
            this.ok_button.UseVisualStyleBackColor = true;
            this.ok_button.Click += new System.EventHandler(this.ok_button_Click);
            // 
            // about_button
            // 
            this.about_button.Location = new System.Drawing.Point(12, 246);
            this.about_button.Name = "about_button";
            this.about_button.Size = new System.Drawing.Size(75, 23);
            this.about_button.TabIndex = 9;
            this.about_button.Text = "A&bout";
            this.about_button.UseVisualStyleBackColor = true;
            this.about_button.Click += new System.EventHandler(this.about_button_Click);
            // 
            // device_icon
            // 
            this.device_icon.Image = global::DialUpSimulator.Properties.Resources.hardware_icon;
            this.device_icon.Location = new System.Drawing.Point(158, 92);
            this.device_icon.Name = "device_icon";
            this.device_icon.Size = new System.Drawing.Size(32, 32);
            this.device_icon.TabIndex = 4;
            this.device_icon.TabStop = false;
            // 
            // monitor_icon
            // 
            this.monitor_icon.Image = global::DialUpSimulator.Properties.Resources.dial_props;
            this.monitor_icon.Location = new System.Drawing.Point(12, 12);
            this.monitor_icon.Name = "monitor_icon";
            this.monitor_icon.Size = new System.Drawing.Size(120, 226);
            this.monitor_icon.TabIndex = 0;
            this.monitor_icon.TabStop = false;
            // 
            // showInformational_checkBox
            // 
            this.showInformational_checkBox.AutoSize = true;
            this.showInformational_checkBox.Location = new System.Drawing.Point(158, 161);
            this.showInformational_checkBox.Name = "showInformational_checkBox";
            this.showInformational_checkBox.Size = new System.Drawing.Size(229, 17);
            this.showInformational_checkBox.TabIndex = 10;
            this.showInformational_checkBox.Text = "Show &informational dialog when connected";
            this.showInformational_checkBox.UseVisualStyleBackColor = true;
            // 
            // DialPropertiesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 281);
            this.ControlBox = false;
            this.Controls.Add(this.showInformational_checkBox);
            this.Controls.Add(this.about_button);
            this.Controls.Add(this.ok_button);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.control_device_checkbox);
            this.Controls.Add(this.device_list_combobox);
            this.Controls.Add(this.device_icon);
            this.Controls.Add(this.device_label);
            this.Controls.Add(this.connection_name_textbox);
            this.Controls.Add(this.name_label);
            this.Controls.Add(this.monitor_icon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DialPropertiesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dial Properties";
            ((System.ComponentModel.ISupportInitialize)(this.device_icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monitor_icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox monitor_icon;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.TextBox connection_name_textbox;
        private System.Windows.Forms.Label device_label;
        private System.Windows.Forms.PictureBox device_icon;
        private System.Windows.Forms.ComboBox device_list_combobox;
        private System.Windows.Forms.CheckBox control_device_checkbox;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Button ok_button;
        private System.Windows.Forms.Button about_button;
        private System.Windows.Forms.CheckBox showInformational_checkBox;
    }
}