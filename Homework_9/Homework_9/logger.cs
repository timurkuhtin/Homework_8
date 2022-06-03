using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_9
{
    public class Logger
    {
        public DateTime _logTime;        
        public enum LogType
        {
            Error,
            Info,
            Warning
        }
        public LogType logType;
        public string _message;

        public void doLog(Logger.LogType t, string msg)
        {
            _logTime = DateTime.Now;
            logType = t;
            _message = msg;
        }
    }
}
