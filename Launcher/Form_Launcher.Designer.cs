namespace Launcher
{
    partial class Form_Launcher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Launcher));
            this.web_announc = new System.Windows.Forms.WebBrowser();
            this.lb_nickname = new System.Windows.Forms.Label();
            this.lb_Fix = new System.Windows.Forms.Label();
            this.lb_total = new System.Windows.Forms.Label();
            this.lb_files = new System.Windows.Forms.Label();
            this.Total_Bar = new System.Windows.Forms.PictureBox();
            this.ArquivBar = new System.Windows.Forms.PictureBox();
            this.lb_status = new System.Windows.Forms.Label();
            this.pictureBox_min = new System.Windows.Forms.PictureBox();
            this.pictureBox_exit = new System.Windows.Forms.PictureBox();
            this.FixBar2 = new System.Windows.Forms.PictureBox();
            this.FixBar1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox_top = new System.Windows.Forms.PictureBox();
            this.btn_jogar = new System.Windows.Forms.Button();
            this.auth1 = new Launcher.Auth();
            ((System.ComponentModel.ISupportInitialize)(this.Total_Bar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArquivBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FixBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FixBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_top)).BeginInit();
            this.SuspendLayout();
            // 
            // web_announc
            // 
            this.web_announc.Location = new System.Drawing.Point(0, 33);
            this.web_announc.MinimumSize = new System.Drawing.Size(20, 20);
            this.web_announc.Name = "web_announc";
            this.web_announc.ScrollBarsEnabled = false;
            this.web_announc.Size = new System.Drawing.Size(841, 359);
            this.web_announc.TabIndex = 6;
            // 
            // lb_nickname
            // 
            this.lb_nickname.AutoSize = true;
            this.lb_nickname.BackColor = System.Drawing.Color.Transparent;
            this.lb_nickname.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nickname.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lb_nickname.Image = ((System.Drawing.Image)(resources.GetObject("lb_nickname.Image")));
            this.lb_nickname.Location = new System.Drawing.Point(92, 9);
            this.lb_nickname.Name = "lb_nickname";
            this.lb_nickname.Size = new System.Drawing.Size(67, 16);
            this.lb_nickname.TabIndex = 1;
            this.lb_nickname.Text = "Non String";
            this.lb_nickname.Visible = false;
            // 
            // lb_Fix
            // 
            this.lb_Fix.AutoSize = true;
            this.lb_Fix.BackColor = System.Drawing.Color.Transparent;
            this.lb_Fix.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Fix.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lb_Fix.Image = ((System.Drawing.Image)(resources.GetObject("lb_Fix.Image")));
            this.lb_Fix.Location = new System.Drawing.Point(11, 9);
            this.lb_Fix.Name = "lb_Fix";
            this.lb_Fix.Size = new System.Drawing.Size(87, 16);
            this.lb_Fix.TabIndex = 1;
            this.lb_Fix.Text = "Logado como: ";
            this.lb_Fix.Visible = false;
            // 
            // lb_total
            // 
            this.lb_total.AutoSize = true;
            this.lb_total.BackColor = System.Drawing.Color.Transparent;
            this.lb_total.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_total.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_total.Image = ((System.Drawing.Image)(resources.GetObject("lb_total.Image")));
            this.lb_total.Location = new System.Drawing.Point(32, 469);
            this.lb_total.Name = "lb_total";
            this.lb_total.Size = new System.Drawing.Size(37, 14);
            this.lb_total.TabIndex = 5;
            this.lb_total.Text = "Total:";
            // 
            // lb_files
            // 
            this.lb_files.AutoSize = true;
            this.lb_files.BackColor = System.Drawing.Color.Transparent;
            this.lb_files.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_files.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_files.Image = ((System.Drawing.Image)(resources.GetObject("lb_files.Image")));
            this.lb_files.Location = new System.Drawing.Point(32, 432);
            this.lb_files.Name = "lb_files";
            this.lb_files.Size = new System.Drawing.Size(51, 14);
            this.lb_files.TabIndex = 4;
            this.lb_files.Text = "Arquivo:";
            this.lb_files.Visible = false;
            // 
            // Total_Bar
            // 
            this.Total_Bar.BackColor = System.Drawing.Color.DimGray;
            this.Total_Bar.Location = new System.Drawing.Point(35, 486);
            this.Total_Bar.Name = "Total_Bar";
            this.Total_Bar.Size = new System.Drawing.Size(580, 10);
            this.Total_Bar.TabIndex = 12;
            this.Total_Bar.TabStop = false;
            this.Total_Bar.Visible = false;
            // 
            // ArquivBar
            // 
            this.ArquivBar.BackColor = System.Drawing.Color.DimGray;
            this.ArquivBar.Location = new System.Drawing.Point(35, 449);
            this.ArquivBar.Name = "ArquivBar";
            this.ArquivBar.Size = new System.Drawing.Size(580, 10);
            this.ArquivBar.TabIndex = 11;
            this.ArquivBar.TabStop = false;
            this.ArquivBar.Visible = false;
            // 
            // lb_status
            // 
            this.lb_status.AutoSize = true;
            this.lb_status.BackColor = System.Drawing.Color.Transparent;
            this.lb_status.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_status.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_status.Image = ((System.Drawing.Image)(resources.GetObject("lb_status.Image")));
            this.lb_status.Location = new System.Drawing.Point(32, 403);
            this.lb_status.Name = "lb_status";
            this.lb_status.Size = new System.Drawing.Size(73, 18);
            this.lb_status.TabIndex = 3;
            this.lb_status.Text = "Non String";
            this.lb_status.Visible = false;
            // 
            // pictureBox_min
            // 
            this.pictureBox_min.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_min.BackgroundImage = global::Launcher.Properties.Resources.bg_header;
            this.pictureBox_min.Image = global::Launcher.Properties.Resources.btn_min;
            this.pictureBox_min.Location = new System.Drawing.Point(779, 6);
            this.pictureBox_min.Name = "pictureBox_min";
            this.pictureBox_min.Size = new System.Drawing.Size(20, 20);
            this.pictureBox_min.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_min.TabIndex = 0;
            this.pictureBox_min.TabStop = false;
            this.pictureBox_min.Click += new System.EventHandler(this.pictureBox_min_Click);
            this.pictureBox_min.MouseLeave += new System.EventHandler(this.pictureBox_min_MouseLeave);
            this.pictureBox_min.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_min_MouseMove);
            // 
            // pictureBox_exit
            // 
            this.pictureBox_exit.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_exit.BackgroundImage = global::Launcher.Properties.Resources.bg_header;
            this.pictureBox_exit.Image = global::Launcher.Properties.Resources.btn_close;
            this.pictureBox_exit.Location = new System.Drawing.Point(812, 6);
            this.pictureBox_exit.Name = "pictureBox_exit";
            this.pictureBox_exit.Size = new System.Drawing.Size(20, 20);
            this.pictureBox_exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_exit.TabIndex = 0;
            this.pictureBox_exit.TabStop = false;
            this.pictureBox_exit.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox_exit.MouseLeave += new System.EventHandler(this.pictureBox_exit_MouseLeave);
            this.pictureBox_exit.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_exit_MouseMove);
            // 
            // FixBar2
            // 
            this.FixBar2.BackColor = System.Drawing.Color.Silver;
            this.FixBar2.Location = new System.Drawing.Point(35, 486);
            this.FixBar2.Name = "FixBar2";
            this.FixBar2.Size = new System.Drawing.Size(580, 10);
            this.FixBar2.TabIndex = 17;
            this.FixBar2.TabStop = false;
            this.FixBar2.Visible = false;
            // 
            // FixBar1
            // 
            this.FixBar1.BackColor = System.Drawing.Color.Silver;
            this.FixBar1.Location = new System.Drawing.Point(35, 449);
            this.FixBar1.Name = "FixBar1";
            this.FixBar1.Size = new System.Drawing.Size(580, 10);
            this.FixBar1.TabIndex = 16;
            this.FixBar1.TabStop = false;
            this.FixBar1.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::Launcher.Properties.Resources.bg_forms;
            this.pictureBox3.Location = new System.Drawing.Point(0, 392);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(841, 119);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 19;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox_top
            // 
            this.pictureBox_top.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_top.Image = global::Launcher.Properties.Resources.bg_header;
            this.pictureBox_top.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_top.Name = "pictureBox_top";
            this.pictureBox_top.Size = new System.Drawing.Size(841, 34);
            this.pictureBox_top.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_top.TabIndex = 20;
            this.pictureBox_top.TabStop = false;
            this.pictureBox_top.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Launcher_MouseDown);
            this.pictureBox_top.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Launcher_MouseMove);
            // 
            // btn_jogar
            // 
            this.btn_jogar.BackColor = System.Drawing.Color.Red;
            this.btn_jogar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btn_jogar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.btn_jogar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.btn_jogar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_jogar.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_jogar.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_jogar.Location = new System.Drawing.Point(626, 431);
            this.btn_jogar.Name = "btn_jogar";
            this.btn_jogar.Size = new System.Drawing.Size(196, 67);
            this.btn_jogar.TabIndex = 0;
            this.btn_jogar.Text = "JOGAR";
            this.btn_jogar.UseVisualStyleBackColor = false;
            this.btn_jogar.Visible = false;
            this.btn_jogar.Click += new System.EventHandler(this.btn_jogar_Click);
            // 
            // auth1
            // 
            this.auth1.BackColor = System.Drawing.Color.Transparent;
            this.auth1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("auth1.BackgroundImage")));
            this.auth1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.auth1.ForeColor = System.Drawing.Color.Transparent;
            this.auth1.Location = new System.Drawing.Point(0, 392);
            this.auth1.Name = "auth1";
            this.auth1.Size = new System.Drawing.Size(841, 119);
            this.auth1.TabIndex = 7;
            this.auth1.Load += new System.EventHandler(this.auth1_Load);
            this.auth1.EnabledChanged += new System.EventHandler(this.auth1_EnabledChanged);
            // 
            // Form_Launcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(841, 511);
            this.Controls.Add(this.lb_nickname);
            this.Controls.Add(this.lb_status);
            this.Controls.Add(this.web_announc);
            this.Controls.Add(this.btn_jogar);
            this.Controls.Add(this.lb_Fix);
            this.Controls.Add(this.lb_total);
            this.Controls.Add(this.lb_files);
            this.Controls.Add(this.Total_Bar);
            this.Controls.Add(this.ArquivBar);
            this.Controls.Add(this.pictureBox_min);
            this.Controls.Add(this.pictureBox_exit);
            this.Controls.Add(this.FixBar2);
            this.Controls.Add(this.FixBar1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox_top);
            this.Controls.Add(this.auth1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Launcher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Launcher";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Launcher_FormClosed);
            this.Load += new System.EventHandler(this.Form_Launcher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Total_Bar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArquivBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FixBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FixBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_top)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_exit;
        private System.Windows.Forms.PictureBox pictureBox_min;
        private System.Windows.Forms.WebBrowser web_announc;
        private System.Windows.Forms.Label lb_total;
        private System.Windows.Forms.Label lb_files;
        private System.Windows.Forms.PictureBox Total_Bar;
        private System.Windows.Forms.PictureBox ArquivBar;
        private System.Windows.Forms.Label lb_status;
        private System.Windows.Forms.PictureBox FixBar2;
        private System.Windows.Forms.PictureBox FixBar1;
        private System.Windows.Forms.Label lb_Fix;
        private System.Windows.Forms.Label lb_nickname;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox_top;
        private System.Windows.Forms.Button btn_jogar;
        private Auth auth1;
    }
}