using Design_Patterns_Assignment.Decorator;
using Design_Patterns_Assignment.Observer;
using Design_Patterns_Assignment.Repository;
using Design_Patterns_Assignment.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment
{
    public class Application : IApplication
    {
        public Application(IRepositoryApp repository, IStrategyApp strategy, IObserverApp observer)
        {
            Repository = repository;
            Strategy = strategy;
            Observer = observer;
        }

        public IRepositoryApp Repository { get; set; }
        public IStrategyApp Strategy { get; set; }
        public IObserverApp Observer { get; set; }
        //public IDecoratorApp Decorator { get; set; }



        public void Run()
        {
            //Decorator.Run();
            //Observer.Run();
            //Repository.Run();
            //Strategy.Run();
        }
    }
}
