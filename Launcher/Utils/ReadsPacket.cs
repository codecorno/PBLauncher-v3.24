/*<EQUIPE>
 * Criado por FORCE
 * Force&Kuraio Dev
 * Última modificação: 17/10/2019
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Launcher.Utils
{
    public static class ReadsPacket
    {
        public static short readS16(byte[] _buffer, int _offset)
        {
            short num = BitConverter.ToInt16(_buffer, _offset);
            return num;
        }
        public static int readI32(byte[] _buffer, int _offset)
        {
            int num = BitConverter.ToInt32(_buffer, _offset);
            return num;
        }
        public static long readL64(byte[] _buffer, int _offset)
        {
            long num = BitConverter.ToInt64(_buffer, _offset);
            return num;
        }

        public static string readS(byte[] _buffer, short _offset, int Length)
        {
            string str = "";
            try
            {
                str = Encoding.UTF8.GetString(_buffer, _offset, Length);
                int length = str.IndexOf(char.MinValue);
                if (length != -1)
                    str = str.Substring(0, length);
            }
            catch
            {
            }
            return str;
        }

        public static string readS(byte[] _buffer)
        {
            string str = "";
            try
            {
                str = Encoding.UTF8.GetString(_buffer, 0, _buffer.Length - 0);
                int length = str.IndexOf(char.MinValue);
                if (length != -1)
                    str = str.Substring(0, length);
            }
            catch
            {
            }
            return str;
        }

        public static int readI(byte[] _buffer)
        {
            int strI = -1;
            try
            {
                string str = Encoding.UTF8.GetString(_buffer, 0, _buffer.Length - 0);
                int length = str.IndexOf(char.MinValue);
                if (length != -1)
                    str = str.Substring(0, length);
                strI = Convert.ToInt32(str);
            }
            catch
            {
            }
            return strI;
        }
    }
}
