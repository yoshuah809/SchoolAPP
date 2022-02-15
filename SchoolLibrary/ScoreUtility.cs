using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolLibrary
{
    internal class ScoreUtility
    {
        public static IScored BestofTwo(IScored assigment1, IScored assigment2)
        {
            var score1 = assigment1.Score / assigment1.MaximumScore;
            var score2 = assigment2.Score / assigment2.MaximumScore;

            var result = score1 > score2 ? assigment1 : assigment2;
            return result;
        }
    }
}
