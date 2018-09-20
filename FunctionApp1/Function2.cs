using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Azure.WebJobs.Host;
using System;
using System.Text;
using System.Runtime.InteropServices;

namespace FunctionApp1
{
    public static class Function2
    {
        static BigStrings myBigStr2 = new BigStrings();
        static event EventHandler Evil;
        [FunctionName("Function2")]
        public static async Task<HttpResponseMessage> Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)]HttpRequestMessage req, TraceWriter log)
        {

            log.Info("C# HTTP trigger function processed a request.");

                var myBigStr2= new BigStrings();
                var myFuncDict2 = myBigStr2.MyBigString();
                var myBigString2 = myBigStr2.MyBigString2();

            string name2 = "Testsdkghsdjkhgkjsdhgkjshg;jsdhg;jsdfhg;jshdgjhsfd;jghds;kjghdf;sghsldfgjlsdkfhfsldkhg";
            byte[] nameinbyte2 = ASCIIEncoding.ASCII.GetBytes(name2);
            // Pin down the byte array
            GCHandle handle = GCHandle.Alloc(nameinbyte2, GCHandleType.Pinned);
            for (int i = 0; i < 10; i++)
            {
                Evil += delegate { };
            }

            Program p = new Program();
            p.Initialize(10);
            var testStr = p.val.ToString();

            return req.CreateResponse(HttpStatusCode.OK, "Hello ");
        }
    }
}
