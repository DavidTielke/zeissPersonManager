using System.Collections.Generic;
using Zeiss.PersonManager.CrossCutting.DataClasses;
using Zeiss.PersonManager.Data.FileSystem;

namespace Zeiss.PersonManager.Data.DataStoring
{
    public class PersonRepository
    {
        private readonly PersonParser _parser;
        private readonly FileLoader _fileLoader;

        public PersonRepository()
        {
            _parser = new PersonParser();
            _fileLoader = new FileLoader("data.csv");
        }

        public List<Person> GetAll()
        {
            var lines = _fileLoader.Load();
            
            var persons = _parser.Parse(lines);
            return persons;
        }
    }
}