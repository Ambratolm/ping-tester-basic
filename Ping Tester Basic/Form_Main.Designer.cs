namespace PingTesterBasic
{
    partial class Form_Main
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.timer_main = new System.Windows.Forms.Timer(this.components);
            this.label_host = new System.Windows.Forms.Label();
            this.button_message = new System.Windows.Forms.Button();
            this.button_time = new System.Windows.Forms.Button();
            this.progressBar_main = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // timer_main
            // 
            this.timer_main.Interval = 1000;
            this.timer_main.Tick += new System.EventHandler(this.timer_main_Tick);
            // 
            // label_host
            // 
            this.label_host.BackColor = System.Drawing.Color.Transparent;
            this.label_host.Font = new System.Drawing.Font("Lucida Console", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_host.ForeColor = System.Drawing.Color.Silver;
            this.label_host.Location = new System.Drawing.Point(22, 160);
            this.label_host.Name = "label_host";
            this.label_host.Size = new System.Drawing.Size(350, 37);
            this.label_host.TabIndex = 3;
            this.label_host.Text = "{ HostName }\r\n{ HostIPAddress }";
            this.label_host.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_message
            // 
            this.button_message.BackgroundImage = global::PingTesterBasic.Properties.Resources.background_disconnected;
            this.button_message.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_message.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button_message.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_message.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_message.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_message.Font = new System.Drawing.Font("Lucida Console", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_message.Location = new System.Drawing.Point(22, 18);
            this.button_message.Name = "button_message";
            this.button_message.Size = new System.Drawing.Size(350, 68);
            this.button_message.TabIndex = 4;
            this.button_message.Text = "{ Message }";
            this.button_message.UseVisualStyleBackColor = true;
            // 
            // button_time
            // 
            this.button_time.BackColor = System.Drawing.Color.Transparent;
            this.button_time.BackgroundImage = global::PingTesterBasic.Properties.Resources.background2;
            this.button_time.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_time.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_time.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_time.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_time.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_time.Font = new System.Drawing.Font("Lucida Console", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_time.Location = new System.Drawing.Point(124, 99);
            this.button_time.Name = "button_time";
            this.button_time.Size = new System.Drawing.Size(146, 50);
            this.button_time.TabIndex = 14;
            this.button_time.Text = "{ Time }";
            this.button_time.UseVisualStyleBackColor = false;
            this.button_time.Click += new System.EventHandler(this.button_time_Click);
            // 
            // progressBar_main
            // 
            this.progressBar_main.BackColor = System.Drawing.Color.Black;
            this.progressBar_main.ForeColor = System.Drawing.Color.Gray;
            this.progressBar_main.Location = new System.Drawing.Point(-3, 116);
            this.progressBar_main.Maximum = 299;
            this.progressBar_main.Name = "progressBar_main";
            this.progressBar_main.Size = new System.Drawing.Size(401, 19);
            this.progressBar_main.Step = 1;
            this.progressBar_main.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar_main.TabIndex = 13;
            this.progressBar_main.Click += new System.EventHandler(this.progressBar_main_Click);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PingTesterBasic.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(394, 214);
            this.Controls.Add(this.button_time);
            this.Controls.Add(this.progressBar_main);
            this.Controls.Add(this.button_message);
            this.Controls.Add(this.label_host);
            this.Font = new System.Drawing.Font("Lucida Console", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.MaximizeBox = false;
            this.Name = "Form_Main";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ping Tester v0.2 (by Ambratolm)";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer_main;
        private System.Windows.Forms.Label label_host;
        private System.Windows.Forms.Button button_message;
        private System.Windows.Forms.Button button_time;
        private System.Windows.Forms.ProgressBar progressBar_main;
    }
}

