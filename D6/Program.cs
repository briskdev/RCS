using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D6
{
    class Program
    {
        static void Main(string[] args)
        {
            skaitli5();

            Console.ReadLine();
        }

        static void piemers()
        {
            int sk1;
            int sk2;

            int[] skaitli = new int[5]; // masīvs ar 5 elementiem - int
            skaitli[0] = 1;
            skaitli[1] = 2;
            skaitli[2] = 3;
            skaitli[3] = 4;
            skaitli[4] = 5;
            // izmetīs kļūdu - IndexOutOfRange
            // skaitli[5] = 6;

            int skaitlis = skaitli[3]; // 4

            for(int i = 0; i < skaitli.Length; i++)
            {
                int vertiba = skaitli[i];
                Console.WriteLine(vertiba);
            }

            // foreach (... in masivs)
            foreach(int vertiba in skaitli)
            {
                Console.WriteLine(vertiba);
            }
        }

        static void uzdevums25()
        {
            Console.Write("Ievadi skaitli: ");
            int sk = int.Parse(Console.ReadLine());
            int[] masivs = { 0, 10, 20, 30, 10, 50 };

            bool irAtrasts = false;
            for(int i = 0; i < masivs.Length; i++)
            {
                if(masivs[i] == sk)
                {
                    Console.WriteLine("Skaitlis ir atrasts pozīcijā {0}", i);
                    irAtrasts = true;
                    break;
                }
            }

            // if(irAtrasts == false)
            if(!irAtrasts)
            { 
                Console.WriteLine("Skaitlis nav masīvā!");
            }

            irAtrasts = masivs.Contains(sk);
        }

        static void preteji()
        {
            int skaits = 10;
            int[] masivs = new int[skaits];

            // ievade: 
            for(int i = 0; i < masivs.Length; i++)
            {
                Console.Write("Ievadi skaitli: ");
                masivs[i] = int.Parse(Console.ReadLine());
            }

            // izvadi:
            for(int i = masivs.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(masivs[i]);
            }
        }

        static void pretejiSaraksts()
        {
            List<int> saraksts = new List<int>();

            while(true)
            {
                Console.Write("Ievadi skaitli (vai 0, lai pārtrauktu): ");
                string vertiba = Console.ReadLine();
                if(String.IsNullOrEmpty(vertiba))
                {
                    break;
                }

                int skaitlis = int.Parse(vertiba);
                if(skaitlis == 0)
                {
                    break;
                }
                saraksts.Add(skaitlis);
            }

            //int elementuSkaits = saraksts.Count;
            saraksts.Reverse();
            Console.WriteLine(String.Join(", ", saraksts));
        }

        static void skaitli5()
        {
            // Skaitļu ievade:
            List<int> skaitli = new List<int>();
            while(true)
            {
                Console.Write("Ievadi skaitli (vai tukšu, lai pārtrauktu): ");
                string vertiba = Console.ReadLine();
                if(String.IsNullOrEmpty(vertiba))
                {
                    break;
                }

                skaitli.Add(int.Parse(vertiba));
            }

            // Skaitīšana: 
            // 1. variants
            int skaits = 0;
            foreach(int skaitlis in skaitli)
            {
                if(skaitlis == 5)
                {
                    skaits++;
                    // skaits += 1;
                    // skaits = skaits + 1;
                }
            }
            Console.WriteLine("Skaitlis 5 atrasts {0} reizes", skaits);

            // 2. variants
            skaits = skaitli.Count(skaitlis => skaitlis == 5);
            Console.WriteLine("Skaitlis 5 atrasts {0} reizes", skaits);
        }
    }
}
