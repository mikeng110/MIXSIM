using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIXSIM.logic
{
    public class MemStrip
    {
        private int size;
        private Tuple<int, int> field;
        private Tuple<bool,char> [] memory;
        private Boolean sign; //true is plus

        public MemStrip(int s)
        {
            size = s;
            sign = true;
            field = new Tuple<int, int>(0,size);
            memory = new Tuple<bool, char>[size];
            initMem();

        }
        public void initMem()
        {
            for(int i = 0; i < size; i++)
            {
                memory[i] = new Tuple<bool, char>(true, '0');
            }
        }  
        public void setField(int f1, int f2)
        {
            field = new Tuple<int, int>(f1, f2);

        }
        public void printMem()
        {
            String output = "[ ";
            if (sign)
            {
                output += "+";
            }
            else
                output += "-";

            foreach(Tuple<bool, char> cell in memory)
            {
                if (cell.Item1)
                {
                    output += " | ";
                }
                else
                {
                    output += " : ";
                }
                output += cell.Item2;
            }
            output += " ]";

            Console.WriteLine(output);
        }
    }
}
