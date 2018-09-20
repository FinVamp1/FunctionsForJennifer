using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FunctionApp1
{
    class BigStrings
    {
        public BigStrings()
        {
            string initialStr = Guid.NewGuid().ToString();
        }

        public Dictionary<string, string> MyBigString()
        {

            var testDict = new Dictionary<string, string>();

            for (int i = 0; i < 100; i++)
            {
                string dictName= Guid.NewGuid().ToString();
                string dictValue = Guid.NewGuid().ToString();
                testDict.Add(dictName, dictValue);

            }

            return testDict;
        }

        public string MyBigString2()
        {

            var testString = Guid.NewGuid().ToString();

            for (int i = 0; i < 100; i++)
            {
                testString = testString + Guid.NewGuid().ToString();
                string name = "My Name";
            }

            return testString;
        }
    }
}
