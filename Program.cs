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
        public void Display()
        {
            for (int i = top; i >= 0; i--)
            {
                Console.WriteLine(Beatrix[i]);
            }
            if (top == -1)
            {
                Console.WriteLine("Stack Kosong");
            }
        }

        static void Main(string[] args)
        {
            Stacks s = new Stacks();
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("\n**Stack Menu**\n");
                Console.WriteLine("1. Push. ");
                Console.WriteLine("2. Pop. ");
                Console.WriteLine("3.Display. ");
                Console.WriteLine(" 4.Exit. ");
                Console.Write("\nMasukkan Pilihan : ");
                string sInput = Console.ReadLine();
                char ch = Convert.ToChar(sInput == "" ? "0" : sInput);
                switch (ch)
                {
                    case '1':
                        s.push();
                        break;
                    case '2':
                        s.pop();
                        break;
                    case '3':
                        s.Display();
                        break;
                    case '4':
                        return;
                    default:
                        Console.WriteLine("\nPilihan Salah ");
                        break;
                }
            }
        } 
    }
}



