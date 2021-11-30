using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using Design_Patterns_Assignment.Decorator;

using Design_Patterns_Assignment.Observer;
using Design_Patterns_Assignment.Strategy;
using Design_Patterns_Assignment.Strategy.Messages;
using Design_Patterns_Assignment.Strategy.Sender;

namespace Design_Patterns_Assignment
{
    public static class AFConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            // Register Main Application
            builder.RegisterType<Application>().As<IApplication>();

            // Register Strategy classes
            builder.RegisterType<StrategyApp>().As<IStrategyApp>();

            builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
                .Where(i => i.Namespace.Contains("Strategy"))
                .As(i => i.GetInterfaces()
                .FirstOrDefault(n => n.Name == "I" + i.Name))
                   .AsImplementedInterfaces();

            ////Repository
            builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
                .Where(i => i.Namespace.Contains("Repository"))
                .As(i => i.GetInterfaces()
                .FirstOrDefault(n => n.Name == "I" + i.Name))
                   .AsImplementedInterfaces();

            ////Observer
            builder.RegisterType<ObserverApp>().As<IObserverApp>();
            builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
                .Where(i => i.Namespace.Contains("Observer"))
                .As(i => i.GetInterfaces()
                .FirstOrDefault(n => n.Name == "I" + i.Name))
                   .AsImplementedInterfaces();

            ////Decorator
            builder.RegisterType<DecoratorApp>().As<IDecoratorApp>();
            builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
                .Where(i => i.Namespace.Contains("Decorator"))
                .As(i => i.GetInterfaces()
                .FirstOrDefault(n => n.Name == "I" + i.Name))
                   .AsImplementedInterfaces();












            return builder.Build();
        }
    }
}
