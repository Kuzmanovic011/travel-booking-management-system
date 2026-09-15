namespace I_projekat_nrt_117_23
{
    partial class FormaIzmena
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBrojMesta = new System.Windows.Forms.TextBox();
            this.btnPromena = new System.Windows.Forms.Button();
            this.dtpDatumRez = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbListaMesta = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(85, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mesto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(53, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Broj mesta:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(79, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Datum:";
            // 
            // txtBrojMesta
            // 
            this.txtBrojMesta.Location = new System.Drawing.Point(177, 174);
            this.txtBrojMesta.Name = "txtBrojMesta";
            this.txtBrojMesta.Size = new System.Drawing.Size(201, 20);
            this.txtBrojMesta.TabIndex = 5;
            // 
            // btnPromena
            // 
            this.btnPromena.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnPromena.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPromena.Location = new System.Drawing.Point(548, 383);
            this.btnPromena.Name = "btnPromena";
            this.btnPromena.Size = new System.Drawing.Size(240, 55);
            this.btnPromena.TabIndex = 6;
            this.btnPromena.Text = "Promena";
            this.btnPromena.UseVisualStyleBackColor = false;
            this.btnPromena.Click += new System.EventHandler(this.btnPromena_Click);
            // 
            // dtpDatumRez
            // 
            this.dtpDatumRez.Location = new System.Drawing.Point(177, 148);
            this.dtpDatumRez.Name = "dtpDatumRez";
            this.dtpDatumRez.Size = new System.Drawing.Size(201, 20);
            this.dtpDatumRez.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bookman Old Style", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(540, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "*Odaberite mesto i datum Vase rezervacije i broj mesta za istu!";
            // 
            // cmbListaMesta
            // 
            this.cmbListaMesta.FormattingEnabled = true;
            this.cmbListaMesta.Location = new System.Drawing.Point(177, 121);
            this.cmbListaMesta.Name = "cmbListaMesta";
            this.cmbListaMesta.Size = new System.Drawing.Size(201, 21);
            this.cmbListaMesta.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bookman Old Style", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(209, 9);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(335, 34);
            this.label6.TabIndex = 10;
            this.label6.Text = "Izmenite rezervaciju!";
            // 
            // FormaIzmena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbListaMesta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpDatumRez);
            this.Controls.Add(this.btnPromena);
            this.Controls.Add(this.txtBrojMesta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "FormaIzmena";
            this.Text = "FormaIzmena";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBrojMesta;
        private System.Windows.Forms.Button btnPromena;
        private System.Windows.Forms.DateTimePicker dtpDatumRez;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbListaMesta;
        private System.Windows.Forms.Label label6;
    }
}