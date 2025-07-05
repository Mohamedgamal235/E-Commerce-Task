using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_E_Commerce
{
    class TV : Product , IShippable
    {
        public double Weight { get; }

        public TV(string name , double price , int quantity , double weight)
            :base(name , price , quantity)
        {
            Weight = weight; 
        }

        public string GetName()
        {
            return Name ;
        }

        public double GetWeight()
        {
            return Weight;
        }
    }
}
