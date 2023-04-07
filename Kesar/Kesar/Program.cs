using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kesar
{
    class Program
    {
        public static  void Kesar(string s,int qayl)
        {
            //barda sarqely hayereni hamar anglernen tareri hamara grac bayc lriv ashxatuma baci  2-rd ketic
            //1-in u tary
            //2-rd tveri u simvolneri hamarar chem grel
            //string ab1 = "աբգդեզէըթժիլխծկհձղճմյնշոչպյռսվտրցւփքևօֆ";
            List<int> index  = new List<int>();
            string ab = "abcdefghijklmnopqrstuvwxyz";
            string s1= "";
            string c;
            for (int i = 0; i < s.Length; i++)
            {
                if (Char.IsUpper(s[i]))
                {
                    index.Add(i);
                }
            }
            s = s.ToLower();
            string[] sarr = new string[s.Length];
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = 0; j < ab.Length; j++)
                {
                    if (s[i] == ' ')
                    {
                        sarr[i]= " ";
                        break;
                    }
                    else if (s[i] == ab[j])
                    {
                        if (j + qayl >= ab.Length)
                        {
                            sarr[i]= ab[qayl - (ab.Length - j)].ToString();
                        }
                        else
                        {
                            sarr[i] = ab[j + qayl].ToString();
                        }
                    }
                        
                }
            }
            foreach (var item in index)
            {
                c =sarr[item];
                c = c.Replace(c, c.ToUpper());
                sarr[item]= c;
            }
            for (int i = 0; i < sarr.Length; i++)
            {
                s1+=sarr[i];
            }
            Console.WriteLine(s1);
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Console.Write("Nermuceq Texty:");
            string s = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Max Qayly 25n");
            Console.Write("Nermuceq Qatly:");
            int qayl = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Dzer Gaxtnagrvac Texty:");
            Kesar(s, qayl);
            Console.ReadKey();
        }
    }
}
