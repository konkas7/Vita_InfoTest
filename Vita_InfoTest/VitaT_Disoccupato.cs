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
                if (VitaT_voto == 110)
                {
                    try
                    {
                        VitaT_lode = value;
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
            Voto = 0;
            Lode = false;
        }

        public VitaT_Disoccupato(int voto, bool lode, int matricola, string nome) : base(matricola, nome)
        {
            Voto = voto;
            Lode = lode;
        }

        public override int punteggio()
        {
            int a = (Voto * 100) / 110;
            if (Lode == true)
                a += 5;

            return a;
        }

        public override bool isIdoneo()
        {
            if (Voto >= 72)
            {
                return true;
            }
            else
                return false;
        }


    }
}
