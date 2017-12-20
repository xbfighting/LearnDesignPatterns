using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    public class Computer
    {
        public IMobileStorage UsbDrive { get; set; }

        public Computer()
        {
        }

        public Computer(IMobileStorage usbDrive)
        {
            UsbDrive = usbDrive;
        }

        public void ReadData()
        {
            this.UsbDrive.Read();
        }

        public void WriteData()
        {
            this.UsbDrive.Write();
        }
    }
}
