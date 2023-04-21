using RandomString.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomString.SentenceGenMethod
{
    public static class ANAVAO
    {
        public static string GenerateSentence()
        {
            string sentence = string.Format("{0}{1}{2}{3}了{4}{5}",
                PublicAlgorithm.RandomChoice(StringLib._adjectives),
                PublicAlgorithm.RandomChoice(StringLib._nouns),
                PublicAlgorithm.RandomChoice(StringLib._adverbs),
                PublicAlgorithm.RandomChoice(StringLib._verbs),
                PublicAlgorithm.RandomChoice(StringLib._adjectives),
                PublicAlgorithm.RandomChoice(StringLib._objects));
            return sentence;
        }
    }
}
