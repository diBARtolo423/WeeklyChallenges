using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            //return (c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z');
            return char.IsLetter(c);
            //throw new NotImplementedException();
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            //if(vals.Length % 2 == 0)
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}

            return (vals.Length % 2 == 0) ? true : false;
        }

        public bool IsNumberEven(int number)
        {
            //if(number % 2 ==0)
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}

            return (number % 2 == 0) ? true : false;
        }

        public bool IsNumberOdd(int num)
        {
            //if(num % 2 != 0)
            //{
            //    return true;
            //}
            //else
            //{ 
            //    return false;
            //}

            return (num % 2 != 0) ? true : false;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            //if (numbers == null) return 0;
            //return numbers.Min() + numbers.Max();

            return numbers?.Any() ?? false ? numbers.Min() + numbers.Max() : new double { };
            //throw new NotImplementedException();

            //if (numbers == null || numbers.Count() == 0)
            //{
            //    return 0;
            //}
            //double min = 0;
            //var max = 0.0;

            //foreach (var num in numbers)
            //{
            //    if (num > max)
            //    {
            //        max = num;
            //    }
            //    if (num < min)
            //    {
            //        min = num;
            //    }
            //    if (numbers.Count() <= 1)
            //    {
            //        min = num;
            //    }
            //}
            //return min + max;
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            //return Math.Min(str1.Length, str2.Length);
            return str1.Length < str2.Length ? str1.Length : str2.Length;
            //throw new NotImplementedException();
        }

        public int Sum(int[] numbers)
        {
            //if (numbers == null)
            //{
            //    return 0;
            //}
            //var sum = 0;
            //for (var i = 0; i < numbers.Length; i++)
            //{
            //    sum += numbers[i];
            //}
            //return sum;
            //throw new NotImplementedException();
            return (numbers == null) ? 0 : numbers.Sum();
        }

        public int SumEvens(int[] numbers)
        {
            //if (numbers == null)
            //{
            //    return 0;
            //}
            //int sum = 0;
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 0)
            //    {
            //        sum += numbers[i];
            //    }
            //}
            //return sum;

            //return (numbers == null) ? 0 : numbers.Where(x => x % 2 == 0).Sum();

            return numbers?.Where(x => x % 2 == 0).Sum() ?? 0;

        }

        public bool IsSumOdd(List<int> numbers)
        {
            //if (numbers == null)
            //{
            //    return false;
            //}
            //var num = numbers.Sum();
            //if (num % 2 != 0)
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}

            //var sum = 0;
            //for (int i = 0; i < numbers.Count; i++)
            //{
            //    sum+= numbers[i];
            //}
            //return (sum % 2 != 0);

            return (numbers == null) ? false : numbers.Sum() % 2 != 0;

            //throw new NotImplementedException();
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            //throw new NotImplementedException();

            //if (number <= 0)
            //{
            //    return 0;
            //}
            //else
            //{
            //    return number / 2;
            //}

            return (number <= 0) ? 0 : number / 2;
        }
    }
}
