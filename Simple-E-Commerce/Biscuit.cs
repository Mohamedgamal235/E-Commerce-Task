using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_E_Commerce
{
    class Biscuit : Product , IExpirable
    {
        public DateTime ExpireTime { get; }
        public Biscuit(string name , double price , int quantity , DateTime expiretime)
            :base(name , price , quantity)
        {
            ExpireTime = expiretime;
        }

        public bool IsExpired()
        {
            return DateTime.Now > ExpireTime;
        }

    }
}
