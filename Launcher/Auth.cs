using System;
using Launcher.Properties;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Launcher.Utils;

namespace Launcher
{
    public partial class Auth : UserControl
    {
        public Auth()
        {
            InitializeComponent();
        }

        private void Auth_Load(object sender, EventArgs e)
        {
            lb_titulo.Text = Resources.AUTH_TITLE;
            Texto.Log("LOGIN_REQUIRED");
            /*
             * Código para lembrar ID se um dia fazer
             */
        }

        private void Login_Check()
        {
            btn_login.Enabled = false;
            textBox_user.Enabled = false;
            textBox_pass.Enabled = false;
            if (!string.IsNullOrEmpty(textBox_user.Text) && !string.IsNullOrEmpty(textBox_pass.Text))
            {
                lb_titulo.Text = Resources.AUTH_LOGIN;
                try
                {
                    SendPacket.SendUI16(130);
                    SendPacket.SendS(textBox_user.Text.ToLower());
                    SendPacket.SendS(textBox_pass.Text.ToLower());
                    //MessageBox.Show(textBox_pass.Text.ToLower());
                    byte[] data = SendPacket.SendAll();
                    short Login = ReadsPacket.readS16(data, 0);
                    switch (Login)
                    {
                        case 0:
                            Form_Launcher._UID = ReadsPacket.readL64(data, 4);
                            int _nickL = ReadsPacket.readI32(data, 12);
                            Form_Launcher._nickname = ReadsPacket.readS(data, 16, _nickL);
                            Visible = false;
                            Enabled = false;
                            break;
                        case 1:
                            Texto.Log("LOGIN_ERROR : Incorrect Password");
                            MessageBox.Show(Resources.AUTH_PASS_ERROR, Resources.PROJECT_NAME, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            lb_titulo.Text = Resources.AUTH_TITLE;
                            textBox_pass.Clear();
                            btn_login.Enabled = true;
                            textBox_user.Enabled = true;
                            textBox_pass.Enabled = true;
                            break;
                        case 2:
                            Texto.Log("LOGIN_ERROR : Account not exist");
                            MessageBox.Show(Resources.AUTH_ACC_NOT_FOUND, Resources.PROJECT_NAME, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            lb_titulo.Text = Resources.AUTH_TITLE;
                            textBox_pass.Clear();
                            btn_login.Enabled = true;
                            textBox_user.Enabled = true;
                            textBox_pass.Enabled = true;
                            break;
                        case 3:
                            Texto.Log("LOGIN_ERROR : Account banned");
                            MessageBox.Show(Resources.AUTH_ACC_BANNED, Resources.PROJECT_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Application.Exit();
                            break;
                        case 4:
                            Texto.Log("LOGIN_ERROR : Only Staff");
                            MessageBox.Show(Resources.AUTH_ACC_NO_STAFF, Resources.PROJECT_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Application.Exit();
                            break;
                        default:
                            throw new ArgumentNullException();
                    }
                }
                catch
                {
                    Texto.Log("LOGIN_ERROR : SERVER_UNKNOWN_PACKAGE");
                    MessageBox.Show(Resources.SERVER_UNKNOWN_PACKAGE, Resources.PROJECT_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
            }
            else
            {
                if (string.IsNullOrEmpty(textBox_user.Text) && string.IsNullOrEmpty(textBox_pass.Text))
                    MessageBox.Show(Resources.LOGIN_PASS_REC, Resources.PROJECT_NAME, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else if (string.IsNullOrEmpty(textBox_user.Text))
                    MessageBox.Show(Resources.LOGIN_REC, Resources.PROJECT_NAME, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else if (string.IsNullOrEmpty(textBox_pass.Text))
                    MessageBox.Show(Resources.PASS_REC, Resources.PROJECT_NAME, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lb_titulo.Text = Resources.AUTH_TITLE;
                btn_login.Enabled = true;
                textBox_user.Enabled = true;
                textBox_pass.Enabled = true; 
                Texto.Log("LOGIN_ERROR : Password or login not found.");
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            Login_Check();
        }

        private void textBox_user_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                Login_Check();
        }

        private void textBox_pass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
                Login_Check();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(Resources.LINK_REGISTER);
            Texto.Log("START_REGISTER_LINK");
        }
    }
}
