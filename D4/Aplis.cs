using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D4
{
    class Aplis
    {
        /// <summary>
        /// Apļa krāsa
        /// </summary>
        public string Krasa;

        /// <summary>
        /// Apļa rādiuss
        /// </summary>
        public int Radiuss;

        public void Perimetrs()
        {
            Console.WriteLine("Apļa perimetrs = {0}", 2 * Math.PI * Radiuss);
        }

        public void Laukums()
        {
            Console.WriteLine("Apļa laukums = {0}", Math.PI * Radiuss * Radiuss);
        }

        public void KrasasIzvade()
        {
            Console.WriteLine("Krāsa = {0}", Krasa);
        }
    }
}
