using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dict2
{
    class Program
    {
        static void Main(string[] args)
        {
            var dictonaryNew = new List<DictonaryNew<string, int>>();

            string text = "Вот дом, Который построил Джек. А это пшеница, Которая в темном  чулане хранится В доме, " +
                "Который построил Джек. А это веселая птица­ синица, Которая часто ворует пшеницу," +
                " Которая в темном чулане хранится В доме, Который построил Джек.";
            string[] separators = { ",", ".", "!", "?", ";", ":", " " };
            string[] words = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            int count = 0;
            foreach (string tx in words)
            {
                for (int i = 0; i < words.Length - 1; i++)
                {
                    if (tx == words[i])
                    {
                        count++;
                    }
                }
                dictonaryNew.Add(new DictonaryNew<string, int> { Key = tx, Values = count});
                //dictonaryNew.Values = count;

                count = 0;
            }
            foreach (var dc in dictonaryNew)
            {   
                Console.WriteLine($"слово - {dc.Key} \t кол-во - {dc.Values}");
            }
           
        }
    }
}
