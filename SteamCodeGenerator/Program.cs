using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteamCodeGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            Console.Write("Kérlek add meg hány db kódot generáljak: ");
            ulong db = Convert.ToUInt64((Console.ReadLine()));

            for (ulong i = 0; i < db; i++)
            {
                string code = "\n";
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 5; k++)
                    {
                        if (r.Next(10) < 5)
                        {
                            char random = (char)r.Next('A', 'Z' + 1);
                            code += random;
                        }
                        else
                        {
                            int random = r.Next(10);
                            code += random;
                        }
                    }
                    if (j < 2)
                    {
                        code += "-";
                    }
                }
                Console.WriteLine(code);
            }
            Console.ReadLine();
        }
    }
}
