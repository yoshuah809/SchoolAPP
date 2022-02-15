using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolLibrary
{
    internal static class ExtensionMethod
    {
        public static int WordCount(this string str)
        {
            var wordCount = str.Split(new char [] { ' ','.','?' }, StringSplitOptions.RemoveEmptyEntries).Length;
            return wordCount;
        }
    }
}
