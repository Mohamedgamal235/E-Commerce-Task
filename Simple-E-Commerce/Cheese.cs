using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_E_Commerce
{
    class Cheese : Product , IShippable , IExpirable
    {
        public DateTime ExpireTime { get;  }
        public double Weight { get; }

        public Cheese(string name , double price , int quantity , DateTime expireTime , double weight)
            :base(name , price , quantity)
        {
            ExpireTime = expireTime;
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

        public bool IsExpired()
        {
            return DateTime.Now > ExpireTime;
        }
    }
}
