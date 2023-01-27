using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
                  
        public int AddEvenSubtractOdd(int[] numbers)//<<--MODIFIER, RETURN TYPE, METHOD NAME, PARAMETERS
        { //<<--SCOPE
            int total = 0;
            for(int i = 0; i < numbers.Length; i++)
            {
                if(numbers[i] % 2 == 0)
                {
                   total += numbers[i];
                }
                else if(numbers[i] % 2 != 0) 
                {
                    total -= numbers[i];
                }
            }
            return total;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            List<string> stringList = new List<string>() { str1, str2, str3, str4 };
            return stringList.Min(x => x.Length);
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            int[] array = new int[] { number1, number2, number3, number4 };
            return array.Min();
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
           if(sideLength1 + sideLength2 > sideLength3 &&
              sideLength2 + sideLength3 > sideLength1 &&
              sideLength1 + sideLength3 > sideLength2)
            {
                return true;
            }
           else
            {
                return false;
            }
        }

        public bool IsStringANumber(string input)
        {
            double n;
            bool isANumber = double.TryParse(input, out n);
            return isANumber;
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            return objs.Where(x => x == null).Count() > (objs.Count() / 2);
        }

        public double AverageEvens(int[] numbers)
        {
            if(numbers == null || numbers.Length == 0 )
            {
                return 0;
            }
            double total = 0;
            int count = 0;
            for(int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    total += numbers[i];
                    count++;
                }
                
            }
            if(count == 0)
            {
                return 0;
            }
            return total / count;
        }

        public int Factorial(int number)
        {
            if(number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            if(number == 1 || number == 0)
            {
                return 1;
            }
            if(number >= 2)
            {
                var factorial = number * Factorial(number - 1);
                return factorial;
            }
            return 0;
        }
    }
}
