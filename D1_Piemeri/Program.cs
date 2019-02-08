using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D1_Piemeri
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, world!");

            //tekstaIzvade();
            //tekstaIzvadeArParametru("teksts no funkcijas parametra");
            //tekstaIevade();
            vecumaIevade();

            Console.Read();

            // komentārs

            /*
             vairākās rindās
             */
        }

        static void tekstaIzvade()
        {
            Console.WriteLine("Funkcijas izvadīts teksts");
        }

        static void tekstaIzvadeArParametru(string teksts)
        {
            Console.WriteLine("Izvade: " + teksts);
        }

        static void tekstaIevade()
        {
            // izvada
            Console.Write("Ievadi savu vārdu: ");
            // ievada
            string vards = Console.ReadLine();

            Console.Write("Ievadi savu uzvārdu: ");
            string uzvards = Console.ReadLine();

            Console.Write("Tevi sauc " + vards + " " + uzvards);
        }

        static void vecumaIevade()
        {
            Console.Write("Ievadi savu vecumu: ");
            //string vecums = Console.ReadLine();

            // int skaitlis = Convert.ToInt32(vecums);
            // vai: 
            int skaitlis = int.Parse(Console.ReadLine()) + 1;
            // skaitlis = skaitlis + 1;
            // vai: 
            // skaitlis += 1;

            Console.Write("Pēc gada tev būs " + skaitlis);
        }
    }
}
