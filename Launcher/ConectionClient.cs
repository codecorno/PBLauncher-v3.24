using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Launcher.Utils;
using System.IO;
using Launcher.Properties;

namespace Launcher
{
    class ConectionClient
    {
        public const int LancherTipo = 1;
        public static readonly Socket ClientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        static readonly string chave = "@#VCF#$%VG";

        public static bool ConnectToServer()
        {
            while (!ClientSocket.Connected)
            {
                try
                {
                    //ClientSocket.Connect("127.0.0.1", 39180);
                    ClientSocket.Connect("192.168.0.1", 39181);
                }
                catch
                {
                    return false;
                }
            }
            return true;
        }

        public static byte[] Send(string msg)
        {
            try
            {
                byte[] bufferENV = EncryptData(Encoding.UTF8.GetBytes(msg));
                ClientSocket.BeginSend(bufferENV, 0, bufferENV.Length, SocketFlags.None, new AsyncCallback(SendCallback), ClientSocket);
                var buffer = new byte[2048];
                int received = ClientSocket.Receive(buffer, SocketFlags.None);
                if (received == 0)
                    return null;
                byte[] data = new byte[received];
                Array.Copy(buffer, data, received);
                byte[] text = DecryptData(data);
                if (Encoding.UTF8.GetString(text) == "exit")
                {
                    Texto.Log("SERVER_CONECTION_INTERRUPTED");
                    Process pro = Process.GetCurrentProcess();
                    ClientSocket.Shutdown(SocketShutdown.Both);
                    ClientSocket.Close();
                    MessageBox.Show(Resources.SERVER_CONNECTION_END, Resources.PROJECT_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    pro.Kill();
                    return null;
                }
                else if (Encoding.UTF8.GetString(text) == "?")
                {
                    Texto.Log("SERVER_UNKNOWN_PACKAGE");
                    MessageBox.Show(Resources.SERVER_UNKNOWN_PACKAGE, Resources.PROJECT_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
                else
                    return text;
            }
            catch
            {
                Texto.Log("SERVER_ERROR_CONECTION");
                MessageBox.Show(Resources.SERVER_CONNECTION_END, Resources.PROJECT_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Process pro = Process.GetCurrentProcess();
                pro.Kill();
                throw;
            }
        }

        public static byte[] Send(byte[] packt)
        {
            try
            {
                byte[] bufferENV = EncryptData(packt);
                ClientSocket.BeginSend(bufferENV, 0, bufferENV.Length, SocketFlags.None, new AsyncCallback(SendCallback), ClientSocket);
                var buffer = new byte[2048];
                int received = ClientSocket.Receive(buffer, SocketFlags.None);
                if (received == 0)
                    return null;
                byte[] data = new byte[received];
                Array.Copy(buffer, data, received);
                byte[] text = DecryptData(data);
                if (Encoding.UTF8.GetString(text) == "exit")
                {
                    Texto.Log("SERVER_CONECTION_INTERRUPTED");
                    Process pro = Process.GetCurrentProcess();
                    ClientSocket.Shutdown(SocketShutdown.Both);
                    ClientSocket.Close();
                    MessageBox.Show(Resources.SERVER_CONNECTION_END, Resources.PROJECT_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    pro.Kill();
                    return null;
                }
                else
                    return text;
            }
            catch
            {
                Texto.Log("SERVER_ERROR_CONECTION");
                MessageBox.Show(Resources.SERVER_CONNECTION_END, Resources.PROJECT_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Process pro = Process.GetCurrentProcess();
                pro.Kill();
                throw;
            }

        }

        private static void SendCallback(IAsyncResult ar)
        {
            try
            {
                Socket handler = (Socket)ar.AsyncState;
                if (handler != null && handler.Connected)
                    handler.EndSend(ar);
            }
            catch
            {
                Exit();
            }
        }

        public static void Exit()
        {
            try
            {
                if (ClientSocket.Connected)
                {
                    Send(BitConverter.GetBytes((ushort)100));
                    ClientSocket.Shutdown(SocketShutdown.Both);
                    ClientSocket.Close();
                }
            }
            catch
            {
            }
        }

        public static byte[] EncryptData(byte[] pacote)
        {
            byte[] Results;
            UTF8Encoding UTF8 = new UTF8Encoding();
            MD5CryptoServiceProvider HashProvider = new MD5CryptoServiceProvider();
            byte[] TDESKey = HashProvider.ComputeHash(UTF8.GetBytes(Resources.OBJECT_1));
            TripleDESCryptoServiceProvider TDESAlgorithm = new TripleDESCryptoServiceProvider
            {
                Key = TDESKey,
                Mode = CipherMode.ECB,
                Padding = PaddingMode.PKCS7
            };
            byte[] DataToEncrypt = pacote;
            try
            {
                ICryptoTransform Encryptor = TDESAlgorithm.CreateEncryptor();
                Results = Encryptor.TransformFinalBlock(DataToEncrypt, 0, DataToEncrypt.Length);
            }
            finally
            {
                TDESAlgorithm.Clear();
                HashProvider.Clear();
                TDESAlgorithm.Dispose();
                HashProvider.Dispose();
            }
            return Results;
        }

        public static byte[] DecryptData(byte[] pacote)
        {
            try
            {
                byte[] Results;
                UTF8Encoding UTF8 = new UTF8Encoding();
                MD5CryptoServiceProvider HashProvider = new MD5CryptoServiceProvider();
                byte[] TDESKey = HashProvider.ComputeHash(UTF8.GetBytes(Resources.OBJECT_2));
                TripleDESCryptoServiceProvider TDESAlgorithm = new TripleDESCryptoServiceProvider
                {
                    Key = TDESKey,
                    Mode = CipherMode.ECB,
                    Padding = PaddingMode.PKCS7
                };
                byte[] DataToDecrypt = pacote;
                try
                {
                    ICryptoTransform Decryptor = TDESAlgorithm.CreateDecryptor();
                    Results = Decryptor.TransformFinalBlock(DataToDecrypt, 0, DataToDecrypt.Length);
                }
                finally
                {
                    TDESAlgorithm.Clear();
                    HashProvider.Clear();
                    TDESAlgorithm.Dispose();
                    HashProvider.Dispose();
                }
                return Results;
            }
            catch
            {
                return null;
            }
        }

    }
}
