using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24h_audio {
    class Byte {
        private uint[] bites=new uint[8]; 
        public Byte(byte bitesarray) {
            bites=toBites(bitesarray);
        }

        private uint[] toBites(byte b) {
            uint[] bitarray= new uint[8];
            uint ub = b;
            for(int i = 7; i >= 0; i--) {
                bitarray[7-i] = ub / (uint)Math.Pow((double)2, (double)i);
                ub = ub % (uint)Math.Pow((double)2, (double)i);
            }
            return bitarray;
        }

        public uint[] getByte() {
            return bites;
        }
    }
}
