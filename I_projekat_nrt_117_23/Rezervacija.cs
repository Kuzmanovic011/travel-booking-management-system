using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace I_projekat_nrt_117_23
{
    [Serializable]
    public class Rezervacija
    {
        private
            int idKorisnika, idIzleta, brojRezMesta;
            double ukupnaCena;
            DateTime datumRezervacije;
        public
            Rezervacija()
        {
            this.idKorisnika = 0;
            this.idIzleta = 0;
            this.brojRezMesta = 0;
            this.ukupnaCena = 0;
            this.datumRezervacije = DateTime.MinValue; //podrazumevana vrednost datuma
        }

        public Rezervacija(int idKorisnika, int idIzleta, int brojRezMesta, double ukupnaCena, DateTime datumRezervacije)
        {
            this.idKorisnika = idKorisnika;
            this.idIzleta = idIzleta;
            this.brojRezMesta = brojRezMesta;
            this.ukupnaCena = ukupnaCena;
            this.datumRezervacije = DateTime.Now;
        }

        public int IdKorisnika { 
            get { return this.idKorisnika; }
            set { this.idKorisnika = value; }
        }

        public int IdIzleta {
            get { return this.idIzleta; }
            set { this.idIzleta = value; }
        }

        public int BrojRezMesta {
            get { return this.brojRezMesta; }
            set { this.brojRezMesta = value; }
        }

        public double UkupnaCena
        {
            get { return this.ukupnaCena; }
            set { this.ukupnaCena = value; }
        }

        public DateTime DatumRezervacije {
            get { return this.datumRezervacije; }
            set { this.datumRezervacije = value; }
        }

    }
}
