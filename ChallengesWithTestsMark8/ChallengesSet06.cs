using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            bool containsWord = false;
            if(string.Equals(words, null) || words.Contains(null))
            {
                return false;
            }
            if(ignoreCase == true)
            {
                word = word.ToLower();
                List<string> lc = words.Select(x => x.ToLower()).ToList();
                containsWord = lc.Contains(word);
            }
            if(ignoreCase == false)
            {
                containsWord = words.Contains(word);
            }
            return containsWord;
        }

        public bool IsPrimeNumber(int num)
        {
        
            if(num > 1)
            {
                return Enumerable.Range(1, num).Where(x => num % x == 0).SequenceEqual(new[] { 1, num });
            }
            return false;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            return str.IndexOf(str.Distinct().Reverse().Where(x =>str.Where(y => y.Equals(x)).Count() == 1).FirstOrDefault());
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            int count = 0;
            for(int i = 0; i < numbers.Length; i++)
            {
                int CurrentCount = 1; 
                for(int j = i + 1; j < numbers.Length; j++)
                {
                    if(numbers[i] != numbers[j])
                    {
                        break;
                    }
                    CurrentCount++;
                }
                if(CurrentCount > count)
                {
                    count = CurrentCount;
                }
            }
            return count;

        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            List<double> result = new List<double>();
            double[] nulls = new double[0];
            if(elements == null)
            {
                return nulls;
            }
            for (int i = 0; i < elements.Count; i++)
            {
                if (elements[i] % n == 0)
                {
                    result.Add(elements[i]);
                }
                if (n < 0 || n > elements.Count)
                {
                    result.Clear();
                }
            }
            double[] answer = result.ToArray();
            return answer;
        }
    }
}
