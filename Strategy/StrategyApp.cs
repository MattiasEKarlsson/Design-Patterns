using Design_Patterns_Assignment.Strategy;
using Design_Patterns_Assignment.Strategy.Messages;
using Design_Patterns_Assignment.Strategy.Sender;
using System;

namespace Design_Patterns_Assignment
{
    internal class StrategyApp : IStrategyApp
    {
        

        public ISender Sender { get; set; }
        public IMessage SendEmail { get; set; }
        public IMessage SendSMS { get; set; }
        public IMessage SendFacebookMessage { get; set; }

        public StrategyApp(ISender sender, ISendEmail sendEmail, ISendSMS sendSMS, ISendFacebookMessage sendFacebookMessage)
        {
            Sender = sender;
            SendEmail = sendEmail;
            SendSMS = sendSMS;
            SendFacebookMessage = sendFacebookMessage;
            sender.Message = SendEmail;
        }

        string message = "This is the message";
        public void Run()
        {
            Console.WriteLine("F: Send Message");
            Console.WriteLine("W: Use Email");
            Console.WriteLine("S: Use SMS");
            Console.WriteLine("X: Use Facebook Message");
            Console.WriteLine("E: Exit Program");

            while (true)
            {
                // Get User Input
                char userInput = Console.ReadKey(true).KeyChar;

                switch (userInput)
                {
                    case 'f' or 'F':
                        ClearRow();
                        Sender.Send(message);
                        break;

                    case 'w' or 'W':
                        ClearRow();
                        Console.Write("Switching to the Email");
                        Sender.Message = SendEmail;
                        break;

                    case 's' or 'S':
                        ClearRow();
                        Console.Write("Switching to the SMS");
                        Sender.Message = SendSMS;
                        break;
                    case 'x' or 'X':
                        ClearRow();
                        Console.Write("Switching to the Facebook Message");
                        Sender.Message = SendFacebookMessage;
                        break;



                    case 'e' or 'E':
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
            Console.SetCursorPosition(1, 9);

            // Clear Row
            Console.Write("\r" + new string(' ', Console.BufferWidth) + "\r");
        }
    }
}