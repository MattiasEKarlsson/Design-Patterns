using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Repository
{
    public interface IDataRepo
    {
        string GetAllData();
        string GetCustomerByName();
        string GetAnimalByName();

        void SaveData(string data);
        void SaveCustomer(string customer);
        void SaveAnimal(string animal);
    }
}
