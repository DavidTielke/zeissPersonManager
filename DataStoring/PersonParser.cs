using System;
using System.Collections.Generic;
using System.Linq;
using Zeiss.PersonManager.CrossCutting.DataClasses;

namespace Zeiss.PersonManager.Data.DataStoring
{
    public class PersonParser
    {
        public List<Person> Parse(string[] lines)
        {
            return lines.Select(l => l.Split(new[] { "," }, StringSplitOptions.None))
                .Select(l => new Person
                {
                    Id = int.Parse(l[0]),
                    Name = l[1],
                    Age = int.Parse(l[2])
                }).ToList();
        }
    }
}