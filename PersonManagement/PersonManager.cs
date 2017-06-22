using System.Collections.Generic;
using System.Linq;
using Zeiss.PersonManager.CrossCutting.DataClasses;
using Zeiss.PersonManager.Data.DataStoring;

namespace Zeiss.PersonManager.Logic.PersonManagement
{
    public class PersonManager
    {
        private readonly PersonRepository _repository;

        public PersonManager()
        {
            _repository = new PersonRepository();
        }

        public AgeStatistic GetAgeStatistic()
        {
            var statistic = new AgeStatistic
            {
                AmountAdults = GetAllAdults().Count(),
                AmountChildren = GetAllChildren().Count()
            };
            return statistic;
        }

        public IEnumerable<Person> GetAllChildren()
        {
            return _repository.GetAll().Where(p => p.Age < 18);
        }

        public IEnumerable<Person> GetAllAdults()
        {
            return _repository.GetAll().Where(p => p.Age >= 18);
        }
    }
}