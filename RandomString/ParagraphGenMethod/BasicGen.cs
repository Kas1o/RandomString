using RandomString.SentenceGenMethod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomString.ParagraphGenMethod
{
    public static class BasicGen
    {
        public static void NumberGen(int GenNumber)
        {
            int n_sentences = GenNumber;
            List<string> sentences = new List<string>();
            for (int i = 0; i < n_sentences; i++)
            {
                sentences.Add(ANAVAO.GenerateSentence());
            }

            string article = string.Join(". ", sentences) + ".";
            Console.WriteLine(char.ToUpper(article[0]) + article.Substring(1));
        }
    }
}
