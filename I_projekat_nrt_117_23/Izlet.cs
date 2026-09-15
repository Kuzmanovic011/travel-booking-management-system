using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I_projekat_nrt_117_23
{
    [Serializable]
    public class Izlet //klasa izlet
    {
       private //privatni atributi klase
        int id, brojDana, ukupnoMesta;
        double cena, popust;
        DateTime datum;
        string mesto, drzava;

        //konstruktori metode klase, geteri i seteri...
        public Izlet()
        {
            this.id = 0;
            this.brojDana = 0;
            this.ukupnoMesta = 0;
            this.cena = 0;
            this.popust = 0;
            this.datum = DateTime.MinValue; //podrazumevana vrednost datuma
            this.mesto = "NEDEFINISANO";
            this.drzava = "NEDEFINISANO";
        }

        public Izlet(int id, int brojDana, int ukupnoMesta, double cena, double popust, DateTime datum, string mesto, string drzava)
        {
            this.id = id;
            this.brojDana = brojDana;
            this.ukupnoMesta= ukupnoMesta;
            this.cena = cena;
            this.popust = popust;
            this.datum = datum;
            this.mesto = mesto;
            this.drzava = drzava;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int BrojDana
        {
            get { return brojDana; }
            set { brojDana = value; }
        }

        public int UkupnoMesta { 
            get { return ukupnoMesta; }
            set { ukupnoMesta = value; }
        }

        public double Cena { 
            get { return cena; }
            set { cena = value; }
        }
        public double Popust { 
            get { return popust; }
            set { popust = value; }
        }

        public DateTime Datum {
            get { return datum; }
            set { datum = value; }
        }
        public string Mesto
        {
            get { return mesto; }
            set { mesto = value; }
        }

        public string Drzava 
        { 
            get { return drzava; }
            set { drzava = value; }
        }

       
    }
}
