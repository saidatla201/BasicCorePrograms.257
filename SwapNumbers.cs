﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class SwapNumbers
    {
        public static void SwapTwoNum()
        {

            int num1, num2, temp;
            Console.WriteLine("Enter the first number: "); //4
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number: "); //6
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Before Swapping :\nFirst Number: {0} & Second Number: {1}", num1, num2);

            temp = num1; //temp = 4
            num1 = num2; //num1 = 6
            num2 = temp; //num2 = 4

            Console.WriteLine("After Swapping :\nFirst Number: {0} & Second Number: {1}", num1, num2);

        }
    }
}
