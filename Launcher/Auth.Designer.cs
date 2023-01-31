namespace Launcher
{
    partial class Auth
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_user = new System.Windows.Forms.TextBox();
            this.lb_user_Fix = new System.Windows.Forms.Label();
            this.textBox_pass = new System.Windows.Forms.TextBox();
            this.lb_pass_fix = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.lb_end_fix = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lb_titulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_user
            // 
            this.textBox_user.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.textBox_user.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_user.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.textBox_user.Location = new System.Drawing.Point(31, 61);
            this.textBox_user.MaxLength = 16;
            this.textBox_user.Name = "textBox_user";
            this.textBox_user.Size = new System.Drawing.Size(267, 29);
            this.textBox_user.TabIndex = 0;
            this.textBox_user.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_user_KeyPress);
            // 
            // lb_user_Fix
            // 
            this.lb_user_Fix.AutoSize = true;
            this.lb_user_Fix.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_user_Fix.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lb_user_Fix.Location = new System.Drawing.Point(28, 40);
            this.lb_user_Fix.Name = "lb_user_Fix";
            this.lb_user_Fix.Size = new System.Drawing.Size(60, 18);
            this.lb_user_Fix.TabIndex = 1;
            this.lb_user_Fix.Text = "Usuário:";
            // 
            // textBox_pass
            // 
            this.textBox_pass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.textBox_pass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_pass.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.textBox_pass.Location = new System.Drawing.Point(320, 61);
            this.textBox_pass.MaxLength = 16;
            this.textBox_pass.Name = "textBox_pass";
            this.textBox_pass.PasswordChar = '*';
            this.textBox_pass.Size = new System.Drawing.Size(267, 29);
            this.textBox_pass.TabIndex = 1;
            this.textBox_pass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_pass_KeyPress);
            // 
            // lb_pass_fix
            // 
            this.lb_pass_fix.AutoSize = true;
            this.lb_pass_fix.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_pass_fix.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lb_pass_fix.Location = new System.Drawing.Point(317, 40);
            this.lb_pass_fix.Name = "lb_pass_fix";
            this.lb_pass_fix.Size = new System.Drawing.Size(50, 18);
            this.lb_pass_fix.TabIndex = 1;
            this.lb_pass_fix.Text = "Senha:";
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.Red;
            this.btn_login.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btn_login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.btn_login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_login.Location = new System.Drawing.Point(613, 41);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(195, 50);
            this.btn_login.TabIndex = 2;
            this.btn_login.Text = "ENTRAR";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // lb_end_fix
            // 
            this.lb_end_fix.AutoSize = true;
            this.lb_end_fix.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_end_fix.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lb_end_fix.Location = new System.Drawing.Point(648, 92);
            this.lb_end_fix.Name = "lb_end_fix";
            this.lb_end_fix.Size = new System.Drawing.Size(79, 18);
            this.lb_end_fix.TabIndex = 4;
            this.lb_end_fix.Text = "Sem conta?";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.Red;
            this.linkLabel1.Location = new System.Drawing.Point(723, 95);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(59, 13);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Clique aqui";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lb_titulo
            // 
            this.lb_titulo.AutoSize = true;
            this.lb_titulo.BackColor = System.Drawing.Color.Transparent;
            this.lb_titulo.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_titulo.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_titulo.Location = new System.Drawing.Point(28, 10);
            this.lb_titulo.Name = "lb_titulo";
            this.lb_titulo.Size = new System.Drawing.Size(73, 18);
            this.lb_titulo.TabIndex = 5;
            this.lb_titulo.Text = "Non String";
            // 
            // Auth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::Launcher.Properties.Resources.bg_forms;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.lb_titulo);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.lb_end_fix);
            this.Controls.Add(this.lb_pass_fix);
            this.Controls.Add(this.textBox_pass);
            this.Controls.Add(this.lb_user_Fix);
            this.Controls.Add(this.textBox_user);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Name = "Auth";
            this.Size = new System.Drawing.Size(841, 119);
            this.Load += new System.EventHandler(this.Auth_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_user;
        private System.Windows.Forms.Label lb_user_Fix;
        private System.Windows.Forms.TextBox textBox_pass;
        private System.Windows.Forms.Label lb_pass_fix;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Label lb_end_fix;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label lb_titulo;
    }
}
