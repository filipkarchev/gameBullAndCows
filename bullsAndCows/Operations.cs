using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bullsAndCows
{
    class Operations
    {

        public Operations()
        {

        }

        public static int numberLength;
        public static bool finish = false;
       

        public static int Bulls(int firstNumber, int secondNumber)
        {
            int countBulls = 0;
            for (int i = 0; i < numberLength; i++)
            {
                if (firstNumber.ToString()[i].Equals(secondNumber.ToString()[i]))
                    countBulls++;
            }
            return countBulls;
        }

        public static int Cows(int firstNumber, int secondNumber)
        {
            int countCows = 0;
            for (int i = 0; i < numberLength; i++)
            {
                for (int j = 0; j < numberLength; j++)
                {
                    if (firstNumber.ToString()[i].Equals(secondNumber.ToString()[j]))
                        countCows++;
                }

            }
            countCows -= Bulls(firstNumber, secondNumber);
            return countCows;
        }

        public static bool CheckNumber(string number)
        {
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i].Equals(0))
                    return false;

                for (int j = i + 1; j < number.Length; j++)
                {
                    if (number[j].Equals(number[i]))
                        return false;
                }
            }
            return true;
        }

        public static bool CheckIsNumber(string strNumber)
        {
            try
            { int number = int.Parse(strNumber);
            return true;
            }
            catch (Exception e)
            { return false; }

        }
    }
}
