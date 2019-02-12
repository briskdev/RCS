using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karatavas
{
    public class Karatavas
    {
        private string minamaisVards;
        private string[] atminetaisVards;
        private string[] vardnica =
        {
            "KROKODILS",
            "OLA",
            "BIEZPIENMAIZE",
        };

        public Karatavas()
        {

        }

        public void SaktSpeli()
        {
            // 1. Aizpilda minamaisVards ar izvēlēto vārdu
            Random rnd = new Random();
            int pozicija = rnd.Next(vardnica.Length);
            minamaisVards = vardnica[pozicija];

            // 2. atminetaisVards aizpilda ar '*' tik, cik vārdā burtu
            atminetaisVards = new string[minamaisVards.Length];

            // .... cikls, kurš strādā minamaisVards.Length reizes
            // .... pozīcija i liek '*'
            for(int i = 0; i < minamaisVards.Length; i++)
            {
                atminetaisVards[i] = "*";
            }
        }

        public bool IrAtminets()
        {
            // 1. Nosaka un atgriež, vai vārds ir pilnīgi atminēts
            // atgriež true / false

            // ... cikls, kurš strādā atminetaisVards.Length reizes
            // ... ja ir kāds '*', tad atgriež false
            foreach(string simbols in atminetaisVards)
            {
                if(simbols == "*")
                {
                    return false;
                }
            }

            return true;

            // 2.variants:
            // return !atminetaisVards.Contains("*");
        }

        public bool Minet(string burts)
        {
            if(String.IsNullOrEmpty(burts))
            {
                return false;
            }

            burts = burts.ToUpper();

            // 1. Atgriež false, ja burts nav vārdā
            if (!minamaisVards.Contains(burts))
            {
                return false;
            }
            // 2. Atgriež true, ja burts ir vārdā. 
            // ... minamaisVards.Contains()

            //    Aizvieto minamaisVards simbolu '*' ar burtu konkrētajā pozīcija
            // ... minamaisVards.IndexOf()

            
            int pozicija = minamaisVards.IndexOf(burts);
            while(pozicija != -1)
            {
                atminetaisVards[pozicija] = burts;
                pozicija = minamaisVards.IndexOf(burts, 1 + pozicija);
            }

            return true;
        }

        public string Vards()
        {
            // 1. Atgriež minamaisVards kā tekstu (string)
            // ... foreach()

            // 1. variants
            // string teksts = "";
            // foreach (var burts in atminetaisVards)
            // {
            //      teksts += burts;
            // }
            // return teksts;

            // 2. variants
            return String.Join(" ", atminetaisVards);
        }
    }
}
