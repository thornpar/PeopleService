using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using PeopleService.Models;

namespace netcore.Models
{
    
    public class Person
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public ICollection<Dog> Dogs { get; set; }
        public string TestName { get; set; }
        public string AField { get; set; }
    }
}
