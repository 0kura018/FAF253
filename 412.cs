using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main()
        {
            int tmp = 0;
            //BigInteger bigNumber = BigInteger.Parse("1828497431380096579630069"); //NO DIVISORS!!!!!!!! 14 minutes gone...
            BigInteger bigNumber1 = BigInteger.Parse("214769443120931514639320840852363");
            for (int i = 9999999; i > 0; i--)
            {
                BigInteger divisor = BigInteger.Parse(i.ToString());
                if (divisor % 2 != 0)
                    if (bigNumber1 % divisor == 0)
                    {
                        Console.WriteLine(i + " sigma");
                        break;
                    }
            }

            for (int i = 999999; i > 99999; i--)
            {
                for (int j = 0; j < i.ToString().Length; j++)
                {
                    tmp += int.Parse(i.ToString()[j].ToString());
                    //Console.WriteLine(tmp);
                }
                if (tmp == 38 && IsPrime(i)) { Console.WriteLine(i); }
                else
                {
                    tmp = 0;
                }
            }

            Main1();
        }

        public static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number <= 3) return true;
            if (number % 2 == 0) return false;


            for (int i = 3; i <= Math.Sqrt(number); i += 2)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }

        static void Main1()
        {
            Dictionary<int, string> table = new Dictionary<int, string>()
        {
            { 1, "A" }, { 2, "B" }, { 3, "C" }, { 4, "D" }, { 5, "E" },
            { 6, "F" }, { 7, "G" }, { 8, "H" }, { 9, "I" }, { 10, "J" },
            { 11, "K" }, { 12, "L" }, { 13, "M" }, { 14, "N" }, { 15, "O" },
            { 16, "P" }, { 17, "Q" }, { 18, "R" }, { 19, "S" }, { 20, "T" },
            { 21, "U" }, { 22, "V" }, { 23, "W" }, { 24, "X" }, { 25, "Y" },
            { 26, "Z" }, { 27, " " }, { 28, "*" }, { 29, ")" }, { 30, "!" },
            { 31, ":" }, { 32, "(" }, { 33, "-" }, { 34, "+" }, { 35, "!" },
            { 36, "1" }, { 37, "2" }, { 38, "3" }, { 39, "4" }, { 40, "5" },
            { 41, "6" }, { 42, "7" }, { 43, "8" }, { 44, "9" }, { 45, "0" }
        };

            string cipherText1 = "011415142513152119270601063337392827011805272008052702051920197"; //Big numnber / by key (999371)
            string cipherText2 = "1805032015182721204965"; //Big numnber / by key (1013)
            string cipherText3 = "212013270603091327383337453951"; //Big numnber / by key (1013)
            int blockSize = 2;


            string decodedMessage = "";

            for (int i = 0; i < cipherText1.Length; i += blockSize)
            {
                if (i + blockSize > cipherText1.Length)
                    break;

                string block = cipherText1.Substring(i, blockSize);
                int num = int.Parse(block);

                if (num <= 45)
                    decodedMessage += table[num];


            }
            Console.WriteLine("Decoded Message: " + decodedMessage);
            decodedMessage = "";
            for (int i = 0; i < cipherText2.Length; i += blockSize)
            {
                if (i + blockSize > cipherText2.Length)
                    break;

                string block = cipherText2.Substring(i, blockSize);
                int num = int.Parse(block);

                if (num <= 45)
                    decodedMessage += table[num];


            }
            Console.WriteLine("Decoded Message: " + decodedMessage);
            decodedMessage = "";
            for (int i = 0; i < cipherText3.Length; i += blockSize)
            {
                if (i + blockSize > cipherText3.Length)
                    break;

                string block = cipherText3.Substring(i, blockSize);
                int num = int.Parse(block);


                if (num <= 45)
                    decodedMessage += table[num];


            }

            Console.WriteLine("Decoded Message: " + decodedMessage);
        }
    }
}
