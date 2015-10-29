//using DrugiImenik;      ako se u imenicima nalaze iste klase doci ce do kolizije

namespace PrviImenik
{
    class Program
    {
        static void Main(string[] args)
        {
            MojaKlasa mk1 = new MojaKlasa();
            mk1.Metoda1();
            DrugiImenik.MojaKlasa mk2 = new DrugiImenik.MojaKlasa();  //ako se u imenicima nalaze iste klase, moramo napisati puno "ime" klase
            mk2.Metoda2();
        }
    }
}
