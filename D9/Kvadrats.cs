using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D9
{
    class Kvadrats : Taisnsturis
    {
        public Kvadrats(double mala) : base(mala, mala)
        {

        }

        public override string Nosaukums()
        {
            return "Kvadrāts";
        }
    }
}
