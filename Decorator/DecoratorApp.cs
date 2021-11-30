
using Design_Patterns_Assignment.Decorator.Decorators;
using Design_Patterns_Assignment.Decorator.Decorators.Important;
using Design_Patterns_Assignment.Decorator.Decorators.Insert;
using Design_Patterns_Assignment.Decorator.Decorators.Italic;
using Design_Patterns_Assignment.Decorator.Decorators.Marked;
using Design_Patterns_Assignment.Decorator.Decorators.Smaller;
using Design_Patterns_Assignment.Decorator.Decorators.Subscript;
using Design_Patterns_Assignment.Decorator.Decorators.Superscript;
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
            Console.WriteLine("  Add Tags.   ");
            Console.WriteLine("---------------------");
            Console.WriteLine("A: Finished");
            Console.WriteLine("---------------------");
            Console.WriteLine("B: Bold");
            Console.WriteLine("C: Deleted");
            Console.WriteLine("D: Emphasized ");
            Console.WriteLine("E: Important ");
            Console.WriteLine("F: Insert ");
            Console.WriteLine("G: Italic ");
            Console.WriteLine("H: Marked ");
            Console.WriteLine("I: Smaller ");
            Console.WriteLine("J: Subscript ");
            Console.WriteLine("K: Superscript ");
            Console.WriteLine("Ö: Exit ");

            Text.SetInput();


            //Main Loop
            while (true)
            {
                // Get User Input
                var userInput = Console.ReadKey(true).KeyChar;

                switch (userInput)
                {
                    case 'a' or 'A':
                        ClearRow();
                        Console.WriteLine($"Generated text: {Text.GetDescription()}");
                        Text = newText;
                        break;

                    case 'b' or 'B':
                        ClearRow();
                        Console.WriteLine("Adding Bold");
                        Text = new Bold(Text);
                        break;
                    case 'c' or 'C':
                        ClearRow();
                        Console.WriteLine("Adding Deleted");
                        Text = new Deleted(Text);
                        break;
                    case 'd' or 'D':
                        ClearRow();
                        Console.WriteLine("Adding Emphasized");
                        Text = new Emphasized(Text);
                        break;
                    case 'e' or 'E':
                        ClearRow();
                        Console.WriteLine("Adding Important");
                        Text = new Important(Text);
                        break;
                    case 'f' or 'F':
                        ClearRow();
                        Console.WriteLine("Adding Inserted");
                        Text = new Insert(Text);
                        break;
                    case 'g' or 'G':
                        ClearRow();
                        Console.WriteLine("Adding Italic");
                        Text = new Italic(Text);
                        break;
                    case 'h' or 'H':
                        ClearRow();
                        Console.WriteLine("Adding Marked");
                        Text = new Marked(Text);
                        break;
                    case 'i' or 'I':
                        ClearRow();
                        Console.WriteLine("Adding Smaller");
                        Text = new Smaller(Text);
                        break;
                    case 'j' or 'J':
                        ClearRow();
                        Console.WriteLine("Adding Subscript");
                        Text = new Subscript(Text);
                        break;
                    case 'k' or 'K':
                        ClearRow();
                        Console.WriteLine("Adding Superscript");
                        Text = new Superscript(Text);
                        break;
                    case 'ö' or 'Ö':
                        ClearRow();
                        Console.Write("Exiting program");
                        Environment.Exit(0);
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
            Console.SetCursorPosition(1, 18);

            // Clear Row
            Console.Write("\r" + new string(' ', Console.BufferWidth) + "\r");
        }
    }
        
}
