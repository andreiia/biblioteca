using System;

namespace proiectForm2
{
    partial class Form1
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
            this.lblNume = new System.Windows.Forms.Label();
            this.lblAutor = new System.Windows.Forms.Label();
            this.lblEditura = new System.Windows.Forms.Label();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.txtEditura = new System.Windows.Forms.TextBox();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.btnAdauga = new System.Windows.Forms.Button();
            this.btnCauta = new System.Windows.Forms.Button();
            this.btnModifica = new System.Windows.Forms.Button();
            this.rtbAfisare = new System.Windows.Forms.RichTextBox();
            this.btnAfisare = new System.Windows.Forms.Button();
            this.txtNrExemplare = new System.Windows.Forms.TextBox();
            this.lblAnAparitie = new System.Windows.Forms.Label();
            this.lblNrExemplare = new System.Windows.Forms.Label();
            this.btnNrTotal = new System.Windows.Forms.Button();
            this.lblCauta = new System.Windows.Forms.Label();
            this.lblGenCarte = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gpbSpecificatii = new System.Windows.Forms.Panel();
            this.ckbCopertiNormale = new System.Windows.Forms.CheckBox();
            this.ckbCopertiCartonate = new System.Windows.Forms.CheckBox();
            this.ckbColorat = new System.Windows.Forms.CheckBox();
            this.lblSpecialitate = new System.Windows.Forms.Label();
            this.gpbGenCarte = new System.Windows.Forms.Panel();
            this.rdbFictiune = new System.Windows.Forms.RadioButton();
            this.rdbBiografii = new System.Windows.Forms.RadioButton();
            this.rdbCopii = new System.Windows.Forms.RadioButton();
            this.rdbSpecialitate = new System.Windows.Forms.RadioButton();
            this.nupdAnAparitie = new System.Windows.Forms.NumericUpDown();
            this.lstAfisare = new System.Windows.Forms.ListBox();
            this.btnDisponibil = new System.Windows.Forms.Button();
            this.lblDisponibil = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.gpbSpecificatii.SuspendLayout();
            this.gpbGenCarte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupdAnAparitie)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNume
            // 
            this.lblNume.AutoSize = true;
            this.lblNume.Location = new System.Drawing.Point(12, 19);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(45, 17);
            this.lblNume.TabIndex = 0;
            this.lblNume.Text = "Nume";
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Location = new System.Drawing.Point(11, 50);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(42, 17);
            this.lblAutor.TabIndex = 1;
            this.lblAutor.Text = "Autor";
            // 
            // lblEditura
            // 
            this.lblEditura.AutoSize = true;
            this.lblEditura.Location = new System.Drawing.Point(11, 79);
            this.lblEditura.Name = "lblEditura";
            this.lblEditura.Size = new System.Drawing.Size(53, 17);
            this.lblEditura.TabIndex = 2;
            this.lblEditura.Text = "Editura";
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(139, 41);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(100, 22);
            this.txtAutor.TabIndex = 2;
            // 
            // txtEditura
            // 
            this.txtEditura.Location = new System.Drawing.Point(139, 79);
            this.txtEditura.Name = "txtEditura";
            this.txtEditura.Size = new System.Drawing.Size(100, 22);
            this.txtEditura.TabIndex = 3;
            // 
            // txtNume
            // 
            this.txtNume.Location = new System.Drawing.Point(139, 13);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(100, 22);
            this.txtNume.TabIndex = 1;
            // 
            // btnAdauga
            // 
            this.btnAdauga.Location = new System.Drawing.Point(151, 402);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(75, 23);
            this.btnAdauga.TabIndex = 6;
            this.btnAdauga.Text = "Adauga";
            this.btnAdauga.UseVisualStyleBackColor = true;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // btnCauta
            // 
            this.btnCauta.Location = new System.Drawing.Point(55, 402);
            this.btnCauta.Name = "btnCauta";
            this.btnCauta.Size = new System.Drawing.Size(75, 23);
            this.btnCauta.TabIndex = 7;
            this.btnCauta.Text = "Cauta";
            this.btnCauta.UseVisualStyleBackColor = true;
            this.btnCauta.Click += new System.EventHandler(this.btnCauta_Click);
            // 
            // btnModifica
            // 
            this.btnModifica.Location = new System.Drawing.Point(151, 431);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(75, 23);
            this.btnModifica.TabIndex = 8;
            this.btnModifica.Text = "Modifica";
            this.btnModifica.UseVisualStyleBackColor = true;
            this.btnModifica.Click += new System.EventHandler(this.btnModifica_Click);
            // 
            // rtbAfisare
            // 
            this.rtbAfisare.Location = new System.Drawing.Point(358, 8);
            this.rtbAfisare.Name = "rtbAfisare";
            this.rtbAfisare.Size = new System.Drawing.Size(694, 208);
            this.rtbAfisare.TabIndex = 9;
            this.rtbAfisare.Text = "";
            // 
            // btnAfisare
            // 
            this.btnAfisare.Location = new System.Drawing.Point(55, 431);
            this.btnAfisare.Name = "btnAfisare";
            this.btnAfisare.Size = new System.Drawing.Size(75, 23);
            this.btnAfisare.TabIndex = 10;
            this.btnAfisare.Text = "Afisare";
            this.btnAfisare.UseVisualStyleBackColor = true;
            this.btnAfisare.Click += new System.EventHandler(this.btnAfisare_Click);
            // 
            // txtNrExemplare
            // 
            this.txtNrExemplare.Location = new System.Drawing.Point(141, 320);
            this.txtNrExemplare.Name = "txtNrExemplare";
            this.txtNrExemplare.Size = new System.Drawing.Size(100, 22);
            this.txtNrExemplare.TabIndex = 5;
            // 
            // lblAnAparitie
            // 
            this.lblAnAparitie.AutoSize = true;
            this.lblAnAparitie.Location = new System.Drawing.Point(1, 297);
            this.lblAnAparitie.Name = "lblAnAparitie";
            this.lblAnAparitie.Size = new System.Drawing.Size(76, 17);
            this.lblAnAparitie.TabIndex = 13;
            this.lblAnAparitie.Text = "An aparitie";
            // 
            // lblNrExemplare
            // 
            this.lblNrExemplare.AutoSize = true;
            this.lblNrExemplare.Location = new System.Drawing.Point(1, 325);
            this.lblNrExemplare.Name = "lblNrExemplare";
            this.lblNrExemplare.Size = new System.Drawing.Size(119, 17);
            this.lblNrExemplare.TabIndex = 14;
            this.lblNrExemplare.Text = "Numar exemplare";
            // 
            // btnNrTotal
            // 
            this.btnNrTotal.Location = new System.Drawing.Point(245, 460);
            this.btnNrTotal.Name = "btnNrTotal";
            this.btnNrTotal.Size = new System.Drawing.Size(162, 23);
            this.btnNrTotal.TabIndex = 16;
            this.btnNrTotal.Text = "Numar total";
            this.btnNrTotal.UseVisualStyleBackColor = true;
            this.btnNrTotal.Click += new System.EventHandler(this.btnNrTotal_Click);
            // 
            // lblCauta
            // 
            this.lblCauta.AutoSize = true;
            this.lblCauta.Location = new System.Drawing.Point(5, 365);
            this.lblCauta.Name = "lblCauta";
            this.lblCauta.Size = new System.Drawing.Size(59, 17);
            this.lblCauta.TabIndex = 17;
            this.lblCauta.Text = "lblCauta";
            // 
            // lblGenCarte
            // 
            this.lblGenCarte.AutoSize = true;
            this.lblGenCarte.Location = new System.Drawing.Point(5, 112);
            this.lblGenCarte.Name = "lblGenCarte";
            this.lblGenCarte.Size = new System.Drawing.Size(73, 17);
            this.lblGenCarte.TabIndex = 21;
            this.lblGenCarte.Text = "Gen Carte";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gpbSpecificatii);
            this.panel1.Controls.Add(this.lblSpecialitate);
            this.panel1.Controls.Add(this.gpbGenCarte);
            this.panel1.Controls.Add(this.lblGenCarte);
            this.panel1.Controls.Add(this.nupdAnAparitie);
            this.panel1.Controls.Add(this.lblAnAparitie);
            this.panel1.Controls.Add(this.lblNrExemplare);
            this.panel1.Controls.Add(this.txtNrExemplare);
            this.panel1.Location = new System.Drawing.Point(10, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(319, 354);
            this.panel1.TabIndex = 23;
            // 
            // gpbSpecificatii
            // 
            this.gpbSpecificatii.Controls.Add(this.ckbCopertiNormale);
            this.gpbSpecificatii.Controls.Add(this.ckbCopertiCartonate);
            this.gpbSpecificatii.Controls.Add(this.ckbColorat);
            this.gpbSpecificatii.Location = new System.Drawing.Point(84, 172);
            this.gpbSpecificatii.Name = "gpbSpecificatii";
            this.gpbSpecificatii.Size = new System.Drawing.Size(200, 100);
            this.gpbSpecificatii.TabIndex = 31;
            // 
            // ckbCopertiNormale
            // 
            this.ckbCopertiNormale.AutoSize = true;
            this.ckbCopertiNormale.Location = new System.Drawing.Point(9, 68);
            this.ckbCopertiNormale.Name = "ckbCopertiNormale";
            this.ckbCopertiNormale.Size = new System.Drawing.Size(130, 21);
            this.ckbCopertiNormale.TabIndex = 2;
            this.ckbCopertiNormale.Text = "Coperti normale";
            this.ckbCopertiNormale.UseVisualStyleBackColor = true;
            // 
            // ckbCopertiCartonate
            // 
            this.ckbCopertiCartonate.AutoSize = true;
            this.ckbCopertiCartonate.Location = new System.Drawing.Point(6, 41);
            this.ckbCopertiCartonate.Name = "ckbCopertiCartonate";
            this.ckbCopertiCartonate.Size = new System.Drawing.Size(139, 21);
            this.ckbCopertiCartonate.TabIndex = 1;
            this.ckbCopertiCartonate.Text = "Coperti cartonate";
            this.ckbCopertiCartonate.UseVisualStyleBackColor = true;
            // 
            // ckbColorat
            // 
            this.ckbColorat.AutoSize = true;
            this.ckbColorat.Location = new System.Drawing.Point(6, 15);
            this.ckbColorat.Name = "ckbColorat";
            this.ckbColorat.Size = new System.Drawing.Size(129, 21);
            this.ckbColorat.TabIndex = 0;
            this.ckbColorat.Text = "Imagini colorate";
            this.ckbColorat.UseVisualStyleBackColor = true;
            // 
            // lblSpecialitate
            // 
            this.lblSpecialitate.AutoSize = true;
            this.lblSpecialitate.Location = new System.Drawing.Point(8, 169);
            this.lblSpecialitate.Name = "lblSpecialitate";
            this.lblSpecialitate.Size = new System.Drawing.Size(81, 17);
            this.lblSpecialitate.TabIndex = 30;
            this.lblSpecialitate.Text = "Specialitate";
            // 
            // gpbGenCarte
            // 
            this.gpbGenCarte.Controls.Add(this.rdbFictiune);
            this.gpbGenCarte.Controls.Add(this.rdbBiografii);
            this.gpbGenCarte.Controls.Add(this.rdbCopii);
            this.gpbGenCarte.Controls.Add(this.rdbSpecialitate);
            this.gpbGenCarte.Location = new System.Drawing.Point(84, 112);
            this.gpbGenCarte.Name = "gpbGenCarte";
            this.gpbGenCarte.Size = new System.Drawing.Size(205, 54);
            this.gpbGenCarte.TabIndex = 29;
            // 
            // rdbFictiune
            // 
            this.rdbFictiune.AutoSize = true;
            this.rdbFictiune.Location = new System.Drawing.Point(3, 30);
            this.rdbFictiune.Name = "rdbFictiune";
            this.rdbFictiune.Size = new System.Drawing.Size(78, 21);
            this.rdbFictiune.TabIndex = 25;
            this.rdbFictiune.TabStop = true;
            this.rdbFictiune.Text = "Fictiune";
            this.rdbFictiune.UseVisualStyleBackColor = true;
            // 
            // rdbBiografii
            // 
            this.rdbBiografii.AutoSize = true;
            this.rdbBiografii.Location = new System.Drawing.Point(123, 30);
            this.rdbBiografii.Name = "rdbBiografii";
            this.rdbBiografii.Size = new System.Drawing.Size(80, 21);
            this.rdbBiografii.TabIndex = 28;
            this.rdbBiografii.TabStop = true;
            this.rdbBiografii.Text = "Biografii";
            this.rdbBiografii.UseVisualStyleBackColor = true;
            // 
            // rdbCopii
            // 
            this.rdbCopii.AutoSize = true;
            this.rdbCopii.Location = new System.Drawing.Point(123, 3);
            this.rdbCopii.Name = "rdbCopii";
            this.rdbCopii.Size = new System.Drawing.Size(60, 21);
            this.rdbCopii.TabIndex = 26;
            this.rdbCopii.TabStop = true;
            this.rdbCopii.Text = "Copii";
            this.rdbCopii.UseVisualStyleBackColor = true;
            // 
            // rdbSpecialitate
            // 
            this.rdbSpecialitate.AutoSize = true;
            this.rdbSpecialitate.Location = new System.Drawing.Point(3, 3);
            this.rdbSpecialitate.Name = "rdbSpecialitate";
            this.rdbSpecialitate.Size = new System.Drawing.Size(102, 21);
            this.rdbSpecialitate.TabIndex = 27;
            this.rdbSpecialitate.TabStop = true;
            this.rdbSpecialitate.Text = "Specialitate";
            this.rdbSpecialitate.UseVisualStyleBackColor = true;
            // 
            // nupdAnAparitie
            // 
            this.nupdAnAparitie.Location = new System.Drawing.Point(130, 292);
            this.nupdAnAparitie.Maximum = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            this.nupdAnAparitie.Minimum = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            this.nupdAnAparitie.Name = "nupdAnAparitie";
            this.nupdAnAparitie.Size = new System.Drawing.Size(120, 22);
            this.nupdAnAparitie.TabIndex = 24;
            this.nupdAnAparitie.Value = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            // 
            // lstAfisare
            // 
            this.lstAfisare.FormattingEnabled = true;
            this.lstAfisare.ItemHeight = 16;
            this.lstAfisare.Location = new System.Drawing.Point(494, 248);
            this.lstAfisare.Name = "lstAfisare";
            this.lstAfisare.Size = new System.Drawing.Size(668, 196);
            this.lstAfisare.TabIndex = 24;
            this.lstAfisare.SelectedIndexChanged += new System.EventHandler(this.lstAfisare_SelectedIndexChanged);
            // 
            // btnDisponibil
            // 
            this.btnDisponibil.Location = new System.Drawing.Point(245, 402);
            this.btnDisponibil.Name = "btnDisponibil";
            this.btnDisponibil.Size = new System.Drawing.Size(122, 52);
            this.btnDisponibil.TabIndex = 25;
            this.btnDisponibil.Text = "Verificare\r\ndisponibilitate";
            this.btnDisponibil.UseVisualStyleBackColor = true;
            this.btnDisponibil.Click += new System.EventHandler(this.btnDisponibil_Click);
            // 
            // lblDisponibil
            // 
            this.lblDisponibil.AutoSize = true;
            this.lblDisponibil.Location = new System.Drawing.Point(431, 460);
            this.lblDisponibil.Name = "lblDisponibil";
            this.lblDisponibil.Size = new System.Drawing.Size(85, 17);
            this.lblDisponibil.TabIndex = 26;
            this.lblDisponibil.Text = "Disponibila?";            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 503);
            this.Controls.Add(this.lblDisponibil);
            this.Controls.Add(this.btnDisponibil);
            this.Controls.Add(this.lstAfisare);
            this.Controls.Add(this.lblCauta);
            this.Controls.Add(this.btnNrTotal);
            this.Controls.Add(this.btnAfisare);
            this.Controls.Add(this.rtbAfisare);
            this.Controls.Add(this.btnModifica);
            this.Controls.Add(this.btnCauta);
            this.Controls.Add(this.btnAdauga);
            this.Controls.Add(this.txtNume);
            this.Controls.Add(this.txtEditura);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.lblEditura);
            this.Controls.Add(this.lblAutor);
            this.Controls.Add(this.lblNume);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Biblioteca";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gpbSpecificatii.ResumeLayout(false);
            this.gpbSpecificatii.PerformLayout();
            this.gpbGenCarte.ResumeLayout(false);
            this.gpbGenCarte.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupdAnAparitie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Label lblNume;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.Label lblEditura;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.TextBox txtEditura;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.Button btnCauta;
        private System.Windows.Forms.Button btnModifica;
        private System.Windows.Forms.RichTextBox rtbAfisare;
        private System.Windows.Forms.Button btnAfisare;
        private System.Windows.Forms.TextBox txtNrExemplare;
        private System.Windows.Forms.Label lblAnAparitie;
        private System.Windows.Forms.Label lblNrExemplare;
        private System.Windows.Forms.Button btnNrTotal;
        private System.Windows.Forms.Label lblCauta;
        private System.Windows.Forms.Label lblGenCarte;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown nupdAnAparitie;
        private System.Windows.Forms.ListBox lstAfisare;
        private System.Windows.Forms.Label lblSpecialitate;
        private System.Windows.Forms.Panel gpbGenCarte;
        private System.Windows.Forms.RadioButton rdbFictiune;
        private System.Windows.Forms.RadioButton rdbBiografii;
        private System.Windows.Forms.RadioButton rdbCopii;
        private System.Windows.Forms.RadioButton rdbSpecialitate;
        private System.Windows.Forms.Panel gpbSpecificatii;
        private System.Windows.Forms.CheckBox ckbCopertiNormale;
        private System.Windows.Forms.CheckBox ckbCopertiCartonate;
        private System.Windows.Forms.CheckBox ckbColorat;
        private System.Windows.Forms.Button btnDisponibil;
        private System.Windows.Forms.Label lblDisponibil;
    }
}

