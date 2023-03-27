using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vita_InfoTest
{
    public abstract class VitaT_Candidato
    {

        private int VitaT_matricola;
        private string VitaT_nome;

        public int Matricola
        {
            get { return VitaT_matricola; }
            set { VitaT_matricola = value; }
        }

        public string Nome
        {
            get { return VitaT_nome; }
            set { VitaT_nome = value; }
        }

        public VitaT_Candidato()
        {
            VitaT_matricola = 0;
            VitaT_nome = null;
        }

        public VitaT_Candidato(int x)
        {
            VitaT_matricola = x;
            VitaT_nome = null;
        }
        public VitaT_Candidato(string s)
        {
            VitaT_matricola = 0;
            VitaT_nome = s;
        }

        public VitaT_Candidato(int x, string s)
        {
            VitaT_matricola = x;
            VitaT_nome = s;
        }


        public abstract bool isIdoneo();


        public abstract int punteggio();





    }
}
