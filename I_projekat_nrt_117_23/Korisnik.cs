using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I_projekat_nrt_117_23
{
    [Serializable]
    public class Korisnik
    {
      private
          int id;
          string ime, prezime, korisnickoIme, lozinka, vrstaKorisnika;

        //kontruktori i metode get i set
        public Korisnik()
        {
            this.id = 0;
            this.ime = null;
            this.prezime= null;
            this.korisnickoIme= null;
            this.lozinka= null;
            this.vrstaKorisnika = null;
        }
        public Korisnik(int id, string ime, string prezime, string korisnickoIme, string lozinka, string vrstaKorisnika)
        {
            this.id = id;
            this.ime = ime;
            this.prezime = prezime;
            this.korisnickoIme = korisnickoIme;
            this.lozinka = lozinka;
            this.vrstaKorisnika = vrstaKorisnika;
        }

        public int Id { 
            get { return this.id; }
            set { this.id = value; }
        }

        public string Ime { 
            get { return this.ime; } 
            set { this.ime = value; }
        }

        public string Prezime { 
            get { return this.prezime; }
            set { this.prezime = value; }
        }

        public string KorisnickoIme {
            get { return this.korisnickoIme; }
            set { this.korisnickoIme = value; }
        }

        public string Lozinka { 
            get { return this.lozinka; }
            set { this.lozinka = value; }
        }

        public string VrstaKorisnika {
            get { return this.vrstaKorisnika; }
            set { this.vrstaKorisnika = value; }
        }

    }
}
