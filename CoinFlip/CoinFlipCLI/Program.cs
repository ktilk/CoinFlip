using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinFlipCLI
{
    class Program
    {
        static void Main(string[] args)
        {
            //var userInput = Convert.ToInt64(Console.ReadLine());
            while (long.TryParse(Console.ReadLine(), out long number))
            {
                var startTime = DateTime.Now;
                var results = Services.FlipCoin(number);
                var endTime = DateTime.Now;
                var totalTime = endTime.Subtract(startTime);
                Console.WriteLine(Services.GetResultString(results, totalTime));
            }
        }
    }
}
