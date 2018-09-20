using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace FunctionApp1
{
    class MyException : Exception
    {
        public MyException()
        {
        }

        public MyException(string message) : base(message)
        {
            message = "This is an instance of my Exception. Now is the time for all men to come to the aid of the party.Now is the time for all men to come to the aid of the party.Now is the time for all men to come to the aid of the party.Now is the time for all men to come to the aid of the party.Now is the time for all men to come to the aid of the party.Now is the time for all men to come to the aid of the party.Now is the time for all men to come to the aid of the party.Now is the time for all men to come to the aid of the party.Now is the time for all men to come to the aid of the party.";
        }

    }
}
