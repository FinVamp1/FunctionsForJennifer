using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionApp1
{
    class Program
    {
        private int _val;
        public int val
        {
            get
            {
                return val == 10 ? 1 : 0; // the use of a public member causes a Stack Overflow which eventually crashes the process.
            }
            set
            {
                _val = value;
            }
        }


        public void Initialize(int value)
        {
            _val = value;

        }
    }
}
