using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_3Logic
{
    public class Class1
    {
        // insert number 'a' in bit representation in number 'b' in a bit representation
        // from 'i' to 'j' bits
        public static int Insertion(int a, int b, int i, int j)
        {
            // Checking input data
            if (i >= j || i > 32)
            {
                throw new System.Exception();
            }

            // create temp data
            int temp = 0;
            int[] tempA, tempB, tempIJ, finalTemp;

            // writing in 'tempA' and 'tempB' 'a' and 'b' in a bit representation
            tempA = BitArray(a);
            tempB = BitArray(b);

            // extrudeing memory and writing in 'tempIJ' first bits of 'b' in 'tempIJ'
            tempIJ = new int[j - i + 1];
            for (int m = 0; m < j - i + 1; m++)
            {
                tempIJ[m] = tempB[m];
            }

            // insertion
            finalTemp = new int[32];
            for (int n = 0; n < i; n++)
            {
                finalTemp[n] = tempA[n];
            }
            for (int n = i; n < j + 1; n++)
            {
                finalTemp[n] = tempIJ[n - i];
            }
            for (int n = j + 1; n < 32; n++)
            {
                finalTemp[n] = tempA[n];
            }

            // transfer bit representation in decimal
            int power = 1;
            for (int n = 0; n < 32; n++)
            {
                temp += finalTemp[n] * power;
                power *= 2;
            }

            return temp;
        }

        // function of transfer decimal namber in bit namber and writing it in int array
        public static int[] BitArray(int value)
        {
            // create temp data
            int[] temp = new int[32];

            // create BitArray and writing into it 'value'
            BitArray tempBit = new BitArray(new int[] { value });

            // writin bits in int array
            for (int i = 0; i < tempBit.Length; i++)
            {
                temp[i] = Convert.ToInt32(tempBit[i]);
            }

            return temp;
        }
    }
}
