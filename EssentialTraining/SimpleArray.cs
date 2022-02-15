using System;
using System.Collections.Generic;
using System.Text;

namespace EssentialTraining
{
    public class SimpleArray
    {
        public string[] gList;

        public SimpleArray()
        {
            gList = new string[4] {"Bread", "Milk","Eggs", "Cheese"};  
        }

        public override string ToString()
        {
            return $"There are {gList.Length} and there are ";
        }
    }
}
