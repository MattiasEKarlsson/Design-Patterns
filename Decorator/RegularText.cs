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
            Description = "";
        }

        public string Description { get; set; }
        public string GetDescription()
        {
            return Description;
        }

        public void SetInput()
        {
            Console.SetCursorPosition(0, 20);
            bool validInput = false;
            while (!validInput)
            {
                Console.WriteLine("Enter text that you want to decorate:");
                string userInput = Console.ReadLine();

                if (!String.IsNullOrWhiteSpace(userInput))
                {
                    validInput = true;
                    Description = userInput;
                }
            }
            Console.WriteLine("Enter Tags.");
        }
    }
}
