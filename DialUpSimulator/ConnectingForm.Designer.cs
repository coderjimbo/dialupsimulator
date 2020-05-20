namespace DialUpSimulator
{
    partial class ConnectingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConnectingForm));
            this.status_label = new System.Windows.Forms.Label();
            this.cancel_button = new System.Windows.Forms.Button();
            this.connecting_icon = new System.Windows.Forms.PictureBox();
            this.dialup_simulation_worker = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.connecting_icon)).BeginInit();
            this.SuspendLayout();
            // 
            // status_label
            // 
            this.status_label.Location = new System.Drawing.Point(61, 12);
            this.status_label.Name = "status_label";
            this.status_label.Size = new System.Drawing.Size(164, 32);
            this.status_label.TabIndex = 0;
            this.status_label.Text = "Status: Verifying user name and password...";
            // 
            // cancel_button
            // 
            this.cancel_button.Location = new System.Drawing.Point(246, 12);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(75, 23);
            this.cancel_button.TabIndex = 2;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // connecting_icon
            // 
            this.connecting_icon.Image = global::DialUpSimulator.Properties.Resources.connecting;
            this.connecting_icon.Location = new System.Drawing.Point(12, 12);
            this.connecting_icon.Name = "connecting_icon";
            this.connecting_icon.Size = new System.Drawing.Size(32, 32);
            this.connecting_icon.TabIndex = 1;
            this.connecting_icon.TabStop = false;
            // 
            // dialup_simulation_worker
            // 
            this.dialup_simulation_worker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.dialup_simulation_worker_DoWork);
            this.dialup_simulation_worker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.dialup_simulation_worker_ProgressChanged);
            this.dialup_simulation_worker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.dialup_simulation_worker_RunWorkerCompleted);
            // 
            // ConnectingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 61);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.connecting_icon);
            this.Controls.Add(this.status_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConnectingForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connecting to Connection";
            ((System.ComponentModel.ISupportInitialize)(this.connecting_icon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label status_label;
        private System.Windows.Forms.PictureBox connecting_icon;
        private System.Windows.Forms.Button cancel_button;
        private System.ComponentModel.BackgroundWorker dialup_simulation_worker;
    }
}