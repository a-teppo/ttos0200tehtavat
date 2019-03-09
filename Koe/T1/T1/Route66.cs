using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jamk.It.OO
{
    public abstract class Route66
    {
        public abstract int Nopeus { get; }
        public abstract string Rekisterinumero { get; set; }
        public abstract string Merkki { get; set; }
       
        public abstract string NäytäTiedot();

    }

    public class Henkilöauto : Route66
    {
        public string lause;
        public override int Nopeus { get; }
        public override string Rekisterinumero { get; set; }
        public override string Merkki { get; set; }
        public string Malli { get; set; }

        public Henkilöauto(int nopeus) { Nopeus = nopeus; }

        public Henkilöauto(string rekisterinumero, string merkki)
        {
            Merkki = merkki;
            Rekisterinumero = rekisterinumero;
        }

        public Henkilöauto(int nopeus, string rekisterinumero)
        {
            Nopeus = nopeus;
            Rekisterinumero = rekisterinumero;
        }

        public Henkilöauto(int nopeus, string rekisterinumero, string merkki, string malli)
            : this(nopeus, rekisterinumero)
        {
            Merkki = merkki;
            Malli = malli;
        }

        public void ListaaTiedot(List<Henkilöauto>henkilöautot)
        {
            foreach (var item in henkilöautot)
            {
                Console.WriteLine("{0}, {1}, {2}, {3}", item.Merkki, item.Malli, item.Rekisterinumero, item.Nopeus );
            }
        }
       
        public override string NäytäTiedot()
        {
            return $" {Merkki}, {Malli}, {Rekisterinumero}, {Nopeus}";
        }

    }
    public class Kuormaauto : Route66
    {
            public override int Nopeus { get; }
            public override string Rekisterinumero { get; set; }
            public override string Merkki { get; set; }
            public int Paino { get; set; }

      
        public Kuormaauto(int nopeus)
            
        {
            Nopeus = nopeus;
        }

        public Kuormaauto(int nopeus, string rekisterinumero, string merkki, int paino)

        {
            Nopeus = nopeus;
            Rekisterinumero = rekisterinumero;
            Merkki = merkki;
            Paino = paino;
        }


        public override string NäytäTiedot()
            {
                return "moi"; 
            }

        
    }
}
