using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw1_languegesProgramming
{
    class Number
    {
        private int n;
        char[] digits;
        

        public Number(string digits, int n)
        {

            int i;
            int powerOfTwo = 1;
            
            while (powerOfTwo < n && powerOfTwo < 2147483648)
            {
                powerOfTwo *= 2;
            }
           
            for (i = 0; i < powerOfTwo; i++)
               this. digits[i] = digits[i];

        }
        public Number()
        {
            Number num = new Number();
            num.n = 0;
            num.digits[0] = '0';
           
        }
        public int N { get { return n; } }
        

         public override string ToString()
         {
            int i;
            string ret = "";
            for (i = 0; i < n; i++)
                ret += digits[i].ToString();
            return ret;

         }

        public bool Equals(Number num)// hav to remove
        {
            int count = 0, i;
            if ((object)num == null)
            {
                return false;
            }

            for (i = 0; i < num.n; i++)
            {
                if (num.digits[i] == digits[i])//checks of all the digits of the binary num are equals
                    count++; ;
            }
            if (count == n)
                return true;
            else
                return false;
        }


        public static Number operator +(Number b1, Number b2)//adding two binary numbers
        {
            int i, j, k;
            Number num = new Number();
            bool carry = false;
            if (b1.n > b2.n)
                num.n = b1.n;
            else
                num.n = b2.n;
            for (i = b1.n, j = b2.n, k = num.n; i >= 0; i--, j--, k--)
            {
                char x = b1.digits[i];
                char y = j >= 0 ? b2.digits[j] : '0';

                if (carry)
                {
                    num.digits[k] = x == y ? '1' : '0';
                    carry = x == '1' || y == '1';
                }
                else
                {
                    num.digits[k] = x == y ? '0' : '1';
                    carry = x == '1' && y == '1';
                }
            }

            if (carry)
            {
                num.digits[0] = '1';
               
            }

            return num;

        }
        public  Number operator *(Number b1,Number b2)
        {

            
            
                   

            

        }
        public char [] shiftLeft(char[]arr,int n)
        {
            int i;
            char [] array = new char[arr.Length];
            array = null;
            for (i = arr.Length; i > n; i--)
                array[i-n] = arr[i];

            for (i = 0; i < n; i++)
                array[arr.Length - i] = '0';
            return array;
        }
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


            n2 = new Number("1011101001111000001111", 128);

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




            n1 = new Number("11000110101011100111110001111111001111001111100111100110011", 128);

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
