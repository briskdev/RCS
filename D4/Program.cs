using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Piemers();
            Uzdevums23();

            Console.ReadLine();
        }

        static void Uzdevums23()
        {
            Darbinieks darbinieks = new Darbinieks
            {
                Vards = "Aigars",
                Uzvards = "Liepa",
                Dzivesvieta = new Adrese
                {
                    Valsts = "Latvija",
                    Pilseta = "Rīga",
                    Iela = "Republikas laukums"
                },
                Darbavieta = new Adrese
                {
                    Valsts = "Latvija",
                    Pilseta = "Rīga",
                    Iela = "Brīvības iela"
                }
            };

            darbinieks.Info();
        }

        static void Uzdevums22()
        {
            Aplis a = new Aplis();
            a.Radiuss = 5;
            a.Krasa = "sarkans";

            a.Laukums();
            a.Perimetrs();
            a.KrasasIzvade();
        }

        static void Piemers()
        {
            Kvadrats kv1 = new Kvadrats(5);
            

            int laukums = kv1.laukums();
            int perimetrs = kv1.perimetrs();

            Console.WriteLine("Laukums = {0}", laukums);
            Console.WriteLine("Perimetrs = {0}", perimetrs);

            Kvadrats kv2 = new Kvadrats(10);
            kv2.KonsolesIzvade();

            Kvadrats kv3 = new Kvadrats()
            {
                malasGarums = 5,
                //....
            };

            // tas pats, kas: 
            // Kvadrats kv3 = new Kvadrats();
            // kv3.malasGarums = 5;

            Kvadrats.FigurasNosaukums();

            // statiska: 
            Math.Round(5.1231233);
        }
    }
}
