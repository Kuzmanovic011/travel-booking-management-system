namespace I_projekat_nrt_117_23
{
    partial class FormaDodavanje
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
            this.txtBrOsoba = new System.Windows.Forms.TextBox();
            this.dateDatumPolaska = new System.Windows.Forms.DateTimePicker();
            this.cmbMesto = new System.Windows.Forms.ComboBox();
            this.btnRezervacija = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrikaz = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBrOsoba
            // 
            this.txtBrOsoba.Location = new System.Drawing.Point(239, 204);
            this.txtBrOsoba.Name = "txtBrOsoba";
            this.txtBrOsoba.Size = new System.Drawing.Size(200, 20);
            this.txtBrOsoba.TabIndex = 1;
            // 
            // dateDatumPolaska
            // 
            this.dateDatumPolaska.Location = new System.Drawing.Point(239, 172);
            this.dateDatumPolaska.Name = "dateDatumPolaska";
            this.dateDatumPolaska.Size = new System.Drawing.Size(200, 20);
            this.dateDatumPolaska.TabIndex = 3;
            // 
            // cmbMesto
            // 
            this.cmbMesto.FormattingEnabled = true;
            this.cmbMesto.Location = new System.Drawing.Point(239, 138);
            this.cmbMesto.Name = "cmbMesto";
            this.cmbMesto.Size = new System.Drawing.Size(200, 21);
            this.cmbMesto.TabIndex = 5;
            this.cmbMesto.SelectedIndexChanged += new System.EventHandler(this.cmbMesto_SelectedIndexChanged);
            // 
            // btnRezervacija
            // 
            this.btnRezervacija.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnRezervacija.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRezervacija.Location = new System.Drawing.Point(650, 390);
            this.btnRezervacija.Name = "btnRezervacija";
            this.btnRezervacija.Size = new System.Drawing.Size(138, 48);
            this.btnRezervacija.TabIndex = 6;
            this.btnRezervacija.Text = "Potvrda";
            this.btnRezervacija.UseVisualStyleBackColor = false;
            this.btnRezervacija.Click += new System.EventHandler(this.btnRezervacija_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Izaberite datum polaska:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Odaberite mesto:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Unesite broj osoba:";
            // 
            // txtPrikaz
            // 
            this.txtPrikaz.Location = new System.Drawing.Point(529, 138);
            this.txtPrikaz.Multiline = true;
            this.txtPrikaz.Name = "txtPrikaz";
            this.txtPrikaz.Size = new System.Drawing.Size(242, 229);
            this.txtPrikaz.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bookman Old Style", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(220, 9);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(404, 34);
            this.label6.TabIndex = 13;
            this.label6.Text = "Dodajte novu rezervaciju!";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bookman Old Style", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(476, 19);
            this.label5.TabIndex = 14;
            this.label5.Text = "*Odaberite mesto , datum i broj mesta Vaše rezervacije!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(568, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 19);
            this.label1.TabIndex = 15;
            this.label1.Text = "Ponuda ? / izbaciti";
            // 
            // FormaDodavanje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPrikaz);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRezervacija);
            this.Controls.Add(this.cmbMesto);
            this.Controls.Add(this.dateDatumPolaska);
            this.Controls.Add(this.txtBrOsoba);
            this.Name = "FormaDodavanje";
            this.Text = "FormaDodavanje";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBrOsoba;
        private System.Windows.Forms.DateTimePicker dateDatumPolaska;
        private System.Windows.Forms.ComboBox cmbMesto;
        private System.Windows.Forms.Button btnRezervacija;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrikaz;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
    }
}