using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using NivelAccesDate;
using LibrarieModele;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Formular form1 = new Formular();
            form1.Show();
            Application.Run();
        }
    }

    public class Formular : Form
    {
        IStocareData adminCarti = StocareFactory.GetAdministratorStocare();

        private GENCARTE textFlagsGen = GENCARTE.Copii;

        private Label lblNume;
        private Label lblAutor;
        private Label lblEditura;
        private Label lblAnAparitie;
        private Label lblNrExemplare;
        private Label lblInfo;
        private Label lblGenCarte;

        private TextBox txtNume;
        private TextBox txtAutor;
        private TextBox txtEditura;
        private TextBox txtAnAparitie;
        private TextBox txtNrExemplare;

        private ComboBox cmbGen;

        private Button btnAdaugare;

        private const int LATIME_CONTROL = 150;
        private const int DIMENSIUNE_PAS_Y = 30;
        private const int DIMENSIUNE_PAS_X = 170;
        private const int INALTIME_CONTROL = 30;
        private const int LUNGIME_MAXIMA = 30;

        public Formular()
        {
            this.Size = new System.Drawing.Size(600, 400);
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new System.Drawing.Point(100, 100);
            this.Font = new Font("Arial", 9, FontStyle.Bold);
            this.ForeColor = Color.LimeGreen;
            this.Text = "Librarie";

            lblNume = new Label();
            lblNume.Width = LATIME_CONTROL;
            lblNume.Text = "Nume: ";
            lblNume.BackColor = Color.Aqua;
            this.Controls.Add(lblNume);

            lblAutor = new Label();
            lblAutor.Width = LATIME_CONTROL;
            lblAutor.Top = DIMENSIUNE_PAS_Y;
            lblAutor.Text = "Autor: ";
            lblAutor.BackColor = Color.Aqua;
            this.Controls.Add(lblAutor);

            lblEditura = new Label();
            lblEditura.Width = LATIME_CONTROL;
            lblEditura.Top = DIMENSIUNE_PAS_Y*2;
            lblEditura.Text = "Editura: ";
            lblEditura.BackColor = Color.Aqua;
            this.Controls.Add(lblEditura);

            lblAnAparitie = new Label();
            lblAnAparitie.Width = LATIME_CONTROL;
            lblAnAparitie.Top = DIMENSIUNE_PAS_Y*3;
            lblAnAparitie.Text = "An aparitie: ";
            lblAnAparitie.BackColor = Color.Aqua;
            this.Controls.Add(lblAnAparitie);

            lblNrExemplare = new Label();
            lblNrExemplare.Width = LATIME_CONTROL;
            lblNrExemplare.Top = DIMENSIUNE_PAS_Y * 4;
            lblNrExemplare.Text = "Numar exemplare: ";
            lblNrExemplare.BackColor = Color.Aqua;
            this.Controls.Add(lblNrExemplare);

            lblGenCarte = new Label();
            lblGenCarte.Width = LATIME_CONTROL;
            lblGenCarte.Top = DIMENSIUNE_PAS_Y * 5;
            lblGenCarte.Text = "Gen carte: ";
            lblGenCarte.BackColor = Color.Aqua;
            this.Controls.Add(lblGenCarte);

            lblInfo = new Label();
            lblInfo.Width = LATIME_CONTROL*3;
            lblInfo.Top = DIMENSIUNE_PAS_Y * 8;
            lblInfo.Height =INALTIME_CONTROL;
            lblInfo.Text = String.Empty;
            lblInfo.BackColor = Color.Aqua;
            this.Controls.Add(lblInfo);


            //Adaugare textbox

            txtNume = new TextBox();
            txtNume.Width = LATIME_CONTROL;
            txtNume.Location = new System.Drawing.Point(DIMENSIUNE_PAS_X, 0);
            this.Controls.Add(txtNume);

            txtAutor = new TextBox();
            txtAutor.Width = LATIME_CONTROL;
            txtAutor.Location = new System.Drawing.Point(DIMENSIUNE_PAS_X, DIMENSIUNE_PAS_Y);
            this.Controls.Add(txtAutor);

            txtEditura = new TextBox();
            txtEditura.Width = LATIME_CONTROL;
            txtEditura.Location = new System.Drawing.Point(DIMENSIUNE_PAS_X, DIMENSIUNE_PAS_Y*2);
            this.Controls.Add(txtEditura);

            txtAnAparitie = new TextBox();
            txtAnAparitie.Width = LATIME_CONTROL;
            txtAnAparitie.Location = new System.Drawing.Point(DIMENSIUNE_PAS_X, DIMENSIUNE_PAS_Y*3);
            this.Controls.Add(txtAnAparitie);

            txtNrExemplare = new TextBox();
            txtNrExemplare.Width = LATIME_CONTROL;
            txtNrExemplare.Location = new System.Drawing.Point(DIMENSIUNE_PAS_X, DIMENSIUNE_PAS_Y*4);
            this.Controls.Add(txtNrExemplare);

            //Obiecte de tip ComboBox

            cmbGen = new ComboBox();
            cmbGen.Location = new Point(DIMENSIUNE_PAS_X, DIMENSIUNE_PAS_Y * 5);
            cmbGen.Left = DIMENSIUNE_PAS_X;
            cmbGen.BackColor = Color.DarkGray;
            cmbGen.ForeColor = Color.Black;
            cmbGen.Width = LATIME_CONTROL + 30;
            cmbGen.Font = new Font("Elephant", 14, FontStyle.Regular);
            foreach(string name in Enum.GetNames(typeof(GENCARTE)))
            {
                cmbGen.Items.Add(name);
            }
            cmbGen.SelectedIndex = -1;
            cmbGen.SelectedIndexChanged += new EventHandler(cmbGen_SelectedIndex_Changed_Gen) ;
            this.Controls.Add(cmbGen);


            btnAdaugare = new Button();
            btnAdaugare.Text = "Adauga carte";
            btnAdaugare.Width = LATIME_CONTROL;
            btnAdaugare.Location = new System.Drawing.Point(DIMENSIUNE_PAS_X, DIMENSIUNE_PAS_Y * 6);
            this.Controls.Add(btnAdaugare);

            btnAdaugare.Click += OnButtonAdaugaClick;
            this.Controls.Add(btnAdaugare);

        }

        private void OnButtonAdaugaClick(object sender, EventArgs e)
        {
            if (Validare())
            {
                Carte c = new Carte(txtNume.Text, txtAutor.Text, txtEditura.Text, Convert.ToInt32(txtAnAparitie.Text), Convert.ToInt32(txtNrExemplare.Text), 2);
                lblInfo.Text = c.Info();
                adminCarti.AddCarte(c);
                lblNume.ForeColor = Color.Black;
                lblAutor.ForeColor = Color.Black;
                lblEditura.ForeColor = Color.Black;
                lblAnAparitie.ForeColor = Color.Black;
                lblNrExemplare.ForeColor = Color.Black;
                lblGenCarte.ForeColor = Color.Black;
            }
        }

        private bool Validare()
        {
            if(txtNume.Text==string.Empty|| txtNume.TextLength >LUNGIME_MAXIMA)
            {
                lblNume.ForeColor = Color.Red;
                lblInfo.Text = "Ati tastat un nume de carte neacceptat!";
                return false;
            }
            if (txtAutor.Text == string.Empty || txtAutor.TextLength > LUNGIME_MAXIMA)
            {
                lblAutor.ForeColor = Color.Red;
                lblInfo.Text = "Ati tastat un nume de autor neacceptat!";
                return false;
            }
            if (txtEditura.Text == string.Empty || txtEditura.TextLength > LUNGIME_MAXIMA)
            {
                lblEditura.ForeColor = Color.Red;
                lblInfo.Text = "Ati tastat un nume de editura neacceptat!";
                return false;
            }
            if (txtAnAparitie.Text == string.Empty || (txtAnAparitie.Text.All(char.IsDigit) == false  ))
            {
                lblAnAparitie.ForeColor = Color.Red;
                lblInfo.Text = "Ati tastat un an neacceptat!";
                return false;
            }
            if (txtNrExemplare.Text == string.Empty || txtNume.TextLength > LUNGIME_MAXIMA || (txtNrExemplare.Text.All(char.IsDigit) == false))
            {
                lblNrExemplare.ForeColor = Color.Red;
                lblInfo.Text = "Ati tastat un numar de exemplare neacceptat!";
                return false;
            }
            return true;
  
        }
        void cmbGen_SelectedIndex_Changed_Gen(object sender, EventArgs e)
        {
            this.textFlagsGen = (GENCARTE)Enum.Parse(typeof(GENCARTE), (string)cmbGen.Items[cmbGen.SelectedIndex]);
        }

    }
}
