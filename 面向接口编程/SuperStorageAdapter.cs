using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    public class SuperStorageAdapter : IMobileStorage
    {
        public SuperStorageAdapter()
        {
            superStorage = new SuperStorage();
        }
        public SuperStorage superStorage { get; set; }

        public void Read()
        {
            this.superStorage.ReadEx();
        }

        public void Write()
        {
            this.superStorage.WriteEx();
        }
    }
}
