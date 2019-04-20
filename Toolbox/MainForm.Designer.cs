namespace Toolbox
{
    partial class MainWindow
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
            this.settings = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.labelStatus = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelStatusValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // settings
            // 
            this.settings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.settings.Location = new System.Drawing.Point(23, 124);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(92, 23);
            this.settings.TabIndex = 0;
            this.settings.Text = "Settings";
            this.settings.UseVisualStyleBackColor = true;
            this.settings.Click += new System.EventHandler(this.Settings_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(23, 95);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(92, 23);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(20, 9);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(40, 13);
            this.labelStatus.TabIndex = 2;
            this.labelStatus.Text = "Status:";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // labelStatusValue
            // 
            this.labelStatusValue.AutoSize = true;
            this.labelStatusValue.Location = new System.Drawing.Point(56, 9);
            this.labelStatusValue.Name = "labelStatusValue";
            this.labelStatusValue.Size = new System.Drawing.Size(24, 13);
            this.labelStatusValue.TabIndex = 3;
            this.labelStatusValue.Text = "Idle";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 165);
            this.Controls.Add(this.labelStatusValue);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.settings);
            this.Name = "MainWindow";
            this.Text = "Toolbox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button settings;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelStatusValue;
    }
}

