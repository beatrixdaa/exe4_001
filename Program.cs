using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe4_001
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
            else
            {
                Console.WriteLine("Masukkan Element");
                Data = Console.ReadLine();
                top = top + 1;
                Beatrix[top] = Data;
                Console.WriteLine("Data telah di Push");
            }
        }
        public void pop()
        {
            if (top == -1)
            {
                Console.WriteLine("Tidak ada Elemen yang bisa di Delete");
            }
            else
            {
                top = top - 1;
                Console.Write("Element telah di Delete");

            }
        }
    }
}



