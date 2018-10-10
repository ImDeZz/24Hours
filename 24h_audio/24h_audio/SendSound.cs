using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Threading;

namespace _24h_audio
{
    class SendSound
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool Beep(uint dwFreq, uint dwDuration);
        const uint beepTime = 60;
        const int parseTime = 15;

        public SendSound()
        {}

        public void createSound(uint soundProfile)
        {
            uint input = (soundProfile == 1 ?(uint)10000:1000);
            Beep(input, beepTime);
            Thread.Sleep(((int)beepTime));
            Thread.Sleep(parseTime);
        }
    }
}
