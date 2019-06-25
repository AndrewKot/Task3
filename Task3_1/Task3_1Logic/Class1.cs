using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_1Logic
{
    static public class FundingNumberClass
    {
        public static int Number(List<int> list)
        {
            bool flag = false;
            int i = 1;
            int number = -1;
            while (i != list.Count - 2)
            {
                Console.WriteLine("LeftSum = {0}, RightSum = {1}", LeftSum(list, i), RightSum(list, i));
                if (LeftSum(list, i) == RightSum(list, i))
                {
                    flag = true;
                    break;
                }
                i++;
            }
            if (flag)
            {
                return i;
            }
            else
            {
                return number;
            }
        }

        public static int LeftSum(List<int> list, int number)
        {
            int sum = 0;

            for (int i = 0; i < number; i++)
            {
                sum += list[i];
            }
            return sum;
        }

        public static int RightSum(List<int> list, int number)
        {
            int sum = 0;

            for (int i = number + 1; i < list.Count; i++)
            {
                sum += list[i];
            }
            return sum;
        }
    }
}
