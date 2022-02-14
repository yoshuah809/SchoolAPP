using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolLibrary
{
    public class Student : Person
    {
        public enum GradeLevel { Freshman, Sophomore, Junior, Senior}
        public GradeLevel Level { get; set;}
       
    }
}
