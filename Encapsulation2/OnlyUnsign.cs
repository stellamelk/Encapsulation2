using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation2
{
    class OnlyUnsign
    {
        private int _x;

        public int getX()
        {
            return _x;
        }

        public void setX(int x)
        {
            if (x > 0)
            {
                _x = x;
            }
            else
            {
                Console.WriteLine("Please pass the positive value");
            }
        }
    }
}
