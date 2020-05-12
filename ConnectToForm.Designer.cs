namespace DialUpSimulator
{
    partial class ConnectToForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConnectToForm));
            this.connection_label = new System.Windows.Forms.Label();
            this.user_name_textbox = new System.Windows.Forms.TextBox();
            this.username_label = new System.Windows.Forms.Label();
            this.password_label = new System.Windows.Forms.Label();
            this.password_textbox = new System.Windows.Forms.TextBox();
            this.save_password_checkbox = new System.Windows.Forms.CheckBox();
            this.phone_number_textbox = new System.Windows.Forms.TextBox();
            this.phone_num_label = new System.Windows.Forms.Label();
            this.dialing_from_combobox = new System.Windows.Forms.ComboBox();
            this.dialing_from_label = new System.Windows.Forms.Label();
            this.dial_props_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.connect_button = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.connect_icon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.connect_icon)).BeginInit();
            this.SuspendLayout();
            // 
            // connection_label
            // 
            this.connection_label.AutoSize = true;
            this.connection_label.Location = new System.Drawing.Point(73, 28);
            this.connection_label.Name = "connection_label";
            this.connection_label.Size = new System.Drawing.Size(61, 13);
            this.connection_label.TabIndex = 1;
            this.connection_label.Text = "Connection";
            // 
            // user_name_textbox
            // 
            this.user_name_textbox.Location = new System.Drawing.Point(114, 76);
            this.user_name_textbox.MaxLength = 32;
            this.user_name_textbox.Name = "user_name_textbox";
            this.user_name_textbox.Size = new System.Drawing.Size(174, 20);
            this.user_name_textbox.TabIndex = 2;
            this.user_name_textbox.TextChanged += new System.EventHandler(this.connection_textboxes_TextChanged);
            // 
            // username_label
            // 
            this.username_label.AutoSize = true;
            this.username_label.Location = new System.Drawing.Point(13, 79);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(61, 13);
            this.username_label.TabIndex = 3;
            this.username_label.Text = "&User name:";
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Location = new System.Drawing.Point(13, 104);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(56, 13);
            this.password_label.TabIndex = 4;
            this.password_label.Text = "&Password:";
            // 
            // password_textbox
            // 
            this.password_textbox.Location = new System.Drawing.Point(114, 101);
            this.password_textbox.MaxLength = 32;
            this.password_textbox.Name = "password_textbox";
            this.password_textbox.Size = new System.Drawing.Size(174, 20);
            this.password_textbox.TabIndex = 5;
            this.password_textbox.UseSystemPasswordChar = true;
            this.password_textbox.TextChanged += new System.EventHandler(this.connection_textboxes_TextChanged);
            // 
            // save_password_checkbox
            // 
            this.save_password_checkbox.AutoSize = true;
            this.save_password_checkbox.Location = new System.Drawing.Point(114, 127);
            this.save_password_checkbox.Name = "save_password_checkbox";
            this.save_password_checkbox.Size = new System.Drawing.Size(99, 17);
            this.save_password_checkbox.TabIndex = 6;
            this.save_password_checkbox.Text = "&Save password";
            this.save_password_checkbox.UseVisualStyleBackColor = true;
            // 
            // phone_number_textbox
            // 
            this.phone_number_textbox.Location = new System.Drawing.Point(114, 161);
            this.phone_number_textbox.MaxLength = 24;
            this.phone_number_textbox.Name = "phone_number_textbox";
            this.phone_number_textbox.Size = new System.Drawing.Size(120, 20);
            this.phone_number_textbox.TabIndex = 7;
            this.phone_number_textbox.TextChanged += new System.EventHandler(this.connection_textboxes_TextChanged);
            this.phone_number_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phone_number_textbox_KeyPress);
            // 
            // phone_num_label
            // 
            this.phone_num_label.AutoSize = true;
            this.phone_num_label.Location = new System.Drawing.Point(13, 164);
            this.phone_num_label.Name = "phone_num_label";
            this.phone_num_label.Size = new System.Drawing.Size(79, 13);
            this.phone_num_label.TabIndex = 8;
            this.phone_num_label.Text = "Phone &number:";
            // 
            // dialing_from_combobox
            // 
            this.dialing_from_combobox.Enabled = false;
            this.dialing_from_combobox.FormattingEnabled = true;
            this.dialing_from_combobox.Location = new System.Drawing.Point(114, 188);
            this.dialing_from_combobox.Name = "dialing_from_combobox";
            this.dialing_from_combobox.Size = new System.Drawing.Size(120, 21);
            this.dialing_from_combobox.TabIndex = 9;
            this.dialing_from_combobox.Text = "Home";
            // 
            // dialing_from_label
            // 
            this.dialing_from_label.AutoSize = true;
            this.dialing_from_label.Location = new System.Drawing.Point(13, 191);
            this.dialing_from_label.Name = "dialing_from_label";
            this.dialing_from_label.Size = new System.Drawing.Size(65, 13);
            this.dialing_from_label.TabIndex = 10;
            this.dialing_from_label.Text = "Dialing &from:";
            // 
            // dial_props_button
            // 
            this.dial_props_button.Location = new System.Drawing.Point(240, 188);
            this.dial_props_button.Name = "dial_props_button";
            this.dial_props_button.Size = new System.Drawing.Size(94, 23);
            this.dial_props_button.TabIndex = 11;
            this.dial_props_button.Text = "&Dial Properties...";
            this.dial_props_button.UseVisualStyleBackColor = true;
            this.dial_props_button.Click += new System.EventHandler(this.dial_props_button_Click);
            // 
            // cancel_button
            // 
            this.cancel_button.Location = new System.Drawing.Point(259, 229);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(75, 23);
            this.cancel_button.TabIndex = 12;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // connect_button
            // 
            this.connect_button.Enabled = false;
            this.connect_button.Location = new System.Drawing.Point(178, 229);
            this.connect_button.Name = "connect_button";
            this.connect_button.Size = new System.Drawing.Size(75, 23);
            this.connect_button.TabIndex = 13;
            this.connect_button.Text = "Connect";
            this.connect_button.UseVisualStyleBackColor = true;
            this.connect_button.Click += new System.EventHandler(this.connect_button_Click);
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(12, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(320, 2);
            this.label6.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(12, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(320, 2);
            this.label7.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Location = new System.Drawing.Point(14, 221);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(320, 2);
            this.label8.TabIndex = 16;
            // 
            // connect_icon
            // 
            this.connect_icon.Image = global::DialUpSimulator.Properties.Resources.icon;
            this.connect_icon.Location = new System.Drawing.Point(15, 18);
            this.connect_icon.Name = "connect_icon";
            this.connect_icon.Size = new System.Drawing.Size(32, 32);
            this.connect_icon.TabIndex = 0;
            this.connect_icon.TabStop = false;
            // 
            // ConnectToForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 264);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.connect_button);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.dial_props_button);
            this.Controls.Add(this.dialing_from_label);
            this.Controls.Add(this.dialing_from_combobox);
            this.Controls.Add(this.phone_num_label);
            this.Controls.Add(this.phone_number_textbox);
            this.Controls.Add(this.save_password_checkbox);
            this.Controls.Add(this.password_textbox);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.username_label);
            this.Controls.Add(this.user_name_textbox);
            this.Controls.Add(this.connection_label);
            this.Controls.Add(this.connect_icon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConnectToForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connect To";
            ((System.ComponentModel.ISupportInitialize)(this.connect_icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox connect_icon;
        private System.Windows.Forms.Label connection_label;
        private System.Windows.Forms.TextBox user_name_textbox;
        private System.Windows.Forms.Label username_label;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.TextBox password_textbox;
        private System.Windows.Forms.CheckBox save_password_checkbox;
        private System.Windows.Forms.TextBox phone_number_textbox;
        private System.Windows.Forms.Label phone_num_label;
        private System.Windows.Forms.ComboBox dialing_from_combobox;
        private System.Windows.Forms.Label dialing_from_label;
        private System.Windows.Forms.Button dial_props_button;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Button connect_button;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

