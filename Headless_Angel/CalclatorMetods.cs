using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Headless_Angel
{
    internal class CalclatorMetods : CALclaturRulles
    {
        public int Division(int Number1, int Number2)
        {
            return Number1 / Number2;
        }

        public int Minus(int Number1, int Number2)
        {
            return Number1 - Number2;
        }

        public int Multipl(int Number1, int Number2)
        {
            return Number1 * Number2;

        }

        public int Plus(int Number1, int Number2)
        {
            return Number1 + Number2;

        }
    }
}
