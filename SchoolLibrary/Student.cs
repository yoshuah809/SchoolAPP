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

        public override float ComputeGradeAverage() => 4.0f;

        public override string SendMessage(string message)
        {
            var original = base.SendMessage(message);
            var sb = new StringBuilder();
            sb.AppendLine("This Message is private and confidential");
            return sb.ToString();   
        }

    }


}
