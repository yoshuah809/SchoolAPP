﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolLibrary
{
    public class Teacher : Person
    {
        public string Subject { get; set; }
        
        //Fix implementation Later
        public override float ComputeGradeAverage() => 0.0f;
    }
}
