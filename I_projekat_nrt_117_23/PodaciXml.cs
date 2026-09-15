using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace I_projekat_nrt_117_23
{
    public class PodaciXml
    {
        static string korisniciXml = "Korisnici.xml";
        static string izletiXml = "Izleti.xml";
        static string rezervacijeXml = "Rezervacije.xml";
        public static List<Korisnik> listaKorisnika = new List<Korisnik>();
        public static List<Izlet> listaIzleta = new List<Izlet>();
        public static List<Rezervacija> listaRezervacija = new List<Rezervacija>();

        public static int NoviIdKorisnika()
        {
            if (listaKorisnika.Count == 0)
                return 1;

            int max = 0;

            foreach (Korisnik k in listaKorisnika)
            {
                if (k.Id > max)
                {
                    max = k.Id;
                }
            }

            return max + 1;
        }
        public static int NoviIdIzleta()
        {
            if (listaIzleta.Count == 0)
                return 1;

            // Prvi element u listi
            int max = listaIzleta[0].Id;

            // Prolazimo kroz celu listu i tražimo maksimalni ID
            foreach (Izlet i in listaIzleta)
            {
                if (i.Id > max)
                    max = i.Id;
            }

            return max + 1;
        }

        public static int NoviIdRezervacije()
        {
            if (listaRezervacija.Count == 0)
                return 1;

            //  promeniti
            int max = 0;
            foreach (Rezervacija r in listaRezervacija) {
                int s = r.IdKorisnika + r.IdKorisnika;
                if (s > max)
                    max = s;
            }
           
            return max + 1;
        }

                        // to je kod tijane sacuvaj
        public static void SacuvajPodatke<T>(List<T> lista, string datoteka)
        {
            try
            {
                using (FileStream fs = new FileStream(datoteka, FileMode.Create))
                {
                    XmlSerializer xml = new XmlSerializer(typeof(List<T>));
                    xml.Serialize(fs, lista);
                }
            }
            catch (Exception ex) {
                MessageBox.Show("GRESKA!!" + ex.Message);
            }
        }

        public static List<T> Ucitaj<T>(string xmlFajl)
        {
            try {
                using (FileStream fs = new FileStream(xmlFajl, FileMode.Open)) {
                    XmlSerializer xml = new XmlSerializer(typeof(List<T>));
                    return (List<T>)xml.Deserialize(fs);
                }
            } catch {
                return new List<T>();
            }
        }


        private static void dodajPodrazumevanogAdmina()
        {
            Korisnik podrazumevaniAdmin = new Korisnik(1, "Pera", "Peric", "admin", "admin", "admin");
            Korisnik podrazumevaniKorisnik = new Korisnik(2, "Milos", "Sekulovic", "milos", "milos", "klijent");
            Korisnik podrazumevaniKorisnik1 = new Korisnik(3, "Anja", "Cvjetinovic", "anja", "anja", "klijent");
            Korisnik podrazumevaniKorisnik2 = new Korisnik(4, "Djordje", "Gobeljic", "djordje", "djordje", "klijent");
            Korisnik podrazumevaniAdmin1 = new Korisnik(5, "Miodrag", "Rakitic", "miko", "miko", "admin");
            listaKorisnika.Add(podrazumevaniAdmin);
            listaKorisnika.Add(podrazumevaniKorisnik);
            listaKorisnika.Add(podrazumevaniKorisnik1);
            listaKorisnika.Add(podrazumevaniKorisnik2);
            listaKorisnika.Add(podrazumevaniAdmin1);
            SacuvajKorisnike();

        }

      
        public static void SacuvajKorisnike() {
            SacuvajPodatke(listaKorisnika, korisniciXml);
        }

        public static void SacuvajIzlete() {
            SacuvajPodatke(listaIzleta, izletiXml);
        }

        public static void SacuvajRezervacije() {
            SacuvajPodatke(listaRezervacija, rezervacijeXml);
        }

        public static void UcitajSve() {
            if (File.Exists(korisniciXml))
                listaKorisnika = Ucitaj<Korisnik>(korisniciXml);
            else
                dodajPodrazumevanogAdmina();
            if (File.Exists(izletiXml))
                listaIzleta = Ucitaj<Izlet>(izletiXml);
            else
                listaIzleta = new List<Izlet>();
            if (File.Exists(rezervacijeXml))
                listaRezervacija = Ucitaj<Rezervacija>(rezervacijeXml);
            else
                listaRezervacija = new List<Rezervacija>();
        
        }
       


        public static void Ucitaj()
        {
            if (File.Exists(korisniciXml))
                listaKorisnika = Ucitaj<Korisnik>(korisniciXml);
            else
                listaKorisnika = new List<Korisnik>();

            // Ako je fajl nepostojeći ili prazan → dodaj admina
            if (listaKorisnika == null || listaKorisnika.Count == 0)
                dodajPodrazumevanogAdmina();

            if (File.Exists(izletiXml))
                listaIzleta = Ucitaj<Izlet>(izletiXml);
            else
            {
                listaIzleta = new List<Izlet>();
                SacuvajIzlete();
            }

            if (File.Exists(rezervacijeXml))
                listaRezervacija = Ucitaj<Rezervacija>(rezervacijeXml);
            else
            {
                listaRezervacija = new List<Rezervacija>();
                SacuvajRezervacije();
            }
        }

        //public static void ResetujKorisnike() //metoda za resetovanje korisnika
        //{
        //    // Očisti listu
        //    listaKorisnika.Clear();

        //    // Opcionalno: izbriši stari fajl ako postoji
        //    if (File.Exists(korisniciXml))
        //        File.Delete(korisniciXml);

        //    // Dodaj default korisnike (admin i test korisnik)
        //    dodajPodrazumevanogAdmina();
        //}





    }
}
