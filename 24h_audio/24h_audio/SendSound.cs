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

        const uint beepTime = 125;
        const int parseTime = 15;
        const uint highPitch = 1000;
        const uint lowPitch = 50;

        public SendSound()
        {}

        public void createSound(uint soundProfile)
        {
            uint input = (soundProfile == 1 ?highPitch : lowPitch);
            Beep(input, beepTime);
            Thread.Sleep(((int)beepTime));
            Thread.Sleep(parseTime);
        }
    }
}
