using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace _24h_audio
{
    class SendSound
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool Beep(uint dwFreq, uint dwDuration);
        public SendSound()
        {

        }

        public void createSound(uint soundProfile)
        {
            Console.WriteLine("Testing PC speaker...");
            
            Beep(soundProfile, 14);
            
            Console.WriteLine("Testing complete.");
        }
    }
}
