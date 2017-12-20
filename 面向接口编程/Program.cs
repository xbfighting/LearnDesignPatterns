using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var computer = new Computer();

            IMobileStorage flashDisk = new FlashDisk();
            IMobileStorage mP3Player = new MP3Player();
            IMobileStorage mobileHardDisk = new MobileHardDisk();
            IMobileStorage newMobileStorage = new NewMobileStorage();

            computer.UsbDrive = flashDisk;
            computer.ReadData();
            computer.WriteData();

            computer.UsbDrive = mP3Player;
            computer.ReadData();
            computer.WriteData();

            computer.UsbDrive = mobileHardDisk;
            computer.ReadData();
            computer.WriteData();

            computer.UsbDrive = newMobileStorage;
            computer.ReadData();
            computer.WriteData();


            IMobileStorage superStorageAdapter = new SuperStorageAdapter();
            computer.UsbDrive = superStorageAdapter;
            computer.ReadData();
            computer.WriteData();

        }
    }
}
