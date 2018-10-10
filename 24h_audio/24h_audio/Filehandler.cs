using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24h_audio {
    class Filehandler {
        List<Byte> bytes = new List<Byte>();
        List<Byte> mybytes = new List<Byte>();
        string filename;
        public Filehandler(string file) {
            filename = file;
        }

        public void toBytes() {
            byte[] bytearray=File.ReadAllBytes(filename);
            for(int i=0; i < bytearray.Length; i++) {
                bytes.Add(new Byte(bytearray[i]));
                mybytes.Add(new Byte(bytearray[i]));
            }
        }

        public void toFile(string file) {
            byte[] bytearray = new byte[bytes.Count()];
            int i = 0;
            mybytes.ForEach(x => {
                bytearray[i] = toByte(x.getByte());
                Console.Out.WriteLine(bytearray[i]);
                i++;
            });
            File.WriteAllBytes(file, bytearray);
        }

        private byte toByte(uint[] bitarray) {
            uint ub=0;
            for(int i = 0; i < 8; i++) {
                ub += bitarray[7 - i] * (uint)Math.Pow((double)2, (double)i);
            }
            return (byte)ub;
        }

        public uint[] getNextByte() {
            if (bytes.Count() > 0) {
                Byte next = bytes.First();
                bytes.Remove(next);
                return next.getByte();
            } else {
                return null;
            }
        }
    }
}
