using Launcher.Packet;
using Launcher.Properties;
using Launcher.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Launcher
{
    public partial class Form_Conect : Form
    {
        private Process[] Process1;
        private Process[] Process2;

        public Form_Conect()
        {
            InitializeComponent();
        }

        private void Form_Conect_Load(object sender, EventArgs e)
        {
            Texto.Log("");
            Texto.Log("LAUNCHER_STARTED_SUCCESS");
            lb_status.Text = Resources.LOADING;
            CheckS();
        }

        private async void CheckS()
        {
            Texto.Log("CHECK_IMPORTANT_FILES_STARTED");
            lb_status.Text = Resources.CHECK_IMPORTANT_FILES;
            await Task.Delay(30);
            Process1 = Process.GetProcessesByName("PBLauncher");
            Process2 = Process.GetProcessesByName("PointBlank");
            if (Process1.Length > 1)
            {
                Texto.Log("DETECTED_LAUNCHER_RUNNING");
                MessageBox.Show(Resources.LAUNCHER_RUNNING, Resources.PROJECT_NAME);
                Close();
            }
            else if (Process2.Length > 0)
            {
                Texto.Log("DETECTED_GAME_RUNNING");
                MessageBox.Show(Resources.GAME_RUNNING, Resources.PROJECT_NAME);
                Close();
            }
            await Task.Delay(20);
            ConectonServerAsync();
        }

        private void ConectonServerAsync()
        {
            Texto.Log("CONNECTING_THE_SERVER");
            lb_status.Text = Resources.CONNECTING_TO_SERVER;
            if (ConectionClient.ConnectToServer())
            {
                Texto.Log("SUCCESSFULLY_CONNECTED");
                //CODIGO DE UPDATE DO LAUNCHER
                StatusCheck();
            }
            else
            {
                Texto.Log("SERVER_CONNECTION_UNKNOWN");
                MessageBox.Show(Resources.SERVER_CONNECTION_UNKNOWN, Resources.PROJECT_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }

        private void StatusCheck()
        {
            Texto.Log("GET_SERVER_STATUS");
            lb_status.Text = Resources.CHECK_SERVER_STATUS;
            try
            {
                //byte[] pacote = ConectionClient.Send(BitConverter.GetBytes((short)120+(string)":"+ (short)ConectionClient.LancherTipo));
                SendPacket.SendUI16(120);
                SendPacket.SendUI16(ConectionClient.LancherTipo);
                SendPacket.SendUI16(01);
                int num = ReadsPacket.readS16(SendPacket.SendAll(), 0);
                //STATUS_REC.StatusLauncher = num;
                if (num == 1 || num == 11 || num == 12)
                {
                    Texto.Log("SERVER_IS_AVAILABLE");
                    CleanTrash();
                    LINK_REC.run();
                }
                else if (num == 2)
                {

                    Texto.Log("SERVER_MAINTENANCE");
                    MessageBox.Show(Resources.SERVER_MAINTENANCE, Resources.PROJECT_NAME);
                    Close();
                }
                else if (num == 0)
                {
                    Texto.Log("SERVER_IS_NOT_AVAILABLE");
                    MessageBox.Show(Resources.SERVER_IS_NOT_AVAILABLE, Resources.PROJECT_NAME);
                    Close();
                }
                else
                    throw new ArgumentNullException();
            }
            catch 
            {
                Texto.Log("SERVER_UNKNOWN_PACKAGE");
                MessageBox.Show(Resources.SERVER_UNKNOWN_PACKAGE, Resources.PROJECT_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }

        private async void CleanTrash()
        {
            /*
            Código para exclusão do anti-pack
            Código para exclusão do anti-pack duplicado
            */
            await Task.Delay(10);
            try
            {
                if (Directory.Exists(string.Concat(Application.StartupPath, "\\_LauncherPatchFiles")))
                {
                    lb_status.Text = Resources.DELET_TRASH;
                    Texto.Log("DELETING_TEMPORARY_FILES");
                    Directory.Delete(string.Concat(Application.StartupPath, "\\_LauncherPatchFiles"), true);
                }
                string[] _files = Directory.GetFiles(Application.StartupPath, "*.PendingOverwrite", SearchOption.AllDirectories);
                foreach (string _file in _files)
                {
                    File.Delete(_file);
                    lb_status.Text = Resources.DELET_TRASH;
                    Texto.Log("DELETING_TEMPORARY_FILES");
                    await Task.Delay(30);
                }
            }
            catch { }
            await Task.Delay(10);
            Form form = new Form_Launcher();
            form.Closed += (s, args) => Close();
            await Task.Delay(20);
            Hide();
            form.Show();
        }
    }
}
