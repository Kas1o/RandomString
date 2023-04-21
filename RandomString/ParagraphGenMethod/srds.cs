using RandomString.SentenceGenMethod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace RandomString.ParagraphGenMethod
{
    public static class srds
    {
        public static string gen()
        {
            List<string> sentences = new List<string>();
            sentences.Add("根据你说的");
            sentences.Add(ANAVAO.GenerateSentence());
            sentences.Add(",我提出以下观点，首先");
            sentences.Add(ANAVAO.GenerateSentence());
            sentences.Add(".其次");
            sentences.Add(ANAVAO.GenerateSentence());
            sentences.Add(".然后");
            sentences.Add(ANAVAO.GenerateSentence());
            sentences.Add(".由此易得");
            sentences.Add(ANAVAO.GenerateSentence());
            sentences.Add(".总之");
            sentences.Add(ANAVAO.GenerateSentence());

            string article = string.Join("", sentences) + ".";
            return article;
        }
    }
}
