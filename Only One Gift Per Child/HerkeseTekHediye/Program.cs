using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp7564
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] cocuklar = new string[500];
            int i = 0;
            Boolean kontrol = true;
            while (kontrol)
            {
                Console.Write("İsim giriniz :");
                cocuklar[i] = Console.ReadLine();



                for (int j = 0; j < i; j++)
                {
                    if (cocuklar[j].Equals(cocuklar[i]))
                    {
                        Console.WriteLine("Her çocuk bir defa hediye alabilir!");
                        kontrol = false;
                    }
                }
                i++;

            }
            Console.ReadLine();
        }
    }
}