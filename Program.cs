using System;

namespace perfect_nombre
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter first nombre");
            int nom1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter seconde nombre");
            int nom2 = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = nom1; i < nom2; i++)
               
            {
                for (int x = 1; x <= i; x++)
                {
                    if (i % x == 0)
                    {
                        sum += x;
                    }

                    if (sum == i)
                    {
                        sum += i;

                        Console.WriteLine(i);
                    }
                   
                }
                return ;
            }
            
        }
        }

    }     
        
    

