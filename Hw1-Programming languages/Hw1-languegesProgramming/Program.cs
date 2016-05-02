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
        int[] digits;
        

        public Number(string digits, int n)
        {
            int powerOfTwo = 1;
            this.digits = new int[n];
            while (powerOfTwo < n && powerOfTwo < 2147483648)
                powerOfTwo *= 2;

            for (int i = 0; i < powerOfTwo; i++)
                this.digits[i] = (digits[i] - '0');

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

        public static Number operator +(Number b1, Number b2)//adding two binary numbers
        {
            int i, j, k, carry =0;
            int n = (b1.n > b2.n ? b1.n : b2.n);
            Number num = new Number("0",n);
            for (i = b1.n, j = b2.n, k = num.n; i >= 0; i--, j--, k--)
            {
                int sum = b1.digits[i] + b2.digits[j] + carry;
                if(sum == 2)
                {
                    carry = 1;
                    sum = 1;
                }
                num.digits[k] = sum;
            }
            num.digits[k-1] = carry;
            return num;
        }
        public static Number operator *(Number b1,Number b2)
        {
            Number num = new Number();
            
            int i;
            for (i = 0; i < b1.n; i++)
            {
                shiftLeft(num.digits);

            }

            return num;

            

        }
        public static void shiftLeft(int []arr)
        {
            int i;
            int[] newarr = new int[arr.Length];
            for (i = 0; i < arr.Length - 1; i++)
                newarr[i] = arr[i+1];
            newarr[arr.Length - 1] = 0;
         
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
