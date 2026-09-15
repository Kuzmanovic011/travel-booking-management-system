using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace I_projekat_nrt_117_23
{
    public partial class FormaIzmena : Form
    {
        private int idKlijenta;
        public FormaIzmena(int id)
        {
            InitializeComponent();
            List<string> listamesta = new List<string>();
            foreach (Izlet i in PodaciXml.listaIzleta)
                listamesta.Add(i.Mesto);
            cmbListaMesta.DataSource = listamesta;
            idKlijenta = id;
        }

      

        private void btnPromena_Click(object sender, EventArgs e)
        {
            int brojMesta;
            if (!int.TryParse(txtBrojMesta.Text.Trim(), out brojMesta) || brojMesta <= 0) {
                MessageBox.Show("Molimo Vas da unesete validan broj mesta!", "GREŠKA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            
            }
            Izlet izlet = null;

            foreach (Izlet i in PodaciXml.listaIzleta)
            {
                if (i.Mesto == cmbListaMesta.Text.Trim() && i.Datum.Date == dtpDatumRez.Value.Date)
                {
                    izlet = i;
                    break; 
                }
            }

            if (izlet == null)
            {
                MessageBox.Show("Ne možete menjati mesto ili datum izleta!", "GREŠKA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Rezervacija rezervacija = null;

            foreach (Rezervacija r in PodaciXml.listaRezervacija)
            {
                if (r.IdKorisnika == idKlijenta && r.IdIzleta == izlet.Id)
                {
                    rezervacija = r;
                    break; 
                }
            }

            if (rezervacija == null)
            {
                MessageBox.Show("Rezervacija nije pronađena!", "GREŠKA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dtpDatumRez.Value.Date != izlet.Datum.Date)
            {
                MessageBox.Show("Možete izmeniti samo broj rezervisanih mesta!","GREŠKA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            izlet.UkupnoMesta += rezervacija.BrojRezMesta;
            if (brojMesta > izlet.UkupnoMesta) {
                MessageBox.Show("Nema dovoljno mesta!", "GREŠKA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                izlet.UkupnoMesta -= rezervacija.BrojRezMesta;
                return;
            }
            izlet.UkupnoMesta -= brojMesta;
            rezervacija.BrojRezMesta = brojMesta;
            rezervacija.DatumRezervacije = DateTime.Now;
            rezervacija.UkupnaCena = izlet.Cena * brojMesta * (1 - izlet.Popust / 100.0);
            PodaciXml.SacuvajRezervacije();
            PodaciXml.SacuvajIzlete();
            MessageBox.Show("Rezervacija je evidentirana!", "OBAVEŠTENJE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
            FormaKlijent formaKlijent = new FormaKlijent(idKlijenta);
            formaKlijent.Show();

        }

    }
    }

