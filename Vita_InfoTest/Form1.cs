using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vita_InfoTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        List<VitaT_Candidato> l1 = new List<VitaT_Candidato>();

        public void Add(VitaT_Candidato c)
        {
            l1.Add(c);
        }

        public string[] Stampa()
        {
            List<string> lista = new List<string>();
            foreach (VitaT_Candidato c in l1)
            {
                lista.Add(c.ToString());
            }
            return lista.ToArray();
        }

        public void Modifica(string nome, int nmatricola)
        {
            for (int i = 0; i < l1.Count; i++)
            {
                if (l1[i].Matricola == nmatricola)
                {
                    l1[i].Nome = nome;
                }
            }
        }


        public void Elimina(int nmatricola)
        {
            for (int i = 0; i < l1.Count; i++)
            {
                if (l1[i].Matricola == nmatricola)
                {
                    l1[i] = null;
                }
            }
        }


        public string[] VisualizzaIdonei()
        {

            List<string> l2 = new List<string>();

        }

    }
}
