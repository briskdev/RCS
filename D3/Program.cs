using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D3
{
    class Program
    {
        static void Main(string[] args)
        {
            Trijsturis();

            Console.ReadLine();
        }

        static void CikluPiemers()
        {
            Console.Write("Ievadi skaitli: ");
            int skaitlis = int.Parse(Console.ReadLine());

            for (int i = skaitlis; i <= 10; i++)
            {
                // pāriet pie nākamās iterācija
                if (i == 5)
                {
                    continue;
                }

                Console.WriteLine(i);

                // pārtrauktu cikla apstrādi
                //if(i == 5)
                //{
                //   break;
                //}

            }

            Console.Write("Cikla beigas");
        }

        static void Skaitli1Lidz100()
        {
            int summa = 0;

            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i);

                summa = summa + i;
                // summa += i;
            }

            // jāizvada summa
            Console.Write("Summa = {0}", summa);
        }

        static void Gadi()
        {
            Console.Write("Ievadi dzimšanas gadu: ");
            int gads = int.Parse(Console.ReadLine());
            int robeza = DateTime.Now.Year;

            /*
            for (; gads <= robeza; gads++)
            {
                Console.WriteLine(gads);
            }
            */

            while (gads <= robeza)
            {
                Console.WriteLine(gads);
                gads = gads + 1;
                // gads += 1;
                // gads++;
            }
        }

        static void ParaSkaitli()
        {
            // 1. lietotājam vaicā ievadīt skaitli
            Console.Write("Ievadi skaitli N: ");
            // 2. nolasa ievadīto skaitli  N
            int N = int.Parse(Console.ReadLine());
            int summa = 0;
            // 3. cikliski apstrādā vērtības no 1 līdz N ieskaitot
            for (int i = 1; i <= N; i++)
            {
                // 3.1. ja ir pāra skaitlis, tad izvada
                if (i % 2 != 0)
                {
                    continue;
                }

                Console.WriteLine(i);
                summa += i;
            }

            // 4. attēlo izvadīto skaitļu summu
            Console.Write("Summa = {0}", summa);
        }

        static void SkaitluIevade()
        {
            // 1. lietotājs ievada skaitli N
            Console.Write("Cik skaitļu ievadīsi? ");
            int N = int.Parse(Console.ReadLine());
            // 2. cikliski vaicā ievadīt N skaitļus (pa vienam)
            int summa = 0;
            for (int i = 1; i <= N; i++)
            {
                Console.Write("Ievadi {0}. skaitli", i);
                //int sk = int.Parse(Console.ReadLine());
                //summa = summa + sk;
                summa += int.Parse(Console.ReadLine());
            }

            float videja = summa / (float)N;

            // 3. saskaita visus ievadītos skaitļus
            // 4. aprēķina ievadīto skaitļu vidējo vērtību
            Console.Write("Summa = {0}" + " " + "vidēja = {1}", summa, videja);
        }

        static void Rezgis()
        {
            // Ja N = 5:
            //#####
            //#####
            //#####
            //#####
            //#####

            Console.Write("Ievadi skaitli N: ");
            int N = int.Parse(Console.ReadLine());

            for (int rinda = 1; rinda <= N; rinda++)
            {
                for (int kolona = 1; kolona <= N; kolona++)
                {
                    Console.Write("#");
                }

                Console.WriteLine();
            }
        }

        static void Trijsturis()
        {
            Console.Write("Ievadi skaitli N: ");
            int N = int.Parse(Console.ReadLine());

            // Ja N = 3:
            // 123
            // 123
            // 123

            // Pēc tam:
            // 1
            // 12
            // 123

            // Pēc tam:
            // 1      r = 1
            // 12     r = 2
            // 123    r = 3
            // 1234   r = 4
            // 123    r = 3
            // 12     r = 2
            // 1      r = 1

            for (int rinda = 1; rinda <= N; rinda++)
            {
                for (int kolona = 1; kolona <= rinda; kolona++)
                {
                    Console.Write(kolona);
                }

                Console.WriteLine();
            }

            for (int rinda = N - 1; rinda >= 1; rinda--)
            {
                for (int kolona = 1; kolona <= rinda; kolona++)
                {
                    Console.Write(kolona);
                }

                Console.WriteLine();
            }
        }

        static void MinMax()
        {
            int sk1 = 5;
            int sk2 = 10;
            int sk3 = 2123;

            int min;

            if(sk1 < sk2)
            {
                min = sk1;
            }
            else
            {
                min = sk2;
            }

            // NĒEEEEEEE!!!!
            int min = sk1 < sk2 ? (sk1 < sk3 ? sk1 : sk3) : (sk2 < sk3 ? sk2 : sk3);
            int min = Math.Min(sk1, sk2);
        }
    }
}
