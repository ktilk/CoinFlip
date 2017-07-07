using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinFlipCLI
{
    public class Services
    {
        public static int[] FlipCoin(long userInput)
        {
            int[] results = new int[2];
            var rnd = new Random();

            for (long i = 0; i < userInput; i++)
            {
                if (rnd.NextDouble() <= 0.5)
                {
                    results[0]++; //add to heads
                    Console.WriteLine(results[1] + results[0] + ". Flipped heads.");
                }
                else
                {
                    results[1]++; //add to tails
                    Console.WriteLine(results[1] + results[0] + ". Flipped tails.");
                }
            }
            return results;
        }

        public static string GetResultString(int[] results, TimeSpan totalTime)
        {
            Console.WriteLine("You flipped heads {0} and tails {1} times. It took {2} minutes {3} seconds {4} milliseconds.", results[0], results[1], totalTime.Minutes, totalTime.Seconds, totalTime.Milliseconds);
            var sb = new StringBuilder();
            sb.Append($"You flipped heads {results[0]} and tails {results[1]} times. It took ");
            if (totalTime.Hours > 0)
            {
                sb.Append(totalTime.Hours + " hours ");
            }

            if (totalTime.Minutes > 0)
            {
                sb.Append(totalTime.Minutes + " minutes ");
            }

            if (totalTime.Seconds > 0)
            {
                sb.Append(totalTime.Seconds + " seconds ");
            }

            if (totalTime.Milliseconds > 0)
            {
                sb.Append(totalTime.Milliseconds + " milliseconds.");
            }
            return sb.ToString();
        }
    }
}
