using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D5
{
    class Program
    {
        static void Main(string[] args)
        {
            string vards = "AKA";

            int pozA = vards.IndexOf("A"); // 0
            pozA = vards.IndexOf("A", 0+1); // 2
            pozA = vards.IndexOf("A", 2 + 1); // -1

            dalisana();

            Console.ReadLine();
        }

        static void dalisana()
        {
            Console.Write("Ievadi skaitli: ");
            int N = int.Parse(Console.ReadLine());

            if(N % 3 == 0)
            {
                Console.WriteLine("Skaitlis dalās ar 3");
            }
            else
            {
                Console.WriteLine("Skaitlis nedalās ar 3");
            }
        }

        static void dilstosaVirkne()
        {
            Console.Write("Ievadi skaitli: ");
            int N = int.Parse(Console.ReadLine());

            for(int i = N; i >= 1; i--)
            {
                Console.Write(i);

                if(i > 1)
                {
                    Console.Write(", ");
                }
            }
        }

        static void iznemot5()
        {
            Console.Write("Ievadi skaitli: ");
            int N = int.Parse(Console.ReadLine());

            for(int i = 1; i <= N; i++)
            {
                // 1. variants
                if(i == 5)
                {
                    continue;
                }

                Console.WriteLine(i);

                // 2. variants
                // if(i != 5)
                // {
                //    Console.WriteLine(i);
                // }
            }
        }

        static void modinatajs()
        {
            Console.Write("Ievadi nedēļas dienu: ");
            string diena = Console.ReadLine();

            Console.Write("Vai ir atvaļinājums: ");
            string atvalinajums = Console.ReadLine();

            switch(diena)
            {
                case "P":
                case "O":
                case "T":
                case "C":
                case "Pk":
                    // 1. variants:
                    if(atvalinajums == "J")
                    {
                        Console.Write("10:00");
                    }
                    else
                    {
                        Console.Write("07:00");
                    }

                    // 2. variants:
                    // Console.Write(atvalinajums == "J" ? "10:00" : "07:00");
                    break;
                case "Se":
                case "Sv":
                    Console.Write(atvalinajums == "J" ? "Off" : "10:00");
                    break;
                default:
                    Console.Write("Neatļauta vērtība");
                    break;
            }
        }

        static void fizzBuzz()
        {
            Console.Write("Ievadi skaitli A:");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Ievadi skaitli B:");
            int b = int.Parse(Console.ReadLine());

            if (b < a)
            {
                Console.Write("Nekorektas vērtības");
            }
            else
            {
                for (int i = a; i <= b; i++)
                {
                    // ja dalās ar 3 un ar 5 -> FizzBuzz
                    if (i % 3 == 0 && i % 5 == 0)
                    {
                        Console.WriteLine("FizzBuzz");
                    }
                    // ja dalās ar 3 -> Fizz
                    else if (i % 3 == 0)
                    {
                        Console.WriteLine("Fizz");
                    }
                    // ja dalās ar 5 -> Buzz
                    else if (i % 5 == 0)
                    {
                        Console.WriteLine("Buzz");
                    }
                    // citādi -> skaitlis 
                    else
                    {
                        Console.WriteLine(i);
                    }

                    // 2. variants
                    if(i % 3 == 0)
                    {
                        Console.Write("Fizz");
                    }
                    if (i % 5 == 0)
                    {
                        Console.Write("Buzz");
                    }
                    else if(i % 3 != 0)
                    {
                        Console.Write(i);
                    }
                    Console.WriteLine();
                }
            }
        }

        static void dzerieni()
        {
            Console.WriteLine("Pieejamās darbības: ");
            Console.WriteLine("1 - iemaksāt");
            Console.WriteLine("2 - pirkt");
            Console.WriteLine("3 - saņemt atlikumu");
            Console.WriteLine("e - pārtraukt");

            DzerienuAutomats dzerienu = new DzerienuAutomats();

            while(true)
            {
                Console.Write("Ievadi darbību: ");
                string darbiba = Console.ReadLine();

                switch(darbiba)
                {
                    case "e":
                        return; // pārtrauc gan switch, gan while
                    case "1":
                        Console.Write("Ievadi summu: ");
                        double summa = double.Parse(Console.ReadLine());

                        dzerienu.Iemaksat(summa);
                        break;
                    case "2":
                        dzerienu.PirktDzerienu();
                        break;
                    case "3":
                        dzerienu.SanemtAtlikumu();
                        break;
                }
            }
        }
    }
}
