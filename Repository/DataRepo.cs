using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Repository
{
    public class DataRepo : IDataRepo
    {
        public string GetAllData()
        {
            return "All Data";
        }

        public string GetAnimalByName()
        {
            return "Hunden Fido";
        }

        public string GetCustomerByName()
        {
            return "Ägaren till Fido, Gustaf Svensson";
        }

        public void SaveAnimal(string animal)
        {
            Console.WriteLine($"Sparar {animal} till databasen.");
        }

        public void SaveCustomer(string customer)
        {
            Console.WriteLine($"Sparar {customer} till databasen.");
        }

        public void SaveData(string data)
        {
            Console.WriteLine($"Sparar all data: {data} till databasen.");
        }
    }
}
