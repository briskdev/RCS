using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D4
{
    class Kvadrats
    {
        public int malasGarums;

        // Konstruktors
        public Kvadrats(int malasGarums/*, citi parametri... */)
        {
            this.malasGarums = malasGarums;
        }

        public Kvadrats()
        {

        }

        public int laukums()
        {
            return malasGarums * malasGarums;
        }

        public int perimetrs()
        {
            return malasGarums * 4;
        }

        public void KonsolesIzvade()
        {
            Console.WriteLine("Perimetrs = {0}", perimetrs());
            Console.WriteLine("Laukums = {0}", laukums());
        }

        public static void FigurasNosaukums()
        {
            Console.WriteLine("Šis ir kvadrāts!");
        }
    }
}
