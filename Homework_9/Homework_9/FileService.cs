using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_9
{
    internal class FileService
    {
        public void Write(Logger logger, Exception exception)
        {
            
            using (TextWriter writer = new StreamWriter($"{DateTime.Now}.txt"))
            {
                DirectoryInfo directoryInfo = new DirectoryInfo(@"c:\logs");
                FileInfo[] fileInfos = directoryInfo.GetFiles();                
                if (fileInfos.Length >= 4)
                {
                    fileInfos = fileInfos.OrderBy(f => f.CreationTime).ToArray();
                    fileInfos[0].ToString();
                    File.Delete(fileInfos[0].ToString());
                }
                File.AppendAllText($"{DateTime.Now}.txt", $"{logger._logTime} {logger.logType} {logger._message} {exception.Message} \n");
            }
        }
        public void Write(Logger logger)
        {

            using (TextWriter writer = new StreamWriter($"{DateTime.Now}.txt"))
            {
                DirectoryInfo directoryInfo = new DirectoryInfo(@"c:\logs");
                FileInfo[] fileInfos = directoryInfo.GetFiles();
                if (fileInfos.Length >= 4)
                {
                    fileInfos = fileInfos.OrderBy(f => f.CreationTime).ToArray();
                    fileInfos[0].ToString();
                    File.Delete(fileInfos[0].ToString());
                }
                File.AppendAllText($"{DateTime.Now}.txt", $"{logger._logTime} {logger.logType} {logger._message}\n");
            }
        }
    }
}
