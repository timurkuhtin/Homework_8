using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_9
{
    internal class Actions
    {
        public Result First()
        {
            Logger logger = new Logger();
            Result results = new Result();
            FileService fileService = new FileService();

            logger.doLog((Logger.LogType)1, "Start method: First\n");

            fileService.Write(logger);

            results.status = true;
            return results;
        }

        public Result Second()
        {
            Logger logger = new Logger();

            logger._logTime = DateTime.Now;

            throw new BusinessException(message: "Skipped logic in method");
        }

        public Result Third()
        {
            Logger logger = new Logger();

            logger._logTime = DateTime.Now;

            throw new Exception(message: "I broke a logic");
        }
    }
}
