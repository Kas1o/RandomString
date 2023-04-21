using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomString.Lib
{
    public static class PublicAlgorithm
    {
        static Random random = new Random();
        public static T RandomChoice<T>(T[] array)
        {
            return array[random.Next(array.Length)];
        }
    }
}
