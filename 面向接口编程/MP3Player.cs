using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    public class MP3Player : IMobileStorage
    {
        public void Read()
        {
            Console.WriteLine("Reading from MP3Player...");
            PlayMusic();
            Console.WriteLine("Read finished!");
        }

        public void Write()
        {
            Console.WriteLine("Writing to MP3Player...");
            Console.WriteLine("Write finished!");
        }

        public void PlayMusic()
        {
            Console.WriteLine("Music is playing...");
        }
    }
}
