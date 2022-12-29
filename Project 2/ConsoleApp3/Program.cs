using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
         //find perfect number
                int n, i, sum;
                int min, max;
                Console.Write("enter start number : ");
                min = Convert.ToInt32(Console.ReadLine());
                Console.Write("enter end number : ");
                max = Convert.ToInt32(Console.ReadLine());
                Console.Write("The Perfect numbers: ");
                for (n = min; n <= max; n++)
                {
                    i = 1;
                    sum = 0;
                    while (i < n)
                    {
                        if (n % i == 0)
                            sum = sum + i;
                        i++;
                    }
                    if (sum == n)
                        Console.Write("{0} ", n);
                }
              
            }
        }
    }
    

