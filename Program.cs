using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_part3
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            

            //Write a program that prints first 10 numbers in the fibonacci series.
            int n = 10;
            int num1 = 0, num2 = 1;
            Console.WriteLine("First 10 numbers in fibonacci series");
            for(int a=0; a<n; a++)
            {
                Console.WriteLine(num1);
                int temp = num1;
                num1 = num2;
                num2 = temp + num2;
            }


            

            Console.ReadKey();
            }
        }
    }

