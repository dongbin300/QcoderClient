using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Qcoder
{
    public class Client
    {
        public Client()
        {

        }

        public static void WriteErrorLog(string errorMessage)
        {
            using (FileStream fs = new FileStream("error_log.txt", FileMode.Append))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.WriteLine($"{DateTime.Now} => {errorMessage}");
                    sw.Flush();
                }
            }
        }

        public static string GenerateErrorMessage(System.Diagnostics.StackTrace trace, Exception ex)
        {
            string[] path = trace.GetFrame(0).GetFileName().Split('\\');
            string currentFileName = path[path.Length - 1];
            string currentMethod = trace.GetFrame(0).GetMethod().Name;
            string errorMessage = $"{currentFileName}.{currentMethod} {ex.Message}";
            return errorMessage;
        }
    }
}
