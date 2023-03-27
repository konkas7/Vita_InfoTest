using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vita_InfoTest
{
    public abstract class VitaT_Disoccupato : VitaT_Candidato
    {
        private int VitaT_voto;
        private bool VitaT_lode;



        public int Voto
        {
            get { return VitaT_voto; }
            set {
                if (value >= 0 && value <= 110)
                {
                    VitaT_voto = value;
                }
                else
                    throw new Exception("Voto non valido!");
            }
        }

        public bool Lode
        {
            get { return VitaT_lode; }
            set {
                if (VitaT_voto == 105)
                {
                    try
                    {
                        VitaT_lode = value;
                        VitaT_voto = VitaT_voto + 5;
                    }
                    catch
                    {
                        throw new Exception("Lode non valida");
                    }
                }
                else
                    throw new Exception("Lode non disponibile");
            }
        }

        public VitaT_Disoccupato()
        {
            VitaT_voto = 0;
            VitaT_lode = false;
        }

        public VitaT_Disoccupato(int voto, bool lode, int matricola, string nome) : base(matricola, nome)
        {
            VitaT_voto = voto;
            VitaT_lode = lode;
        }

        public override int punteggio()
        {
            int a = (VitaT_voto * 100) / 110;
            if (VitaT_lode == true)
                a += 5;

            return a;
        }

        public override bool isIdoneo()
        {
            if (VitaT_voto >= 72)
            {
                return true;
            }
            else
                return false;
        }
    }
}
