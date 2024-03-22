using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ch08Ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            int cnt = 0;
            Write("Please enter desired number to accept names : ");
            cnt = Convert.ToInt16(Console.ReadLine());

            string[] lstnames = new string[cnt];

            WriteLine($"The size of my Array is : {lstnames.Length}");
            WriteLine("Please press any key to continue....");
            Console.ReadKey();

            WriteLine("Please enter the names now...");
            for (int i = 0; i < cnt; ++i)
            {
                Write($"Array[{i}] <= ");
                lstnames[i] = Console.ReadLine();
            }

            WriteLine("\nWe will now display all the names...");
            Console.ReadKey();

            for (int i = 0; i < cnt; i++)
            {
                Write($"Array[{i}] => ");
                WriteLine(lstnames[i]);
            }

            Console.ReadKey();

        }
    }
}
