// See https://aka.ms/new-console-template for more information

using Business.Concrete;
using Entities.Concrete;

namespace Workaround
{
    class Program
    {
        static void Main(string[] args)
        {
            Person personOne = new Person();

            personOne.NationalIdentity = 12345678910;
            personOne.FirstName = "Test";
            personOne.LastName = "Test";
            personOne.YearOfBirthday = 1234;


            CargoManager cargoManager = new CargoManager(new NativerManager());
            cargoManager.GiveMaterial(personOne);


        }
    }
}

