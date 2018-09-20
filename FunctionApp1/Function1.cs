using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Azure.WebJobs.Host;
using FunctionApp1;
using System;
using System.Text;
using System.Runtime.InteropServices;

namespace FunctionApp1
{
    public static class Function1
    {
        static event EventHandler Evil;
        static BigStrings myBigStr1 = new BigStrings();
        [FunctionName("Function1")]
        public static async Task<HttpResponseMessage> Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)]HttpRequestMessage req, TraceWriter log)
        {
            log.Info("C# HTTP trigger function processed a request.");

                var myBigStr1 = new BigStrings();
                var myFuncDict1 = myBigStr1.MyBigString();
                var myBigStr2 = myBigStr1.MyBigString2();

            var testBitmapCls = new BuildImage();
            var testBitMap = testBitmapCls.FinImageTest("finimage.jpg");

            string name1 = "Testsdkghsdjkhgkjsdhgkjshg;jsdhg;jsdfhg;jshdgjhsfd;jghds;kjghdf;sghsldfgjlsdkfhfsldkhg";
            byte[] nameinbyte = ASCIIEncoding.ASCII.GetBytes(name1);
            // Pin down the byte array
            GCHandle handle = GCHandle.Alloc(nameinbyte, GCHandleType.Pinned);
            for (int i = 0; i < 10; i++)
            {
                Evil += delegate { };
            }
            return req.CreateResponse(HttpStatusCode.OK, "Hello ");
        }
    }
}
