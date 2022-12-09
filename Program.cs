using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe4_001
{
    class Stacks
    {
        private string[] Beatrix;
        private int top;
        private int max;
        public Stacks()
        {
            Beatrix = new string[21];
            top = -1;
            max = 21;
        }
        public void push()
        {
            string Data;
            if (top == max - 1)
            {
                Console.WriteLine("\nMaksimal Element");
            }

        }
    }
}
