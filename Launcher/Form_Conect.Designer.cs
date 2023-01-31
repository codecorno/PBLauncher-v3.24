namespace Launcher
{
    partial class Form_Conect
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_status = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_status
            // 
            this.lb_status.BackColor = System.Drawing.Color.Transparent;
            this.lb_status.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_status.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_status.Location = new System.Drawing.Point(12, 187);
            this.lb_status.Name = "lb_status";
            this.lb_status.Size = new System.Drawing.Size(416, 23);
            this.lb_status.TabIndex = 0;
            this.lb_status.Text = "Loading...";
            this.lb_status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form_Conect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Launcher.Properties.Resources.top_light;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(440, 212);
            this.Controls.Add(this.lb_status);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Conect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Plase Wait...";
            this.Load += new System.EventHandler(this.Form_Conect_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb_status;
    }
}

