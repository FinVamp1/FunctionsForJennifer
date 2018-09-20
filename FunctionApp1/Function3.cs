using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Azure.WebJobs.Host;

namespace FunctionApp1
{
    public static class Function3
    {
        [FunctionName("Function3")]
        public static async Task<HttpResponseMessage> Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)]HttpRequestMessage req, TraceWriter log)
        {
            log.Info("C# HTTP trigger function processed a request.");
                var myBigStr2 = new BigStrings();
                var myFuncDict2 = myBigStr2.MyBigString();
                var myBigString2 = myBigStr2.MyBigString2();

            var testBitmapCls = new BuildImage();
            var testBitMap = testBitmapCls.FinImageTest("finimage3.jpg");
            string name = "Testsdkghsdjkhgkjsdhgkjshg;jsdhg;jsdfhg;jshdgjhsfd;jghds;kjghdf;sghsldfgjlsdkfhfsldkhg";
            byte[] nameinbyte = ASCIIEncoding.ASCII.GetBytes(name);
            // Pin down the byte array
            GCHandle handle = GCHandle.Alloc(nameinbyte, GCHandleType.Pinned);
            throw new MyException();

        }
    }
}
