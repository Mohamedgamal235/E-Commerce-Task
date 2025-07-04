using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_E_Commerce
{
    class MobileScratchCard : Product
    {
        public MobileScratchCard(string name , double price , int quantity) 
            : base(name , price , quantity) { }
    }
}
