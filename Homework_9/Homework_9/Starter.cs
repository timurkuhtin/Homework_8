using System;

namespace Homework_9
{
    internal class Starter
    {
        public int Run()
        {
            Actions action = new Actions();
            Result result = new Result();
            Logger logger = new Logger();
            RandomActions randomActions = new RandomActions();
            FileService fileService = new FileService();

            for (int i = 0; i < 100; i++)
            {
                try { randomActions.Go(result); }
                catch (Exception e)
                {
                    if (e is BusinessException businessexception)
                    {
                        logger.doLog((Logger.LogType)2, "Action got this custom Exception :");

                        fileService.Write(logger, e);
                        Console.WriteLine($"Исключение: {e.Message}");
                        Console.WriteLine($"Метод: {e.TargetSite}");
                        Console.WriteLine($"Трассировка стека:\n {e.StackTrace}");
                    }
                    else if (e is Exception exception)
                    {
                        logger.doLog((Logger.LogType)0, "Action failed by reason :");

                        fileService.Write(logger, e);
                        Console.WriteLine($"Исключение: {e.Message}");
                        Console.WriteLine($"Метод: {e.TargetSite}");
                        Console.WriteLine($"Трассировка стека:\n {e.StackTrace}");
                    }
                }                
            }
            return 0;
        }
    }
}
