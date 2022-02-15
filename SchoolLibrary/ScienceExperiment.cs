using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolLibrary
{
    internal class ScienceExperiment: IScored
    {
        public string Hypotesys { get; set; }
        public string Material{ get; set; }

        public string Method { get; set; }
        public string Conclusion { get; set; }
        public float Score { get; set;}
        public float MaximumScore { get; set;}
    }
}
