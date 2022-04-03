using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2
{
    class Equip : Card
    {
        public string effectPoints;
        public Affinity affinity;
        public targetAttribute TargetAttribute;

        public enum targetAttribute
        {
            AP,
            RP,
            ALL,
        }


    }
}
