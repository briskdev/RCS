using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D1_Uzdevumi
{
    class Program
    {
        static void Main(string[] args)
        {
            uzdevums6();

            // lai konsole paliek atvērta
            Console.Read();
        }

        static void uzdevums2()
        {
            Console.Write("Ievadi 1. skaitli: ");
            int sk1 = int.Parse(Console.ReadLine());

            Console.Write("Ievadi 2. skaitli: ");
            int sk2 = int.Parse(Console.ReadLine());

            int summa = sk1 + sk2;
            int starpiba = sk1 - sk2;
            int reizinajums = sk1 * sk2;
            float dalijums = sk1 / (float)sk2;

            Console.WriteLine("Summa = " + summa);
            Console.WriteLine("Starpība = " + starpiba);
            Console.WriteLine("Reizinājums = " + reizinajums);
            Console.WriteLine("Dalījums = " + dalijums);
        }

        static void uzdevums5()
        {
            // Ievade: grādi pēc Celsija
            Console.Write("Ievadi grādus: ");
            float gradi = float.Parse(Console.ReadLine());

            // Izvade: grādi pēc Kelvina
            float gradiK = gradi + 273.15f;
            // Izvade: grādi pēc Fārenheita
            float gradiF = gradi * 9 / 5 + 32;

            Console.WriteLine("Pēc Kelvina: " + gradiK);
            Console.WriteLine("Pēc Fārenheita: " + gradiF);
        }

        static void uzdevums6()
        {
            Console.Write("1. skaitlis: ");
            int sk1 = int.Parse(Console.ReadLine());
            Console.Write("2. skaitlis: ");
            int sk2 = int.Parse(Console.ReadLine());
            Console.Write("3. skaitlis: ");
            int sk3 = int.Parse(Console.ReadLine());
            Console.Write("4. skaitlis: ");
            int sk4 = int.Parse(Console.ReadLine());

            float vid = (sk1 + sk2 + sk3 + sk4) / 4f;

            Console.Write("Vidējā vērtība = " + vid);
        }

        static void MD1()
        {
            Console.WriteLine("  *  ");
            Console.WriteLine(" *** ");
            Console.WriteLine("*****");
        }

        static void MD2()
        {
            Console.Write("Ievadi 1. vārdu: ");
            string vards1 = Console.ReadLine();
            Console.Write("Ievadi 2. vārdu: ");
            string vards2 = Console.ReadLine();
            Console.Write("Ievadi 3. vārdu: ");
            string vards3 = Console.ReadLine();

            Console.Write(vards1 + ", " + vards2 + ", " + vards3);
        }

        static void MD3()
        {
            Console.Write("Ievadi skaitli a: ");
            int a = int.Parse(Console.ReadLine());

            int sk1 = a + 5;
            int sk2 = a += 5;

            Console.WriteLine(a + 5);
            Console.WriteLine(a += 5);
            Console.WriteLine(a -= 3);
            Console.WriteLine(a *= 2);
            a = a + 1;
            Console.WriteLine(a);
            Console.WriteLine(a += 1);
            Console.WriteLine(a++);
        }

        static void MD4()
        {
            Console.Write("Ievadi vārdu: ");
            string vards = Console.ReadLine().ToUpper();
            // vards = vards.ToUpper();

            string lielieBurti = "asdasdasd".ToUpper();

            Console.Write("Jaunais vārds: " + vards);
        }
    }
}
