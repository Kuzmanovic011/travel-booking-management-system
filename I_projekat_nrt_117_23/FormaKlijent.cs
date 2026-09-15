using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace I_projekat_nrt_117_23
{
    public partial class FormaKlijent : Form
    {
        private int id;
        public FormaKlijent(int idKorisnika)
        {
            InitializeComponent();
            id = idKorisnika;
        }
        private void btnPromeni_Click(object sender, EventArgs e)
        {
            FormaIzmena formaIzmena = new FormaIzmena(id);
            formaIzmena.Show();
            Close();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            FormaDodavanje formaDodavanje = new FormaDodavanje(id);
            formaDodavanje.Show();
            Close();
        }

        private void btnPovratak_Click(object sender, EventArgs e)
        {
            FormaLogovanje formaLogovanje = new FormaLogovanje();
            formaLogovanje.Show();
            Close();
           
        }
        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (listRezervacije.SelectedIndex >= 0)
            {
                int indeks = listRezervacije.SelectedIndex;
                List<Rezervacija> rezervacijeKlijenta = new List<Rezervacija>();
                foreach (Rezervacija r in PodaciXml.listaRezervacija)
                {
                    if (r.IdKorisnika == id && r.DatumRezervacije.Date >= DateTime.Today)
                    {
                        rezervacijeKlijenta.Add(r);
                    }
                }
                if (indeks >= rezervacijeKlijenta.Count)
                {
                    MessageBox.Show("Ne možete obrisati prošlu rezervaciju!", "GREŠKA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                Rezervacija rezervacijaZaBrisanje = rezervacijeKlijenta[indeks];
                Izlet izletZaPovratakMesta = null;
                foreach (Izlet i in PodaciXml.listaIzleta)
                {
                    if (i.Id == rezervacijaZaBrisanje.IdIzleta)
                    {
                        izletZaPovratakMesta = i;
                        break;
                    }
                }
                if (izletZaPovratakMesta != null)
                    izletZaPovratakMesta.UkupnoMesta += rezervacijaZaBrisanje.BrojRezMesta;
                PodaciXml.listaRezervacija.Remove(rezervacijaZaBrisanje);
                PodaciXml.SacuvajRezervacije();
                PodaciXml.SacuvajIzlete();
                ispisLst();
                MessageBox.Show("Rezervacija uspešno obrisana!", "OBAVEŠTENJE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                MessageBox.Show("Izaberite rezervaciju za brisanje!", "GREŠKA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnPretraga_Click(object sender, EventArgs e)
        {
            DateTime pocetni = pocetniDatum.Value.Date;
            DateTime krajnji = krajnjiDatum.Value.Date;
            if (pocetni > krajnji)
            {
                MessageBox.Show("Početni datum mora biti pre krajnjeg!", "GREŠ KA!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            listRezervacije.Items.Clear();
            bool imaRezervacija = false;
            foreach (Rezervacija r in PodaciXml.listaRezervacija)
            {
                if (r.IdKorisnika == id) 
                {
                    Izlet izlet = null;
                    foreach (Izlet i in PodaciXml.listaIzleta)
                    {
                        if (i.Id == r.IdIzleta)
                        {
                            izlet = i;
                            break;
                        }
                    }
                    if (izlet != null && izlet.Datum.Date >= pocetni && izlet.Datum.Date <= krajnji)
                    {
                        listRezervacije.Items.Add(
                                izlet.Drzava + "-" + izlet.Mesto +
                                " cena " + izlet.Cena + " ,popust "
                                + izlet.Popust + " %, " + "za " + r.BrojRezMesta +
                                " osobe/a,, " + "dana " + izlet.Datum.ToShortDateString() +
                                " ,za " + izlet.BrojDana + " dana\n"
                        );
                        imaRezervacija = true;
                    }
                }
            }
            if (!imaRezervacija)
                listRezervacije.Items.Add("Nema rezervacija u odabranom periodu!");
        }
        private void ispisLst() {
            listRezervacije.Items.Clear();
            List<Rezervacija> rezervacijeKlijenata = new List<Rezervacija>();
            foreach (Rezervacija r in PodaciXml.listaRezervacija) {
                if (r.IdKorisnika == id && r.DatumRezervacije.Date >= DateTime.Today)
                    rezervacijeKlijenata.Add(r);
            }
            foreach (Rezervacija r in rezervacijeKlijenata) {
                Izlet izlet = null;
                foreach (Izlet i in PodaciXml.listaIzleta) {
                    if (i.Id == r.IdIzleta) {
                        izlet = i;
                        break;
                    }
                }
                if (izlet != null) {
                    listRezervacije.Items.Add(
                        izlet.Drzava + "-" + izlet.Mesto +
                        " cena " + izlet.Cena + " ,popust "
                        + izlet.Popust + " %, " + "za " + r.BrojRezMesta +
                        " osobe/a,, " + "dana " + izlet.Datum.ToShortDateString() +
                        " ,za " + izlet.BrojDana + " dana\n"
                        );
                }
            }
        } 
    }
}
