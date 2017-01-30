﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DRAFT
{
    class Complex
    {
        int a, b;
        public Complex()
        {
            a = 0;
            b = 0;
        }

        public Complex(int _a, int _b)
        {
            a = _a;
            b = _b;
        }
        public int A
        {
            get
            {
                return a;
            }
            set
            {
                a = value;
            }
        }
        public int B
        {
            get
            {
                return b;
            }
            set
            {
                b = value;
            }
        }
        public static Complex operator +(Complex x, Complex y)
        {
            Complex z = new Complex();
            z.A = x.A + y.A;
            z.B = x.B + y.B;
            return z;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Complex z1 = new Complex(1, 3);
            Complex z2 = new Complex(2, 5);
            Complex z3 = z1 + z2;
            Console.WriteLine("z=" + z3.A + "+" + z3.B + "i");
            Console.WriteLine("Press any key to quit");
            Console.ReadKey();
        }
    }
}
