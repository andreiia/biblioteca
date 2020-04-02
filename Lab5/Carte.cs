using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proiect
{
    class Carte
    {
        private
        string nume;
        string autor;
        string editura;
        GENCARTE GenCarte;
        int AnAparitie;
        public int NrExemplare { get; set; }
        int IDcarte;
        static int ID;
        //Constructor fara parametrii
        public Carte()
        {
            nume = string.Empty;
            autor = string.Empty;
            editura= string.Empty;
            GenCarte = GENCARTE.Copii;
            AnAparitie = 0;
            NrExemplare = 0;
            IDcarte = ID;
            ID=ID+1;
        }
        //Constructor cu parametrii
        public Carte(string _nume,string _autor, string _editura, int _AnAparitie, int _NrExemplare,int n)
        {
            nume = _nume;
            autor = _autor;
            editura = _editura;
            AnAparitie = _AnAparitie;
            NrExemplare = _NrExemplare;
            IDcarte = ID;
            ID = ID + 1;
            GenCarte = (GENCARTE)(n);
        }
        //Constructor care primeste un sir
        public Carte(string sirr)
        {
            string[] buff= sirr.Split(',');
            nume = buff[0];
            autor = buff[1];
            editura = buff[2];
            AnAparitie = Convert.ToInt32(buff[3]);
            NrExemplare = Convert.ToInt32(buff[4]);
            IDcarte = ID;
            ID += ID;
            int i = Convert.ToInt16(buff[5]);
            GenCarte = (GENCARTE)(i);
        }

        public string ComparaCarte(Carte c2)
        {
            if (this.NrExemplare > c2.NrExemplare)
                return string.Format("Cartea cu numele {0} si ID-ul {1} este in mai multe exemplare ({2})", this.nume, this.IDcarte, this.NrExemplare);
            else
            {
                if (this.NrExemplare == c2.NrExemplare)
                { return string.Format("Cele 2 carti sunt in acelasi numar de exemplare ({0})", this.NrExemplare); }
                else
                { return string.Format("Cartea cu numele {0} si ID-ul {1} este in mai multe exemplare ({2})", c2.nume, c2.IDcarte, c2.NrExemplare); }
            }
        }

        public bool CautareGenCarte(int opt)
        {
            if (this.GenCarte == (GENCARTE)opt)
            {
                return true;
            }
            else
                return false ;
        }

        public bool CautareNume(string _nume)
        {
            if (this.nume == _nume)
                return true;
            return false;
        }

        public string Info()
        {
            return string.Format("Cartea cu numele {0}, scrisa de {1}, publicata la editura {2}, a aparut in anul {3} si o avem disponibila in {4} exemplare ( are ID-ul : {5}).", nume, autor, editura, AnAparitie, NrExemplare,IDcarte);
        }
    }
}
