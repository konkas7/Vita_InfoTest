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
            Matricola = 0;
            Nome = null;
        }

        public VitaT_Candidato(int x)
        {
            Matricola = x;
            Nome = null;
        }
        public VitaT_Candidato(string s)
        {
            Matricola = 0;
            Nome = s;
        }

        public VitaT_Candidato(int x, string s)
        {
            Matricola = x;
            Nome = s;
        }


        public abstract bool isIdoneo();


        public abstract int punteggio();





    }
}
