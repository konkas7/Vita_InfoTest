﻿using System;
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


        public override string ToString()
        {
            return $"{Nome} {Matricola}";
        }

        public bool Equals(VitaT_Candidato c)
        {
            if (c == null)
                return false;
            if (this == c)
                return true;
            if (this.Matricola == c.Matricola || this.Nome == c.Nome)
                return true;
            else
                return false;
        }

        public int CompareTo(VitaT_Candidato other)
        {
            if (other == null)
                return 1;

            if (this.punteggio() == other.punteggio())
                return 0;
            else if (this.punteggio() < other.punteggio())
                return -1;
            else
                return 1;
        }

        public override int GetHashCode()
        {
            return (Matricola, Nome).GetHashCode();
        }



    }
}
