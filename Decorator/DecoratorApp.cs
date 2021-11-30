
using Design_Patterns_Assignment.Decorator.Decorators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Decorator
{
    public class DecoratorApp : IDecoratorApp
    {
        public DecoratorApp(IRegularText text)
        {
            Text = text;
        }

        public IText Text { get; set; }

        public void Run()
        {
            var newText = Text;
            Console.WriteLine("---------------------");
            Console.WriteLine("  Select an action   ");
            Console.WriteLine("---------------------");
            Console.WriteLine("F: Finished");
            Console.WriteLine("B: Bold");
            Console.WriteLine("D: Deleted");



            //Main Game Loop
            while (true)
            {
                // Get User Input
                var userInput = Console.ReadKey(true).KeyChar;

                switch (userInput)
                {
                    case 'f' or 'F':
                        ClearRow();
                        Console.WriteLine($"Generated text: {Text.GetDescription()}");
                        Text = newText;
                        break;

                    case 'b' or 'B':
                        ClearRow();
                        Console.WriteLine("Adding Bold");
                        Text = new Bold(Text);
                        break;
                    case 'd' or 'D':
                        ClearRow();
                        Console.WriteLine("Adding Deleted");
                        Text = new Deleted(Text);
                        break;
                    default:
                        ClearRow();
                        Console.Write("That is not a valid choice");
                        break;
                }
            }


            
            
            

            


            
            
        }
        private static void ClearRow()
        {
            // Set cursor below the menu
            Console.SetCursorPosition(1, 9);

            // Clear Row
            Console.Write("\r" + new string(' ', Console.BufferWidth) + "\r");
        }
    }
        
}
