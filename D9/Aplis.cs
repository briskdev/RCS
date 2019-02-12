using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D9
{
    class Aplis : IGeometriskaFigura
    {
        public double Radiuss;

        public Aplis(double radiuss)
        {
            Radiuss = radiuss;
        }

        public double Laukums()
        {
            return Math.PI * Radiuss * Radiuss;
        }

        public string Nosaukums()
        {
            return "Aplis";
        }

        public double Perimetrs()
        {
            return 2 * Math.PI * Radiuss;
        }
    }
}
