using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Task3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("dorou");

            int a, b;

            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());

            string sa, sb;

            Console.WriteLine(Convert.ToString(a, 2));
            Console.WriteLine(Convert.ToString(b, 2));

            Console.WriteLine(Insertion(a, b, 0, 0));

            Console.WriteLine();

            var g = BitArray(Insertion(a, b, 0, 0));
            for (int i = 0; i < g.Length; i++)
            {
                Console.Write(Convert.ToString(g[i]));
            }
            
            
            //

            //byte[] aByte = BitConverter.GetBytes(a);
            //Array.Reverse(aByte);
            //byte[] bByte = BitConverter.GetBytes(b);
            //Console.WriteLine();

            //for (int i = 0; i < aByte.Length; i++)
            //{
            //    Console.Write(aByte[i]);
            //}
            //Console.WriteLine();
            //Console.WriteLine(Convert.ToString(aByte));
            //Console.WriteLine(Convert.ToString(bByte));

            Console.ReadLine();
        }

        public static int Insertion(int a, int b, int i, int j)
        {
            int temp = 0;
            int[] tempA, tempB, tempIJ, finalTemp;

            tempA = BitArray(a);
            tempB = BitArray(b);

            tempIJ = new int[j - i + 1];
            for (int m = 0; m < j - i + 1; m++)
            {
                tempIJ[m] = tempB[m];
            }

            finalTemp = new int[32];
            for (int n = 0; n < i; n++)
            {
                finalTemp[n] = tempA[n];
            }
            for (int n = i; n < j + 1; n++)
            {
                finalTemp[n] = tempIJ[n];
            }
            for (int n = j + 1; n < 32; n++)
            {
                finalTemp[n] = tempA[n];
            }

            int power = 1;
            for (int n = 0; n < 32; n++)
            {
                temp += finalTemp[n] * power;
                power *= 2;
            }

            return temp;

        }

        public static int[] BitArray(int value)
        {
            int[] temp = new int[32];
            BitArray tempBit = new BitArray(new int[] { value });
            
            for (int i = 0; i < tempBit.Length; i++)
            {
                temp[i] = Convert.ToInt32(tempBit[i]);
            }

            return temp;
        }
    }
}
