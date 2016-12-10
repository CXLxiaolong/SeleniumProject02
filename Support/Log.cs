using System;
using System.IO;

namespace Support
{
    public class Log
    {
        private static readonly string LogTime = DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss-ff");//  时间戳 

        public static void DoLog(string logDetail)
        {
            AppendLogfile(logDetail);
        }

        public static void LogException(Exception e)
        {
            AppendLogfile(e.Message);
        }

        private static void AppendLogfile(string value)
        {
            var fileName = LogTime + "-logFile.txt";
            
            //StreamWriter 读写 文件 的类
            //var sw = new StreamWriter(fileName, true)
               /*此构造函数中有两个参数，一个是文件名，另一个是布尔值，这个布尔值规定创建对象的方式如下：
如果此值为false，则创建一个新文件，如果存在原文件，则覆盖。
如果此值为true，则打开文件保留原来数据，如果找不到文件，则创建新文件。
                 */
            using (var sw = new StreamWriter(fileName, true))
            {

                Console.WriteLine(value);
                sw.WriteLine(DateTime.Now.ToString("yyyy-MM-dd-HH:mm:ss") + " - " + value);
            }
        }
    }
}