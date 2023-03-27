using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vita_InfoTest
{
    public abstract class VitaT_Lavoratore : VitaT_Candidato
    {
        private int VitaT_esperienze;

        public int Esperienze
        {
            get { return VitaT_esperienze; }
            set
            {
                if (VitaT_esperienze >= 0 && VitaT_esperienze <= 5)
                {
                    VitaT_esperienze = value;
                }
                else
                    throw new Exception("Numero massimo esperienze superate");
            }
        }

        public VitaT_Lavoratore() : base()
        {
            Esperienze = 0;
        }

        public VitaT_Lavoratore(int esperienze, int matricola, string nome) : base(matricola, nome)
        {
            Esperienze = esperienze;
        }

        public override int punteggio()
        {
            int P = Esperienze * 20;
            return P;
        }

        public override bool isIdoneo()
        {
            if (punteggio() >= 60)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
