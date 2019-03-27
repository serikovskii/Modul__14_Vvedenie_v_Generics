using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dictonary = new Dictionary<string, int>();

            string text = "Вот дом, Который построил Джек. А это пшеница, Которая в темном  чулане хранится В доме, " +
                "Который построил Джек. А это веселая птица­ синица, Которая часто ворует пшеницу," +
                " Которая в темном чулане хранится В доме, Который построил Джек.";

            string[] separators = { ",", " " };
            string[] words = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            int count = 1;
            foreach (string tx in words)
            {
                if (dictonary.Count == 0)
                    dictonary.Add(tx, count);
                else 
                    if (dictonary.ContainsKey(tx))
                       dictonary[tx] +=1;
                    else
                        dictonary.Add(tx, count);
            }
            foreach(var kv in dictonary)
            {
                Console.WriteLine($" слово {kv.Key} \t кол-во {kv.Value}");
            }
        }
    }
}
