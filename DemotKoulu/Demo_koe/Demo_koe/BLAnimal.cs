using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Testikoe
 * https://student.labranet.jamk.fi/~salesa/csharp/exams/19k.html
 * 
 */
namespace JAMK.IT.TTOS0200
{
    public abstract class Nisäkäs
    {
        //abstrakti ominaisuus
        public abstract string Sukupuoli { get; set; }
        public abstract string Nimi { get; set; }
        //abstarkteja metodeja, huom ei siis kirjoiteta minkäälaista toteutusta
        public abstract string Liiku();
        public abstract string Ääntelee();
    }

    public class Kissa : Nisäkäs
    {
        //properties
        public override string Nimi { get; set; }
        public string Väri { get; set; }
        public override string Sukupuoli { get; set; }
        //constructor
        public Kissa() {        }

        public Kissa (string nimi)
        {
            Nimi = nimi;
        }

        public Kissa (string nimi, string väri)
        {
            Nimi = nimi;
            Väri = väri;
        }
        //tai vaihtoehtoisesti
        public Kissa(string nimi, string väri, string sukupuoli) : this(nimi,väri)
        {
            Sukupuoli = sukupuoli;
        }
        //methods
        public override string Liiku()
        {
            //throw new NotImplementedException();
            return "töp töp töp töp töp töp töp töp töp töp";
        }
        public override string Ääntelee()
        {
            return "Miau";
        }
    }
    public class Koira : Nisäkäs
    {
        public override string Nimi { get; set; }
        public override string Sukupuoli { get; set; }

        public override string Liiku()
        {
            throw new NotImplementedException();
        }

        public override string Ääntelee()
        {
            return "Vuh vuh";
        }
    }

}
