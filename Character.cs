using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2
{
    class Character : Card
    {
        public int AP;
        public int RP;
        public Equip equip;
        public Affinity affinity;

        public Character(int AP, int RP, Equip equip, Affinity affinity)
        {
            Ap = AP;
            Rp = RP;

        }

        public int Ap
        {
            get => AP; set
            {
                if (value > 0)
                {
                    Ap = value;
                }
                else
                    throw new Exception("AP debe ser mayor que 0");
            }
        }

        public int Rp
        {
            get => RP;
            set
            {

            }
        }
    }
}
