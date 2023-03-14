using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace PalindromCheck
{
    class Palin
    {
        public Palin(string s)
        {
            char[] s1 = new char[s.Length];
            int j = 0;
            string s2 = "";
            bool b = true;
            BigInteger I = Fact(s.Length);
            List<string> list = new List<string> { s };
            for (BigInteger i = 0; i < I; i++)
            {
                foreach (var item in UniqueRandom(0, s.Length - 1))
                {
                    s1[item] = s[j];
                    j++;
                }
                j = 0;
                s2 = new string(s1);
                foreach (var item in list)
                {
                    if (s2 == s)
                    {
                        break;
                    }
                    if (item.Equals(s2))
                    {
                        list.Remove(s2);
                        break;
                    }
                    else
                    {
                        list.Add(s2);
                        break;
                    }
                }
                if (Pali(s2) == true)
                {
                    Console.WriteLine(s2);
                    b = true;
                    break;
                }
                else
                {
                    b = false;
                }
            }
            Console.WriteLine(b);
        }
        public IEnumerable<int> UniqueRandom(int minInclusive, int maxInclusive)
        {
            List<int> candidates = new List<int>();
            for (int i = minInclusive; i <= maxInclusive; i++)
            {
                candidates.Add(i);
            }
            Random rnd = new Random();
            while (candidates.Count > 0)
            {
                int index = rnd.Next(candidates.Count);
                yield return candidates[index];
                candidates.RemoveAt(index);
            }
        }
        public bool Pali(string myString)
        {
            int length = myString.Length;
            for (int i = 0; i < length / 2; i++)
            {
                if (myString[i] != myString[length - i - 1])
                    return false;
            }
            return true;
        }
        public BigInteger Fact(int i)
        {
            if (i == 0 || i == 1)
                return 1;
            else
                return i * Fact(i - 1);
        }
    }
}
