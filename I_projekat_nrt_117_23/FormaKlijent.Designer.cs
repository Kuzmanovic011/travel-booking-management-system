namespace I_projekat_nrt_117_23
{
    partial class FormaKlijent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listRezervacije = new System.Windows.Forms.ListBox();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnPromeni = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnPretraga = new System.Windows.Forms.Button();
            this.pocetniDatum = new System.Windows.Forms.DateTimePicker();
            this.krajnjiDatum = new System.Windows.Forms.DateTimePicker();
            this.btnPovratak = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.gbOpcije = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbOpcije.SuspendLayout();
            this.SuspendLayout();
            // 
            // listRezervacije
            // 
            this.listRezervacije.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.listRezervacije.FormattingEnabled = true;
            this.listRezervacije.ItemHeight = 16;
            this.listRezervacije.Location = new System.Drawing.Point(53, 107);
            this.listRezervacije.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listRezervacije.Name = "listRezervacije";
            this.listRezervacije.Size = new System.Drawing.Size(487, 372);
            this.listRezervacije.TabIndex = 0;
            // 
            // btnObrisi
            // 
            this.btnObrisi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnObrisi.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisi.Location = new System.Drawing.Point(37, 86);
            this.btnObrisi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(152, 55);
            this.btnObrisi.TabIndex = 1;
            this.btnObrisi.Text = "Brisanje";
            this.btnObrisi.UseVisualStyleBackColor = false;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnPromeni
            // 
            this.btnPromeni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnPromeni.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPromeni.Location = new System.Drawing.Point(212, 23);
            this.btnPromeni.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPromeni.Name = "btnPromeni";
            this.btnPromeni.Size = new System.Drawing.Size(152, 55);
            this.btnPromeni.TabIndex = 2;
            this.btnPromeni.Text = "Promena";
            this.btnPromeni.UseVisualStyleBackColor = false;
            this.btnPromeni.Click += new System.EventHandler(this.btnPromeni_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnDodaj.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodaj.Location = new System.Drawing.Point(37, 23);
            this.btnDodaj.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(152, 55);
            this.btnDodaj.TabIndex = 3;
            this.btnDodaj.Text = "Dodavanje";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnPretraga
            // 
            this.btnPretraga.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnPretraga.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPretraga.Location = new System.Drawing.Point(212, 86);
            this.btnPretraga.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPretraga.Name = "btnPretraga";
            this.btnPretraga.Size = new System.Drawing.Size(152, 55);
            this.btnPretraga.TabIndex = 4;
            this.btnPretraga.Text = "Pretraži";
            this.btnPretraga.UseVisualStyleBackColor = false;
            this.btnPretraga.Click += new System.EventHandler(this.btnPretraga_Click);
            // 
            // pocetniDatum
            // 
            this.pocetniDatum.Location = new System.Drawing.Point(37, 194);
            this.pocetniDatum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pocetniDatum.Name = "pocetniDatum";
            this.pocetniDatum.Size = new System.Drawing.Size(325, 22);
            this.pocetniDatum.TabIndex = 5;
            // 
            // krajnjiDatum
            // 
            this.krajnjiDatum.Location = new System.Drawing.Point(37, 226);
            this.krajnjiDatum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.krajnjiDatum.Name = "krajnjiDatum";
            this.krajnjiDatum.Size = new System.Drawing.Size(325, 22);
            this.krajnjiDatum.TabIndex = 6;
            // 
            // btnPovratak
            // 
            this.btnPovratak.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnPovratak.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPovratak.Location = new System.Drawing.Point(775, 500);
            this.btnPovratak.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPovratak.Name = "btnPovratak";
            this.btnPovratak.Size = new System.Drawing.Size(276, 39);
            this.btnPovratak.TabIndex = 7;
            this.btnPovratak.Text = "Povratak na početnu stranicu";
            this.btnPovratak.UseVisualStyleBackColor = false;
            this.btnPovratak.Click += new System.EventHandler(this.btnPovratak_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(460, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 43);
            this.label2.TabIndex = 8;
            this.label2.Text = "Klijent";
            // 
            // gbOpcije
            // 
            this.gbOpcije.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.gbOpcije.Controls.Add(this.label3);
            this.gbOpcije.Controls.Add(this.btnDodaj);
            this.gbOpcije.Controls.Add(this.btnPretraga);
            this.gbOpcije.Controls.Add(this.btnPromeni);
            this.gbOpcije.Controls.Add(this.krajnjiDatum);
            this.gbOpcije.Controls.Add(this.btnObrisi);
            this.gbOpcije.Controls.Add(this.pocetniDatum);
            this.gbOpcije.Location = new System.Drawing.Point(601, 161);
            this.gbOpcije.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbOpcije.Name = "gbOpcije";
            this.gbOpcije.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbOpcije.Size = new System.Drawing.Size(407, 277);
            this.gbOpcije.TabIndex = 9;
            this.gbOpcije.TabStop = false;
            this.gbOpcije.Text = "Mogućnosti";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 156);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(382, 21);
            this.label3.TabIndex = 11;
            this.label3.Text = "*Odaberite početni i krajnji datum za pretragu!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(116, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 31);
            this.label1.TabIndex = 10;
            this.label1.Text = "Odabrane rezervacije:";
            // 
            // FormaKlijent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbOpcije);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPovratak);
            this.Controls.Add(this.listRezervacije);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormaKlijent";
            this.Text = "FormaKlijent";
            this.gbOpcije.ResumeLayout(false);
            this.gbOpcije.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listRezervacije;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnPromeni;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnPretraga;
        private System.Windows.Forms.DateTimePicker pocetniDatum;
        private System.Windows.Forms.DateTimePicker krajnjiDatum;
        private System.Windows.Forms.Button btnPovratak;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbOpcije;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}