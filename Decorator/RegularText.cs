using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Decorator
{
    public class RegularText : IRegularText
    {
        public string Description { get; private set; }
        public RegularText(string description)
        {
            Description = " ";
        }

        public string DescriptionText(string input)
        {
            return Description;
        }
    }
}
