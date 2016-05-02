﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw1_languegesProgramming
{
    class Number
    {
        private int n;
        int[] digits;
        private string value;
        public int N
        {
            get { return n; }
            //set { N = n; }
        }
        public string val
        {
            get { return value; }
        }
        public Number(String value, int n)
        {

            int i;
            int powerOfTwo = 1;

            while (powerOfTwo < n && powerOfTwo < 2147483648)
            {
                powerOfTwo *= 2;
            }
            digits = new int[powerOfTwo];
            for (i = 0; i < powerOfTwo; i++)
                digits[i] = value[i];


        }
        public Number()
        {

        }

        /* public override string ToString()
         {
             int i = 0;
             for(i=0;i<value.Length;i++)
             return string.Format("{0}", digits[i]);
         }*/

        public override bool Equal(int x1, int x2)
        {

            if (x1 == x2)
            {
                return true;
            }
            return false;


        public static Number operator +(int[] c1, int[] c2)
        {
            
            for(int i=0;i<;i++)
            Return new Complex(c1.real + c2.real, c1.imaginary + c2.imaginary);
        }
    }
        class Program
    {
        static void Main(string[] args)
        {
            Number n1, n2, n3;
            int i;

            n1 = new Number();
            n2 = new Number();
            n1.HexString = "F4215";
            n2.HexString = "A352B";
            n3 = n1 + n2;

            Console.WriteLine("n1.N = " + n1.N);

            Console.WriteLine("n2.N = " + n2.N);

            Console.WriteLine("n3.N = " + n3.N);


            Console.WriteLine("{0} + {1} = {2}",
                     n1.ToString(), n2.ToString(), n3.ToString());

            Console.WriteLine("{0} + {1} = {2}",
                     n1.HexString, n2.HexString, n3.HexString);

            Console.WriteLine("digits n1:");
            for (i = 0; i < n1.N; i++)
                Console.Write(" {0} ", n1[i]);
            Console.WriteLine();
            n3 = n1 * n2;

            Console.WriteLine("n1.N = " + n1.N);

            Console.WriteLine("n2.N = " + n2.N);

            Console.WriteLine("n3.N = " + n3.N);

            Console.WriteLine("{0} * {1} = {2}",
                     n1.ToString(), n2.ToString(), n3.ToString());

            Console.WriteLine("{0} * {1} = {2}",
                     n1.HexString, n2.HexString, n3.HexString);

            Console.WriteLine("n1.N = " + n1.N);

            n1 = "1011110";
            n2 = "1100011";
            n3 = n1 + n2;

            Console.WriteLine("n1.N = " + n1.N);

            Console.WriteLine("n2.N = " + n2.N);

            Console.WriteLine("n3.N = " + n3.N);

            Console.WriteLine("{0} + {1} = {2}",
                     n1.ToString(), n2.ToString(), n3.ToString());

            Console.WriteLine("{0} + {1} = {2}",
                     n1.HexString, n2.HexString, n3.HexString);

            n3 = n1 * n2;

            Console.WriteLine("n1.N = " + n1.N);

            Console.WriteLine("n2.N = " + n2.N);

            Console.WriteLine("n3.N = " + n3.N);

            Console.WriteLine("{0} * {1} = {2}",
                     n1.ToString(), n2.ToString(), n3.ToString());

            Console.WriteLine("{0} * {1} = {2}",
                     n1.HexString, n2.HexString, n3.HexString);

            Console.WriteLine("n1.N = " + n1.N);



            
            
         n1 = new Number("1100011010101110011111", 128);
            
           
        n2 =  new Number("1011101001111000001111", 128);

            Console.WriteLine("n1.N = " + n1.N);

            Console.WriteLine("n2.N = " + n2.N);

            Console.WriteLine("n3.N = " + n3.N);

            n3 = n1 + n2;

            Console.WriteLine("{0} + {1} = {2}",
                     n1.ToString(), n2.ToString(), n3.ToString());

            Console.WriteLine("{0} + {1} = {2}",
                     n1.HexString, n2.HexString, n3.HexString);

            n3 = n1 * n2;
            Console.WriteLine("n1.N = " + n1.N);

            Console.WriteLine("n2.N = " + n2.N);

            Console.WriteLine("n3.N = " + n3.N);

            Console.WriteLine("{0} * {1} = {2}",
                     n1.ToString(), n2.ToString(), n3.ToString());

            Console.WriteLine("{0} * {1} = {2}",
                     n1.HexString, n2.HexString, n3.HexString);



           
           n1 =  new Number("11000110101011100111110001111111001111001111100111100110011", 128);
           
           n2 = new Number("10111010011110000011111111111100000111000111000011100011111", 128);

            n3 = n1 + n2;

            Console.WriteLine("n1.N = " + n1.N);

            Console.WriteLine("n2.N = " + n2.N);

            Console.WriteLine("n3.N = " + n3.N);

            Console.WriteLine("{0} + {1} = {2}",
                     n1.ToString(), n2.ToString(), n3.ToString());

            Console.WriteLine("{0} + {1} = {2}",
                     n1.HexString, n2.HexString, n3.HexString);

            n3 = n1 * n2;

            Console.WriteLine("n1.N = " + n1.N);

            Console.WriteLine("n2.N = " + n2.N);

            Console.WriteLine("n3.N = " + n3.N);

            Console.WriteLine("{0} * {1} = {2}",
                     n1.ToString(), n2.ToString(), n3.ToString());

            Console.WriteLine("{0} * {1} = {2}",
                     n1.HexString, n2.HexString, n3.HexString);



        }
    }
}
