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
    public partial class FormaLogovanje : Form
    {
        public FormaLogovanje()
        {
            InitializeComponent();
            //btnUputstvo.Visible = false; 
            try
            {
                PodaciXml.Ucitaj();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greska pri učitavanju" + ex.Message);
            }
        }
        private void btnPrijava_Click(object sender, EventArgs e)
        {
            string imePrijava = txtIme.Text.Trim();
            string lozinkaPrijava = txtLozinka.Text.Trim();
            Korisnik korisnik = null;
            foreach (Korisnik k in PodaciXml.listaKorisnika)
            {
                if (k.KorisnickoIme == imePrijava && k.Lozinka == lozinkaPrijava)
                {
                    korisnik = k;
                    break;
                }
            }


            if (string.IsNullOrWhiteSpace(imePrijava) || string.IsNullOrWhiteSpace(lozinkaPrijava))
            {
                MessageBox.Show("Unesite korisničko ime i lozinku!", "GREŠKA!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (korisnik == null)
            {
                MessageBox.Show("Nepostojeći korisnik!", "GREŠKA!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (korisnik.VrstaKorisnika == "admin")
                {
                    FormaAdmin formaAdmin = new FormaAdmin(korisnik.Id);
                    formaAdmin.Show();
                    Hide();
                    MessageBox.Show("Ulogovani ste kao admin!", "OBAVEŠTENJE", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    FormaKlijent formaKlijent = new FormaKlijent(korisnik.Id);
                    formaKlijent.Show();
                    Hide();
                    MessageBox.Show("Ulogovani ste kao klijent!", "OBAVEŠTENJE", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("GREŠKA" + ex.Message);
            }
        }
        private void btnUputstvo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Admin nalog uneti -> k.ime->admin, lozinka->admin\n" +
                "Klijent nalog uneti -> k.ime->milos, lozinka->milos", "OBAVEŠTENJE", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
