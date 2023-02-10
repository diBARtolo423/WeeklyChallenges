using System;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            var sum = 0;
            foreach(var num in numbers)
            {
                if (num % 2 == 0)
                {
                    sum += num;
                }
                else
                {
                    sum -= num;
                }
            }
            return sum;

            //return numbers.Where(x => x % 2 == 0).Sum() - numbers.Where(x => x % 2 != 0).Sum();
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            int[] lengths = new int[] {str1.Length, str2.Length, str3.Length, str4.Length};
            return lengths.Min();

            //return new List<string>() { str1, str2, str3, str4 }.Min(x => x.Length);
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            int[] smallest = new int[] {number1, number2, number3, number4};
            return smallest.Min();
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            return (sideLength1 + sideLength2 > sideLength3) && (sideLength1 + sideLength3 > sideLength2) && (sideLength2 + sideLength3 > sideLength1);
        }

        public bool IsStringANumber(string input)
        {
            return double.TryParse(input, out double result);
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            if (objs == null || objs.Length == 0)
            {
                return false;
            }

            int nullCount = objs.Count(obj => obj == null);
            return nullCount > objs.Length / 2;
        }

        public double AverageEvens(int[] numbers)
        {
            //double sum = 0;
            //double count = 0;

            //if (numbers == null)
            //    {
            //    return 0;
            //}

            //foreach (int num in numbers)
            //{
            //    if (num % 2 == 0)
            //    {
            //        sum = +num;
            //        count++;
            //    }
            //}

            //if (count > 0)
            //{
            //    return sum / count;
            //}
            //else
            //{
            //    return 0;
            //}

            return (numbers?.Where(x => x % 2 == 0).Count() > 0) ? numbers.Where(x => x % 2 == 0).Average() : 0;
        }

        public int Factorial(int number)
        {
            //var fact = 1;

            //if (number < 0)
            //{
            //    throw new ArgumentOutOfRangeException();
            //}

            //for (int i = number; i > 0; i--)
            //{
            //    fact *= i;
            //}

            //return fact;

            return (number == 0) ? 1 : Enumerable.Range(1, number).Aggregate((f, s) => f * s);
        }
    }
}
