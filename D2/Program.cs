using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D2
{
    class Program
    {
        static void Main(string[] args)
        {
            //MD5();
            Uzdevums11();

            Console.ReadLine();
        }

        static void MD5()
        {
            Console.Write("Ievadi savu vecumu: ");
            int vecums = int.Parse(Console.ReadLine());

            // >=
            // <=
            // <
            // >
            // ==
            // !=
            if (vecums > 18)
            {
                Console.Write("Tu esi pilngadīgs!");
            }
            else if (vecums == 18)
            {
                Console.Write("Tev ir tieši 18!");
            }
            else
            {
                Console.Write("Tu neesi pilngadīgs!");
            }
        }

        static void Uzdevums7()
        {
            Console.Write("Ievadi 1. skaitli: ");
            int sk1 = int.Parse(Console.ReadLine());

            Console.Write("Ievadi 2. skaitli: ");
            int sk2 = int.Parse(Console.ReadLine());

            if (sk1 == sk2)
            {
                Console.Write("Skaitļi ir vienādi!");
            }
            else
            {
                Console.Write("Skaitļi nav vienādi!");
            }

            if (sk1 == sk2 && sk1 == 5)
            {
                // Skaitļi ir vienādi un abi ir 5
            }

            if (sk1 == sk2 || sk1 == 5)
            {
                // Skaitļi ir vienādi vai arī 1. skaitlis ir 5
            }

            // vai :
            // CONDITION ? TRUE : FALSE
            Console.Write(sk1 == sk2 ? "Skaitļi ir vienādi!" : "Skaitļi nav vienādi!");
        }

        static void Uzdevums8()
        {
            // 1. Vaicā ievadīt mēneša nosaukuma pirmos trīs burtus
            Console.Write("Ievadi mēnesi: ");
            // 2. Nolasa ievadīto vērtību
            string menesis = Console.ReadLine();
            // 3. Izvada dienu skaitu atkarībā no vērtības

            // 1. variants:
            if (menesis == "jan")
            {
                Console.Write(31);
            }
            else if (menesis == "feb")
            {
                Console.Write(28);
            }
            else if (menesis == "mar")
            {
                Console.Write(31);
            }
            // utt

            menesis = menesis.ToLower();
            // 2. variants
            if (menesis == "apr" || menesis == "jun" || menesis == "sep" || menesis == "nov")
            {
                Console.Write("30 dienas");
            }
            else if(menesis == "feb")
            {
                Console.Write("28 dienas");
            }
            else
            {
                Console.Write("31 diena");
            }

            // 3. variants
            switch(menesis)
            {
                case "apr":
                case "jun":
                case "sep":
                case "nov":
                    Console.Write("30 dienas");
                    break;
                case "feb":
                    Console.Write("28 dienas");
                    break;
                default:
                    Console.Write("31 diena");
                    break;
            }
        }

        static void Uzdevums9()
        {
            Console.Write("Ievadi valsts nosaukumu: ");
            string valsts = Console.ReadLine();

            Console.Write("Valsts " + valsts + " galvaspilsēta ir ");
            // Console.Write("Valsts {0} galvaspilsēta {1} ", valsts, "ir");

            switch(valsts.ToLower())
            {
                case "igaunija":
                    Console.Write("Tallina");
                    break;
                case "somija":
                    Console.Write("Helsinki");
                    break;
                case "ukraina":
                    Console.Write("Kijeva");
                    break;
                default:
                    Console.Write("Nezināma");
                    break;
            }
            //Igaunija —> Tallina
            //Somija —> Helsinki
            //Ukraina —> Kijeva
            //Zviedrija —> Stokholma
            //Krievija —> Maskava

        }

        static void Uzdevums10()
        {
            // 1. ievada darbību
            Console.Write("Ievadi darbību: ");
            string darbiba = Console.ReadLine();
            // 2. ievada skaitli1
            Console.Write("Ievadi 1. skaitli: ");
            int sk1 = int.Parse(Console.ReadLine());
            // 3. ievada skaitli2
            Console.Write("Ievadi 2. skaitli: ");
            int sk2 = int.Parse(Console.ReadLine());

            // 4. Aprēķina un izvada rezultātu
            switch(darbiba)
            {
                case "+":
                    Console.Write(sk1 + sk2);
                    break;
                case "-":
                    Console.Write(sk1 - sk2);
                    break;
                case "*":
                    Console.Write(sk1 * sk2);
                    break;
                case "/":
                    Console.Write(sk1 / (float)sk2);
                    break;
                default:
                    Console.Write("Neatļauta operācija");
                    break;
            }
        }

        static void Uzdevums11()
        {
            // 1. ievada grādus
            Console.Write("Ievadi grādus: ");
            int gradi = int.Parse(Console.ReadLine());
            // 2. ievada grādu mērvienību
            Console.Write("Ievadi grādu mērvienību: "); // C, K, F
            string m1 = Console.ReadLine();
            // 3. ievada jauno mērvienību
            Console.Write("Ievadi jauno mērvienību: "); // C, K, F
            string m2 = Console.ReadLine();

            switch(m1)
            {
                case "C":
                    switch(m2)
                    {
                        case "K":
                            // no C uz K
                            break;
                        case "F":
                            // no C uz F
                            break;
                    }
                    break;
                case "K":
                    switch (m2)
                    {
                        case "C":
                            // no K uz C
                            break;
                        case "F":
                            // no K uz F
                            break;
                    }
                    break;
                case "F":
                    switch (m2)
                    {
                        case "C":
                            // no F uz C
                            break;
                        case "K":
                            // no F uz K
                            break;
                    }
                    break;
            }
        }
    }
}
