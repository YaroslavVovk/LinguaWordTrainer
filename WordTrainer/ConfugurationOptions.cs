using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordTrainer
{
    static class ConfugurationOptions
    {
        private static int wordCount = 10;
        private static bool fromEngtoRus = true;

        public static int WordCount { get => wordCount; set => wordCount = value; }
        public static bool FromEngtoRus { get => fromEngtoRus; set => fromEngtoRus = value; }
    }
}
