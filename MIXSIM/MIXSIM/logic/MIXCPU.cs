using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIXSIM.logic
{
    public class MIXCPU
    {
        private static short MEMSIZE = 4000;
        private static short WORDSIZE = 5;
        private static short REGSIZE  = 2;
        private static short NRIREG = 6;
        private MemStrip memory;
        private MemStrip RegA;
        private MemStrip RegX;
        private MemStrip RegJ;
        private MemStrip[] RegI = new MemStrip[NRIREG];

        public MIXCPU()
        {
            memory = new MemStrip(WORDSIZE);
            RegA = new MemStrip(WORDSIZE);
            RegX = new MemStrip(WORDSIZE);
            RegJ = new MemStrip(REGSIZE);
            for (int i = 0; i < NRIREG; i++)
            {
                RegI[i] = new MemStrip(MEMSIZE);
            }
        }
    } 
}
