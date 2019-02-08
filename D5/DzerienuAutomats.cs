using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D5
{
    public class DzerienuAutomats
    {
        // Īpašība “IemaksataSumma” (double);
        private double IemaksataSumma;

        // b.Konstruktors bez parametriem
        public DzerienuAutomats()
        {
            // , kas uzstāda iemaksāto summu uz 0;
            IemaksataSumma = 0;
        }

        // c.Metode “Iemaksat”, kas saņem vienu vērtību “summa”
        public void Iemaksat(double summa)
        {
            // un pieskaita šo vērtību iemaksātajai summai;
            IemaksataSumma += summa;

            Console.WriteLine("Atlikums = EUR {0}", IemaksataSumma);
        }

        // d.Metode “PirktDzerienu”, 
        public void PirktDzerienu()
        {
            // kas pārbauda, vai ir iemaksāti vismaz EUR 0.80:
            if (IemaksataSumma >= 0.8)
            {
                // * ja ir, tad samazina iemaksāto summu par 0.80 un izvada atlikumu;
                IemaksataSumma -= 0.8;
                Console.WriteLine("Iegādāts dzēriens! Atlikums = EUR {0}", IemaksataSumma);
            }
            else
            {
                // * ja nav, tad izvada paziņojumu “Nepietiek līdzekļu.”;
                Console.WriteLine("Nepietiek līdzekļu!");
            }
        }

        // e.Metode “SanemtAtlikumu”
        public void SanemtAtlikumu()
        {
            Console.WriteLine("Tu saņēmi EUR {0}", IemaksataSumma);
            IemaksataSumma = 0;
        }
    }
}
