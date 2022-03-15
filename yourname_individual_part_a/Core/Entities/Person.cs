using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yourname_individual_part_a.Core.Entities
{
    class Person
    {
        public Person(int id, string name, string lastName)
        {
            Id = id;
            Name = name;
            LastName = lastName;
        }

        public string Name { get; set; }
        public string LastName { get; set; }
        public int Id { get; set; }
    }
}
