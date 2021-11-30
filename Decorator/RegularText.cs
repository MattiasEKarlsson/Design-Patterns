using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Decorator
{
    public class RegularText : IRegularText
    {
        public RegularText()
        {
            Description = GetInput();
        }

        public string Description { get; set; }
        public string GetDescription()
        {
            return Description;
        }

        public string GetInput()
        {
            Console.WriteLine("Enter text that you want to decorate:");
            string input = Console.ReadLine();
            return input;
        }
    }
}
