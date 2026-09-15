using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace I_projekat_nrt_117_23
{
    public partial class FormaAdmin : Form
    {
        public FormaAdmin(int idKorisnika)
        {
            InitializeComponent();
            ispis();
        }

        private void ispis()
        {
            txtIzleti.Clear();
            txtKorisnici.Clear();
            txtRezervacije.Clear();
            foreach (Korisnik k in PodaciXml.listaKorisnika)
                txtKorisnici.AppendText(k.Ime + " " + k.Prezime + " " + k.VrstaKorisnika + "\r\n");

            foreach (Izlet i in PodaciXml.listaIzleta)
                txtIzleti.AppendText(i.Drzava + " - " + i.Mesto + "\r\n");

            foreach (Rezervacija r in PodaciXml.listaRezervacija)
                txtRezervacije.AppendText("K: #" + r.IdKorisnika + " -I: #" + r.IdIzleta + "\r\n");
        }

        private void ispisKorisnici()
        {
            txtKorisnik.Clear();
            foreach (Korisnik k in PodaciXml.listaKorisnika)
            {
                txtKorisnik.AppendText(
                   "#" + k.Id + ", Ime: " + k.Ime + ", Prezime: " + k.Prezime +
                    ", Korisnicko ime: " + k.KorisnickoIme + ", " + k.VrstaKorisnika + "\r\n\n"
                );
            }
        }

        private void ispisIzleti()
        {
            txtIzlet.Clear();
            foreach (Izlet i in PodaciXml.listaIzleta)
            {
                txtIzlet.AppendText(
                   "#" + i.Id + " " + i.Drzava + ", " + i.Mesto + "\n " +
                    "Cena: " + i.Cena + " RSD, " +
                    "Popust: " + i.Popust + "%, " +
                    "Broj dana: " + i.BrojDana + ", " +
                    "Slobodna mesta: " + i.UkupnoMesta + ", " +
                    "Datum: " + i.Datum + "\r\n\n"
                );
            }

        }

        private void ispisRezervacije() {
            txtRezervacija.Clear();
            foreach (Rezervacija r in PodaciXml.listaRezervacija)
            {
                txtRezervacija.AppendText(
                    "Korisnik #" + r.IdKorisnika + ":\n Izlet: " + r.IdIzleta +
                    ", Cena: " + r.UkupnaCena +
                    ", Datum: " + r.DatumRezervacije + "\r\n\n"
                );
            }

        }

        private void btnPovratak_Click(object sender, EventArgs e)
        {
            FormaLogovanje formaLogovanje = new FormaLogovanje();
            formaLogovanje.Show();
            Close();
        }

        private void obrisiPoljaRezervacija() {
            txtIdKorisnikaRez.Clear();
            txtIdIzletaRez.Clear();
            txtBrMestaRez.Clear();
            txtRezervacija.Clear();
        }

        private void obrisiPoljaKorisnik() {
            txtIdKorisnik.Clear();
            txtImeKorisnik.Clear();
            txtPrezimeKorisnik.Clear();
            txtKorisnickoKorisnik.Clear();
            txtLozinkaKorisnik.Clear();
            cmbTipKorisnik.Text="";
            txtKorisnik.Clear();
        }

        private void obrisiPoljaIzlet()
        {
            txtIdIzlet.Clear();
            txtDrzavaIzlet.Clear();
            txtMestoIzlet.Clear();
            txtCenaIzlet.Clear();
            txtPopustIzlet.Clear();
            txtBrojDanaIzlet.Clear();
            txtBrMestaIzlet.Clear();
        }
        private void btnDodajKorisnik_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtImeKorisnik.Text.Trim()) ||
              string.IsNullOrWhiteSpace(txtPrezimeKorisnik.Text.Trim()) ||
              string.IsNullOrWhiteSpace(txtKorisnickoKorisnik.Text.Trim()) ||
              string.IsNullOrWhiteSpace(txtLozinkaKorisnik.Text.Trim()) ||
              string.IsNullOrWhiteSpace(cmbTipKorisnik.Text.Trim()))
            {
                MessageBox.Show("Morate popuniti sva polja osim ID pre dodavanja korisnika!", "GREŠKA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
          
            Korisnik k = new Korisnik(PodaciXml.NoviIdKorisnika(), txtImeKorisnik.Text.Trim(),
                                      txtPrezimeKorisnik.Text.Trim(), txtKorisnickoKorisnik.Text.Trim(),
                                      txtLozinkaKorisnik.Text.Trim(), cmbTipKorisnik.Text.Trim());

            PodaciXml.listaKorisnika.Add(k);
            PodaciXml.SacuvajKorisnike();
            MessageBox.Show("Uspešno ste kreirali korisnika!", "OBAVEŠTENJE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ispis();
            obrisiPoljaKorisnik();
        }
        private void btnIzmeniKorisnik_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdKorisnik.Text.Trim()) ||
                string.IsNullOrWhiteSpace(txtImeKorisnik.Text.Trim()) ||
             string.IsNullOrWhiteSpace(txtPrezimeKorisnik.Text.Trim()) ||
             string.IsNullOrWhiteSpace(txtKorisnickoKorisnik.Text.Trim()) ||
             string.IsNullOrWhiteSpace(txtLozinkaKorisnik.Text.Trim()) ||
             string.IsNullOrWhiteSpace(cmbTipKorisnik.Text.Trim()))
            {
                MessageBox.Show("Morate popuniti sva polja pre izmene korisnika!", "GREŠKA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }
            int idKorisnika = int.Parse(txtIdKorisnik.Text.Trim());
            Korisnik k = null;

            foreach (Korisnik korisnik in PodaciXml.listaKorisnika)
            {
                if (korisnik.Id == idKorisnika)
                {
                    k = korisnik;
                    break;
                }
            }
            if (k != null)
            {
                k.Ime = txtImeKorisnik.Text.Trim();
                k.Prezime = txtPrezimeKorisnik.Text.Trim();
                k.KorisnickoIme = txtKorisnickoKorisnik.Text.Trim();
                k.Lozinka = txtLozinkaKorisnik.Text.Trim();
                k.VrstaKorisnika = cmbTipKorisnik.Text.Trim();
                PodaciXml.SacuvajKorisnike();
                MessageBox.Show("Uspesno ste izmenili korisnika!", "OBAVESTENJE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                obrisiPoljaKorisnik();
                ispis(); 
            }
        }

        private void btnObrisiKorisnik_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdKorisnik.Text.Trim()))
            {
                MessageBox.Show("Morate popuniti samo ID polje pre brisanja korisnika!", "GREŠKA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }
            int idKorisnika = int.Parse(txtIdKorisnik.Text.Trim());
            Korisnik k = null;
            foreach (Korisnik kor in PodaciXml.listaKorisnika)
            {
                if (kor.Id == idKorisnika)
                {
                    k = kor;
                    break;
                }
            }

            if (k != null)
            {
                bool rezervacijaPostoji = false;
                foreach (Rezervacija r in PodaciXml.listaRezervacija)
                {
                    if (r.IdKorisnika == idKorisnika)
                    {
                        rezervacijaPostoji = true;
                        break;
                    }
                }
                if (rezervacijaPostoji)
                {
                    MessageBox.Show("Ne možete obrisati korisnika koji ima rezervaciju!", "GREŠKA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                PodaciXml.listaKorisnika.Remove(k);
                PodaciXml.SacuvajKorisnike();
                MessageBox.Show("Uspešno ste obrisali korisnika!", "OBAVEŠTENJE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ispis();
                obrisiPoljaKorisnik();
            }
        }

        private void btnPrikaziKorisnik_Click(object sender, EventArgs e)
        {
            ispisKorisnici();
        }

        private void btnDodajIzlet_Click(object sender, EventArgs e)
        {
            double cena, popust;
            int brojDana, brojMesta;

            if (string.IsNullOrWhiteSpace(txtDrzavaIzlet.Text.Trim()) ||
               string.IsNullOrWhiteSpace(txtMestoIzlet.Text.Trim()) ||
               !double.TryParse(txtCenaIzlet.Text.Trim(), out cena) ||
               !double.TryParse(txtPopustIzlet.Text.Trim(), out popust) ||
               !int.TryParse(txtBrojDanaIzlet.Text.Trim(), out brojDana) ||
               !int.TryParse(txtBrMestaIzlet.Text.Trim(), out brojMesta))
            {
                MessageBox.Show("Morate popuniti sva polja, osim ID, pre dodavanja izleta!", "GREŠKA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            else if ((double.Parse(txtPopustIzlet.Text) < 0) || (int.Parse(txtBrMestaIzlet.Text)) < 0
                    || (double.Parse(txtCenaIzlet.Text)) < 0)
            {
                MessageBox.Show("Polje ne može sadržati negativni broj, pre dodavanja izleta!", "GREŠKA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
                Izlet i = new Izlet(PodaciXml.NoviIdIzleta(), int.Parse(txtBrojDanaIzlet.Text),
                    int.Parse(txtBrMestaIzlet.Text), double.Parse(txtCenaIzlet.Text)
                    , double.Parse(txtPopustIzlet.Text), dtpIzlet.Value, txtMestoIzlet.Text
                    , txtDrzavaIzlet.Text);
            PodaciXml.listaIzleta.Add(i);
            PodaciXml.SacuvajIzlete();
            MessageBox.Show("Uspešno ste dodali izlet!", "OBAVEŠTENJE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            obrisiPoljaIzlet();
            ispis();
        }

        private void btnIzmeniIzlet_Click(object sender, EventArgs e)
        {
            double cena, popust;
            int brojDana, brojMesta;
            if (string.IsNullOrWhiteSpace(txtIdIzlet.Text.Trim()) ||
                string.IsNullOrWhiteSpace(txtDrzavaIzlet.Text.Trim()) ||
            string.IsNullOrWhiteSpace(txtMestoIzlet.Text.Trim()) ||
            !double.TryParse(txtCenaIzlet.Text.Trim(), out cena) ||
            !double.TryParse(txtPopustIzlet.Text.Trim(), out popust) ||
            !int.TryParse(txtBrojDanaIzlet.Text.Trim(), out brojDana) ||
            !int.TryParse(txtBrMestaIzlet.Text.Trim(), out brojMesta))
            {
                MessageBox.Show("Morate popuniti sva polja pre izmene izleta!", "GREŠKA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }

            int idIzleta = int.Parse(txtIdIzlet.Text.Trim());
            Izlet i = null;
            foreach (Izlet iz in PodaciXml.listaIzleta) {
                if (iz.Id == idIzleta) {
                    i = iz;
                    break;
                }
            }
            if (i == null)
            {
                MessageBox.Show("Uneli ste pogrešan ID izleta, morate pokušati ponovo!", "GREŠKA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            i.Drzava = txtDrzavaIzlet.Text.Trim();
            i.Mesto = txtMestoIzlet.Text.Trim();
            i.Cena = double.Parse(txtCenaIzlet.Text.Trim());
            i.Popust = double.Parse(txtPopustIzlet.Text.Trim());
            i.BrojDana = int.Parse(txtBrojDanaIzlet.Text.Trim());
            i.UkupnoMesta = int.Parse(txtBrMestaIzlet.Text.Trim());
            i.Datum = dtpIzlet.Value;
            ispis();
            PodaciXml.SacuvajIzlete();
            MessageBox.Show("Uspešno ste izmenili izlet!", "OBAVEŠTENJE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            obrisiPoljaIzlet();
        }
        private void btnObrisiIzlet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdIzlet.Text.Trim())) {
                MessageBox.Show("Morate uneti samo ispravan ID izleta za brisanje!", "GREŠKA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idIzleta = int.Parse(txtIdIzlet.Text.Trim());
            Izlet izlet = null;
            foreach (Izlet i in PodaciXml.listaIzleta)
            {
                if (i.Id == idIzleta)
                {
                    izlet = i;
                    break;
                }
            }
            if (izlet == null)
            {
                MessageBox.Show("Nepostojeći ID!", "GREŠKA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            bool postojiRezervacija = false;
            foreach (Rezervacija r in PodaciXml.listaRezervacija)
            {
                if (r.IdIzleta == idIzleta)
                {
                    postojiRezervacija = true;
                    break;
                }
            }

            if (postojiRezervacija)
            {
                MessageBox.Show("Ne možete obrisati izlet koji ima rezervacije!", "GREŠKA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            PodaciXml.listaIzleta.Remove(izlet);
            PodaciXml.SacuvajIzlete();
            obrisiPoljaIzlet();
            MessageBox.Show("Uspešno ste obrisali izlet!", "OBAVEŠTENJE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ispis();
        }
        private void btnPrikazIzlet_Click(object sender, EventArgs e)
        {
            ispisIzleti();
        }

        private void btnDodajRez_Click(object sender, EventArgs e)
        {

            int idKorisinka, brojMesta, idIzleta;
            if (!int.TryParse(txtIdKorisnikaRez.Text.Trim(), out idKorisinka) ||
                !int.TryParse(txtIdIzletaRez.Text.Trim(), out idIzleta) ||
                !int.TryParse(txtBrMestaRez.Text.Trim(), out brojMesta)
                || (int.Parse(txtBrMestaRez.Text.Trim())) < 0)
                 
            {
                MessageBox.Show("Morate ispravno popuniti sva polja!", "GREŠKA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Izlet izlet = null;

            Korisnik k = null;

            foreach (Korisnik kor in PodaciXml.listaKorisnika) {
                if (kor.Id == idKorisinka) {
                    k = kor;
                    break;
                }
            }

            if (k == null) {
                MessageBox.Show("Nepostojeći korisnik!", "GREŠKA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (Izlet i in PodaciXml.listaIzleta)
            {
                if (i.Id == idIzleta)
                {
                    izlet = i;
                    break; 
                }
            }
            if (izlet == null) {
                MessageBox.Show("Nepostojeći izlet!", "GREŠKA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (brojMesta > izlet.UkupnoMesta) {
                MessageBox.Show("Nemamo dovoljno slobodnih mesta!", "GREŠKA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double cenaSaPopust = izlet.Cena * (1 - izlet.Popust / 100.0);
            double ukupnaCena = cenaSaPopust * brojMesta;
            Rezervacija r = new Rezervacija(idKorisinka, idIzleta, brojMesta, ukupnaCena, DateTime.Now);
            PodaciXml.listaRezervacija.Add(r);
            PodaciXml.SacuvajRezervacije();
            izlet.UkupnoMesta -= brojMesta;
            PodaciXml.SacuvajIzlete();
            obrisiPoljaRezervacija();
            MessageBox.Show("Uspešno ste dodali rezervaciju!", "OBAVEŠTENJE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ispis();
        }

        private void btnPrikaziRez_Click(object sender, EventArgs e)
        {
            ispisRezervacije();
        } 

        private void btnIzmeniRez_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIdKorisnikaRez.Text.Trim()) ||
                string.IsNullOrEmpty(txtIdIzletaRez.Text.Trim()) ||
                string.IsNullOrEmpty(txtBrMestaRez.Text.Trim()) ||
                (int.Parse(txtBrMestaRez.Text.Trim()) <= 0))
            {
                MessageBox.Show("Potrebno je da popunite ispravno sva polja za izmenu rezervacije!", "GREŠKA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idKorisnika = int.Parse(txtIdKorisnikaRez.Text.Trim());
            int idIzleta = int.Parse(txtIdIzletaRez.Text.Trim());
            int noviBrojMesta = int.Parse(txtBrMestaRez.Text.Trim());

            Korisnik k = null;
            foreach (Korisnik kor in PodaciXml.listaKorisnika) {
                if (kor.Id == idKorisnika) {
                    k = kor;
                    break;
                }
            }

            if (k == null) {
                MessageBox.Show("Nepostojeći korisnik!", "GREŠKA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Rezervacija r = null;
            foreach (Rezervacija rez in PodaciXml.listaRezervacija)
            {
                if (rez.IdKorisnika == idKorisnika && rez.IdIzleta == idIzleta)
                {
                    r = rez;
                    break; 
                }
            }

            Izlet izlet = null;
            foreach (Izlet i in PodaciXml.listaIzleta)
            {
                if (i.Id == idIzleta)
                {
                    izlet = i;
                    break;
                }
            }

            if (izlet == null) {
                MessageBox.Show("Nepostojeći ID izleta!", "GREŠKA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            else if (r != null && izlet != null)
            {
                izlet.UkupnoMesta += r.BrojRezMesta;

                if (noviBrojMesta > izlet.UkupnoMesta)
                {
                    MessageBox.Show("Nemamo dovoljno slobodnih mesta!", "GREŠKA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                r.BrojRezMesta = noviBrojMesta;
                izlet.UkupnoMesta -= noviBrojMesta;
                r.DatumRezervacije = DateTime.Now;
                r.UkupnaCena = izlet.Cena * noviBrojMesta * (1 - izlet.Popust / 100.0);
                
                ispis();
                PodaciXml.SacuvajRezervacije();
                PodaciXml.SacuvajIzlete();
                obrisiPoljaRezervacija();
                MessageBox.Show("Uspešno ste izmenili rezervaciju!", "OBAVEŠTENJE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnObrisiRez_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIdKorisnikaRez.Text.Trim()) ||
                string.IsNullOrEmpty(txtIdIzletaRez.Text.Trim()))
            {
                MessageBox.Show("Morate korektno popuniti ID izleta i korisnika za brisanje rezervacije!", "GREŠKA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idKorisnika = int.Parse(txtIdKorisnikaRez.Text.Trim());
            int idIzleta = int.Parse(txtIdIzletaRez.Text.Trim());

            Korisnik k = null;
            foreach (Korisnik kor in PodaciXml.listaKorisnika)
            {
                if (kor.Id == idKorisnika)
                {
                    k = kor;
                    break;
                }
            }
            if (k == null)
            {
                MessageBox.Show("Nepostojeći korisnik!", "GREŠKA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Izlet iz = null;
            foreach (Izlet i in PodaciXml.listaIzleta)
            {
                if (i.Id == idIzleta)
                {
                    iz = i;
                    break;
                }
            }
            if (iz == null)
            {
                MessageBox.Show("Nepostojeći izlet!", "GREŠKA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Rezervacija r = null;
            foreach (Rezervacija rez in PodaciXml.listaRezervacija)
            {
                if (rez.IdKorisnika == idKorisnika && rez.IdIzleta == idIzleta)
                {
                    r = rez;
                    break;
                }
            }

            if (r == null)
            {
                MessageBox.Show("Rezervacija za datog korisnika i izlet ne postoji!", "GREŠKA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            iz.UkupnoMesta += r.BrojRezMesta;
            PodaciXml.listaRezervacija.Remove(r);
            PodaciXml.SacuvajRezervacije();
            PodaciXml.SacuvajIzlete();
            ispisRezervacije();
            ispis();
            MessageBox.Show("Uspešno obrisana rezervacija!", "OBAVEŠTENJE", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
        
 
