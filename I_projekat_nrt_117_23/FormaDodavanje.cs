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
    public partial class FormaDodavanje : Form
    {
        int korisnickiId;
        public FormaDodavanje(int Id)
        {
            InitializeComponent();
            korisnickiId = Id;
            List<string> listamesta = new List<string>();
            foreach (Izlet i in PodaciXml.listaIzleta)
                listamesta.Add(i.Mesto);
            cmbMesto.DataSource = listamesta; 
        }

        private void btnRezervacija_Click(object sender, EventArgs e)
        {
            string odabranoMesto = cmbMesto.Text.Trim();
            DateTime odabraniDatum = dateDatumPolaska.Value.Date;
            Izlet odabraniIzlet = null;
            foreach (Izlet i in PodaciXml.listaIzleta)
            {
                if (i.Mesto.Equals(odabranoMesto) && i.Datum.Date == odabraniDatum)
                {
                    odabraniIzlet = i;
                    break; 
                }
            }

            if (odabraniIzlet == null)
            {
                MessageBox.Show("Izlet mora biti rezervisan u naznačenom datumu!", "GREŠKA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(cmbMesto.Text.Trim()) || string.IsNullOrWhiteSpace(txtBrOsoba.Text.Trim())) {
                MessageBox.Show("Morate popuniti sva polja!", "GREŠKA",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtBrOsoba.Text.Trim(), out int brojMesta) || brojMesta <= 0)
            {
                MessageBox.Show("Unesite ispravan broj mesta!", "GREŠKA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (brojMesta > odabraniIzlet.UkupnoMesta) {
                MessageBox.Show("Nema slobodnih mesta za odabrano mesto i izlet!", "GREŠKA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
 

            foreach (Rezervacija r in PodaciXml.listaRezervacija)
            {
                if (r.IdKorisnika == korisnickiId && r.DatumRezervacije.Date == odabraniDatum)
                    break; 
            }

            List<Rezervacija> mojeRezervacije = new List<Rezervacija>();
            foreach (Rezervacija r in PodaciXml.listaRezervacija)
            {
                if (r.IdKorisnika == korisnickiId)
                    mojeRezervacije.Add(r);
            }

            DateTime odlazakNovog = odabraniIzlet.Datum;
            DateTime dolazakNovog = odabraniIzlet.Datum.AddDays(odabraniIzlet.BrojDana);

            foreach (Rezervacija rez in mojeRezervacije) {
                Izlet stariIzlet = null;

                foreach (var i in PodaciXml.listaIzleta)
                {
                    if (i.Id == rez.IdIzleta)
                    {
                        stariIzlet = i;
                        break;
                    }
                }
                if (stariIzlet != null) {
                    DateTime odlazakStarog = stariIzlet.Datum;
                    DateTime dolazakStarog = stariIzlet.Datum.AddDays(stariIzlet.BrojDana);
                    if (odlazakNovog < dolazakStarog && dolazakNovog > odlazakStarog) {
                        MessageBox.Show("Imate već rezervisan izlet!", "GREŠKA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return; 
                    }
                }
            }
            double cenaSaPopustom = odabraniIzlet.Cena - (odabraniIzlet.Cena * odabraniIzlet.Popust / 100.0);
            double ukupnaCena = brojMesta * cenaSaPopustom;
            Rezervacija novaRezervacija = new Rezervacija(korisnickiId, odabraniIzlet.Id, brojMesta, ukupnaCena, DateTime.Now);
            PodaciXml.listaRezervacija.Add(novaRezervacija);
            PodaciXml.SacuvajRezervacije();
            odabraniIzlet.UkupnoMesta -= brojMesta;
            PodaciXml.SacuvajIzlete();
            MessageBox.Show("Uspešno ste napravili rezervaciju!", "OBAVEŠTENJE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
            FormaKlijent k = new FormaKlijent(korisnickiId);
            k.Show();
        }
        private void cmbMesto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMesto.SelectedItem == null)
                return;
            string izabranoMesto = cmbMesto.SelectedItem.ToString();
            List<Izlet> izletiZaMesto = new List<Izlet>();

            foreach (Izlet i in PodaciXml.listaIzleta)
            {
                if (i.Mesto.Equals(izabranoMesto))
                    izletiZaMesto.Add(i);
            }
            txtPrikaz.Clear();
            foreach (Izlet i in izletiZaMesto) {
                txtPrikaz.AppendText(
                     $"Mesto: {i.Mesto}\r\n" +
                    $"Država: {i.Drzava}\r\n" +
                    $"Cena: {i.Cena} RSD\r\n" +
                    $"Popust: {i.Popust}%\r\n" +
                    $"Broj dana: {i.BrojDana}\r\n" +
                    $"Ukupno mesta: {i.UkupnoMesta}\r\n" +
                    $"Datum: {i.Datum:d}\r\n" +
                    "-----------------------------\r\n"
                    );
            }

        }
    }
}

