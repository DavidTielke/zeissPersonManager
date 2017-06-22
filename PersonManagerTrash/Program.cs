using System;
using System.Collections.Generic;
using System.Linq;
using Zeiss.PersonManager.CrossCutting.DataClasses;

namespace Zeiss.PersonManager.UI.ConsoleClient
{
    class Program
    {
        static void Main()
        { 
            var manager = new Logic.PersonManagement.PersonManager();

            var statistic = manager.GetAgeStatistic();
            var adults = manager.GetAllAdults();
            var children = manager.GetAllChildren();

            Print("ERWACHSENE", statistic.AmountAdults, adults);

            Print("KINDER", statistic.AmountChildren, children);

            Console.ReadKey();
        }

        private static void Print(string title, int amount, IEnumerable<Person> persons)
        {
            Console.WriteLine($"### {title} ({amount}) ###");
            persons.ToList().ForEach(p => Console.WriteLine($"{p.Id} {p.Name} {p.Age}"));
        }
    }
}
