/*
 * Criado por FORCE
 * Force&Kuraio Dev
 * Última modificação: 27/11/2019
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using Launcher.Properties;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using Launcher.Utils;
using Launcher.Packet;

namespace Launcher
{
    public partial class Form_Launcher : Form
    {
        private Point NewPoint;
        public static string _nickname, _token = null;
        public static long _UID;

        public Form_Launcher()
        {
            InitializeComponent();
        }

        private void Form_Launcher_Load(object sender, EventArgs e)
        {
            web_announc.Navigate(LINK_REC.WEB_Link);
        }

        private void login_success(string nick)
        {
            Texto.Log("LOGIN_SUCCESS");
            Texto.Log("UID: " + _UID);
            if (string.IsNullOrEmpty(nick))
                lb_nickname.Text = Resources.NO_NICKNAME;
            else
                lb_nickname.Text = nick;
            lb_status.Text = Resources.GAME_IS_OK;
            lb_Fix.Visible = true;
            lb_nickname.Visible = true;
            lb_status.Visible = true;
            lb_files.Visible = true;
            lb_total.Visible = true;
            FixBar1.Visible = true;
            ArquivBar.Visible = true;
            FixBar2.Visible = true;
            Total_Bar.Visible = true;
            btn_jogar.Visible = true;
        }

        #region Códigos padrão de movimentação do form
        private void Launcher_MouseDown(object sender, MouseEventArgs e)
        {
            if (MouseButtons == MouseButtons.Left)
            {
                int left = Left;
                Point mousePosition = MousePosition;
                NewPoint.X = left - mousePosition.X;
                int top = Top;
                Point point = MousePosition;
                NewPoint.Y = top - point.Y;
            }
        }

        private void Launcher_MouseMove(object sender, MouseEventArgs e)
        {
            if (MouseButtons == MouseButtons.Left)
            {
                int x = NewPoint.X;
                Point mousePosition = MousePosition;
                Left = x + mousePosition.X;
                int y = NewPoint.Y;
                mousePosition = MousePosition;
                Top = y + mousePosition.Y;
            }
        }
        #endregion

        private void Form_Launcher_FormClosed(object sender, FormClosedEventArgs e)
        {
            ConectionClient.Exit();
        }

        private void auth1_EnabledChanged(object sender, EventArgs e)
        {
                login_success(_nickname);
        }

        private void pictureBox_min_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(Resources.EXIT_ASK, Resources.PROJECT_NAME, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void pictureBox_min_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox_min.Image = Resources.btn_min_hover;
        }

        private void pictureBox_min_MouseLeave(object sender, EventArgs e)
        {
            pictureBox_min.Image = Resources.btn_min;
        }

        private void pictureBox_exit_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox_exit.Image = Resources.btn_close_hover;
        }

        private void pictureBox_exit_MouseLeave(object sender, EventArgs e)
        {
            pictureBox_exit.Image = Resources.btn_close;
        }

        private void auth1_Load(object sender, EventArgs e)
        {

        }

        private void btn_jogar_Click(object sender, EventArgs e)
        {
            if (File.Exists(string.Concat(Application.StartupPath, "\\PointBlank.exe")))
            {
                lb_status.Text = Resources.LOADING;
                btn_jogar.Enabled = false;
                GET_USER_INFO_REC.GetToken();
                if (_token == null)
                {
                    MessageBox.Show(Resources.TOKEN_ERROR, Resources.PROJECT_NAME, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    Texto.Log("PLAYER_TOKEN_ERROR");
                }
                else
                {
                    Process.Start(string.Concat(Application.StartupPath, "\\PointBlank.exe"), "/GameID:\"Marshall\" /Token: " + _token);
                    Texto.Log("GAME_STARTED_SUCESS");
                }
                Close();


            }
            else
            {
                MessageBox.Show(Resources.GAME_NOT_FOUND, Resources.PROJECT_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Texto.Log("GAME_NOT_FOUND");
                Texto.Log("GAME_START_ERROR");
                Close();
            }
        }
    }
}
