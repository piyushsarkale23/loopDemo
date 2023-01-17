using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
  
            //wap to print 1 to 10
            
            int a = 1;
            while (a<=10)
            {
                Console.WriteLine(a);
                a++;
            }

            //wap to print numbers from 1 to 50
            int t = 1; 
             while (t<=50) {
                 Console.WriteLine(t);
                 t++;
             }

            // wap to print odd numbers from 1 to 50
           int m = 1;
           while ( m <= 50)
           {

                if (m%2!=0)
               {
                    
                   Console.WriteLine(m);
                   
               }

                m++;
            }
            //wap to print 100-50
            int j = 100;
            while (j>=50)
            {
                Console.WriteLine(j);
                j--;
            }

            //wap to print table
           Console.WriteLine("Enter a number:-");
           int num = Convert.ToInt32(Console.ReadLine());
           int i = 1;
           while(i<=10)
           {
               int table = num * i;
               Console.WriteLine($"{num} * {i} = {table}");
                i++;
           }
            

            //wap to print 1 to 10 and its sum
            int sum = 0;
            int b = 1;
            while ( b <= 10)           
            {

                sum = sum + b;
                b++;

            }

            Console.WriteLine(sum);
            b++;
            }

    }
}
