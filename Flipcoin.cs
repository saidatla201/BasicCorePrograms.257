using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class Flipcoin
    {
        public static void FlipCoinPercentage()
        {
            int tailCount = 0, headcount = 0;
            Random random = new Random();
            Console.WriteLine("Enter a num of times to flip a coin :");
            int num = Convert.ToInt32(Console.ReadLine());

            for(int i=1;i<=num;i++)
            {
                double input = random.NextDouble();
                if(input < 0.5)
                {
                    tailCount++;
                }
                else
                {
                    headcount++;
                }
            }
            Console.WriteLine("Tail count : {0} & HeadCount : {1}", tailCount, headcount);
            double tailpercentage = (tailCount * 100) / num;
            double headpercentage = (headcount * 100) / num;
            Console.WriteLine("TailCountPercentage is : {0} & HeadCountpercentage is : {1}", tailpercentage, headpercentage);
        }
    }
}
