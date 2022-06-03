using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_9
{
    internal class RandomActions
    {
        public Result Go(Result result)
        {
            Actions action = new Actions();
            int r = new Random().Next(1, 4);
            switch (r)
            {
                case 1:
                    result = action.First();
                    break;
                case 2:
                    result = action.Second();
                    break;
                case 3:
                    result = action.Third();
                    break;
            }
            return result;
        }
    }
}
