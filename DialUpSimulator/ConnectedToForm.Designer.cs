namespace DialUpSimulator
{
    partial class ConnectedToForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConnectedToForm));
            this.connectedAt_label = new System.Windows.Forms.Label();
            this.duration_label = new System.Windows.Forms.Label();
            this.bytesReceived_label = new System.Windows.Forms.Label();
            this.bytesSent_label = new System.Windows.Forms.Label();
            this.ok_button = new System.Windows.Forms.Button();
            this.disconnect_button = new System.Windows.Forms.Button();
            this.details_button = new System.Windows.Forms.Button();
            this.connection_icon = new System.Windows.Forms.PictureBox();
            this.networkStatus_notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.networkStatus_icon_contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.disconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateData_timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.connection_icon)).BeginInit();
            this.networkStatus_icon_contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // connectedAt_label
            // 
            this.connectedAt_label.AutoSize = true;
            this.connectedAt_label.Location = new System.Drawing.Point(60, 12);
            this.connectedAt_label.Name = "connectedAt_label";
            this.connectedAt_label.Size = new System.Drawing.Size(127, 13);
            this.connectedAt_label.TabIndex = 1;
            this.connectedAt_label.Text = "Connected at 45,333 bps";
            // 
            // duration_label
            // 
            this.duration_label.AutoSize = true;
            this.duration_label.Location = new System.Drawing.Point(60, 33);
            this.duration_label.Name = "duration_label";
            this.duration_label.Size = new System.Drawing.Size(95, 13);
            this.duration_label.TabIndex = 2;
            this.duration_label.Text = "Duration: 00:00:00";
            // 
            // bytesReceived_label
            // 
            this.bytesReceived_label.AutoSize = true;
            this.bytesReceived_label.Location = new System.Drawing.Point(60, 54);
            this.bytesReceived_label.Name = "bytesReceived_label";
            this.bytesReceived_label.Size = new System.Drawing.Size(101, 13);
            this.bytesReceived_label.TabIndex = 3;
            this.bytesReceived_label.Text = "Bytes received: 568";
            // 
            // bytesSent_label
            // 
            this.bytesSent_label.AutoSize = true;
            this.bytesSent_label.Location = new System.Drawing.Point(60, 75);
            this.bytesSent_label.Name = "bytesSent_label";
            this.bytesSent_label.Size = new System.Drawing.Size(89, 13);
            this.bytesSent_label.TabIndex = 4;
            this.bytesSent_label.Text = "Bytes sent: 3,118";
            // 
            // ok_button
            // 
            this.ok_button.Location = new System.Drawing.Point(278, 12);
            this.ok_button.Name = "ok_button";
            this.ok_button.Size = new System.Drawing.Size(75, 23);
            this.ok_button.TabIndex = 5;
            this.ok_button.Text = "&OK";
            this.ok_button.UseVisualStyleBackColor = true;
            this.ok_button.Click += new System.EventHandler(this.ok_button_Click);
            // 
            // disconnect_button
            // 
            this.disconnect_button.Location = new System.Drawing.Point(278, 43);
            this.disconnect_button.Name = "disconnect_button";
            this.disconnect_button.Size = new System.Drawing.Size(75, 23);
            this.disconnect_button.TabIndex = 6;
            this.disconnect_button.Text = "Dis&connect";
            this.disconnect_button.UseVisualStyleBackColor = true;
            this.disconnect_button.Click += new System.EventHandler(this.disconnect_button_Click);
            // 
            // details_button
            // 
            this.details_button.Location = new System.Drawing.Point(278, 74);
            this.details_button.Name = "details_button";
            this.details_button.Size = new System.Drawing.Size(75, 23);
            this.details_button.TabIndex = 7;
            this.details_button.Text = "&Details >>";
            this.details_button.UseVisualStyleBackColor = true;
            this.details_button.Click += new System.EventHandler(this.details_button_Click);
            // 
            // connection_icon
            // 
            this.connection_icon.Image = global::DialUpSimulator.Properties.Resources.icon;
            this.connection_icon.Location = new System.Drawing.Point(12, 12);
            this.connection_icon.Name = "connection_icon";
            this.connection_icon.Size = new System.Drawing.Size(32, 32);
            this.connection_icon.TabIndex = 0;
            this.connection_icon.TabStop = false;
            // 
            // networkStatus_notifyIcon
            // 
            this.networkStatus_notifyIcon.ContextMenuStrip = this.networkStatus_icon_contextMenuStrip;
            this.networkStatus_notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("networkStatus_notifyIcon.Icon")));
            this.networkStatus_notifyIcon.Text = "text";
            this.networkStatus_notifyIcon.Visible = true;
            this.networkStatus_notifyIcon.DoubleClick += new System.EventHandler(this.networkStatus_notifyIcon_Click);
            // 
            // networkStatus_icon_contextMenuStrip
            // 
            this.networkStatus_icon_contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.disconnectToolStripMenuItem});
            this.networkStatus_icon_contextMenuStrip.Name = "networkStatus_icon_contextMenuStrip";
            this.networkStatus_icon_contextMenuStrip.Size = new System.Drawing.Size(134, 26);
            // 
            // disconnectToolStripMenuItem
            // 
            this.disconnectToolStripMenuItem.Name = "disconnectToolStripMenuItem";
            this.disconnectToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.disconnectToolStripMenuItem.Text = "Disconnect";
            this.disconnectToolStripMenuItem.Click += new System.EventHandler(this.disconnect_button_Click);
            // 
            // updateData_timer
            // 
            this.updateData_timer.Enabled = true;
            this.updateData_timer.Interval = 1000;
            this.updateData_timer.Tick += new System.EventHandler(this.updateData_timer_Tick);
            // 
            // ConnectedToForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 109);
            this.Controls.Add(this.details_button);
            this.Controls.Add(this.disconnect_button);
            this.Controls.Add(this.ok_button);
            this.Controls.Add(this.bytesSent_label);
            this.Controls.Add(this.bytesReceived_label);
            this.Controls.Add(this.duration_label);
            this.Controls.Add(this.connectedAt_label);
            this.Controls.Add(this.connection_icon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConnectedToForm";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Connected to NetworkName";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            ((System.ComponentModel.ISupportInitialize)(this.connection_icon)).EndInit();
            this.networkStatus_icon_contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox connection_icon;
        private System.Windows.Forms.Label connectedAt_label;
        private System.Windows.Forms.Label duration_label;
        private System.Windows.Forms.Label bytesReceived_label;
        private System.Windows.Forms.Label bytesSent_label;
        private System.Windows.Forms.Button ok_button;
        private System.Windows.Forms.Button disconnect_button;
        private System.Windows.Forms.Button details_button;
        private System.Windows.Forms.NotifyIcon networkStatus_notifyIcon;
        private System.Windows.Forms.ContextMenuStrip networkStatus_icon_contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem disconnectToolStripMenuItem;
        private System.Windows.Forms.Timer updateData_timer;
    }
}