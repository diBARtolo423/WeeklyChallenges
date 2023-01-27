using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            //throw new NotImplementedException();
            foreach (bool val in vals)
            {
                if (!val)
                {
                    return true;
                }
            }
            return false;

            //return vals.Contains(false);
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            //throw new NotImplementedException();
            if (numbers == null) return false;

            int sum = 0;
            foreach (int number in numbers)
            {
                if (number % 2 != 0)
                {
                    sum += number;
                }
            }
            return sum % 2 != 0;

            //return (numbers == null) ? false : (numbers.Where(x => x % 2 != 0).Sum() % 2 != 0);            
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            //throw new NotImplementedException();
            bool hasUpper = false, hasLower = false, hasNumber = false;
            foreach (char c in password)
            {
                if (char.IsUpper(c))
                {
                    hasUpper = true;
                }
                else if (char.IsLower(c))
                {
                    hasLower = true;
                }
                else if (char.IsNumber(c))
                {
                    hasNumber = true;
                }
                if (hasUpper && hasLower && hasNumber)
                {
                    return true;
                }
            }
            return false;

        }

        public char GetFirstLetterOfString(string val)
        {
            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            return val.Last();
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if(divisor == 0)
            {
                return 0;
            }
            return dividend / divisor;

            //return (divisor == 0) ? 0 : dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[nums.Length - 1] - nums[0];

            //return nums[^1] - nums[0];

            //return nums.Last() - nums.First();
        }

        public int[] GetOddsBelow100()
        {
            var list = new List<int>();
            
            for (var i = 0; i < 100; i++)
            {
                if(i % 2 != 0)
                {
                    list.Add(i);
                }
            }

            return list.ToArray();

            //return Enumerable.Range(0, 100).Where(x => x % 2 != 0).ToArray();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for(var i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }
        }
    }
}
