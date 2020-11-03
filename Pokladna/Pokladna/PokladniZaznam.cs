using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokladna
{
 public class PokladniZaznam
 {
  public int IdPokladniZaznam { get; set; }
  public int Cislo { get; set; }
  public DateTime Datum { get; set; }
  public string Popis { get; set; }
  public double Castka { get; set; }
  public double Zustatek { get; set; }
  public string Poznamka { get; set; }
        public int V1 { get; }
        public int V2 { get; }
        public DateTime DateTime { get; }
        public string V3 { get; }
        public double V4 { get; }
        public double V5 { get; }
        public string V6 { get; }

        public PokladniZaznam()
  {
  }

  public PokladniZaznam(int idPokladniZaznam, int cislo, object v, DateTime datum, string popis, double castka, double zustatek, string poznamka)
  {
   IdPokladniZaznam = idPokladniZaznam;
   Cislo = cislo;
   Datum = datum;
   Popis = popis;
   Castka = castka;
   Zustatek = zustatek;
   Poznamka = poznamka;
  }

  public PokladniZaznam(DateTime datum, string popis, double castka, string poznamka)
  {
   IdPokladniZaznam = -1;
   Cislo = -1;
   Datum = datum;
   Popis = popis;
   Castka = castka;
   Zustatek = -1;
   Poznamka = poznamka;
  }

        public PokladniZaznam(int v1, int v2, DateTime dateTime, string v3, double v4, double v5, string v6)
        {
            V1 = v1;
            V2 = v2;
            DateTime = dateTime;
            V3 = v3;
            V4 = v4;
            V5 = v5;
            V6 = v6;
        }

        public ListViewItem DoLvItem()
  {
   if (Castka > 0)
   {
    return new ListViewItem(new string[] { Datum.ToString("dd.MM.yyyy")
                                         , Cislo.ToString()
                                         , Popis
                                         , Castka.ToString()
                                         , ""
                                         , Zustatek.ToString()
                                         , Poznamka });
   }
   else
   {
    return new ListViewItem(new string[] { Datum.ToString("dd.MM.yyyy")
                                         , Cislo.ToString()
                                         , Popis
                                         , ""
                                         , Math.Abs(Castka).ToString()
                                         , Zustatek.ToString()
                                         , Poznamka });
   }
  }
 }
}
