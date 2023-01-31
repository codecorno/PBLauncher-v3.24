using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Launcher.Utils
{
    class SendPacket
    {
        static List<byte> ByteList = new List<byte>();
        static List<byte> ByteListLength = new List<byte>();

        public static bool SendUI16(short msg)
        {
            ByteListLength.AddRange(BitConverter.GetBytes(msg));
            return true;
        }

        public static bool SendS(string msg)
        {
            ByteListLength.AddRange(BitConverter.GetBytes(msg.Length));
            ByteList.AddRange(Encoding.UTF8.GetBytes(msg));
            return true;
        }

        public static byte[] SendAll()
        {
            byte[] data = null; 
            List<byte> ByteListAll = new List<byte>();
            try
            {
                ByteListAll.AddRange(ByteListLength.ToArray());
                ByteListAll.AddRange(ByteList.ToArray());
                data = ConectionClient.Send(ByteListAll.ToArray());
            }
            finally
            {
                ByteList.Clear();
                ByteListLength.Clear();
                ByteListAll.Clear();
            }
            return data;
        }
    }
}
