using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using netcore.Models;

namespace netcore.Repositories
{
    public class PeopleRepository : IPeopleRepository
    {
        public PeopleRepository(PeopleContext context)
        {
            Context = context;
        }
        private PeopleContext Context { get; }
        public void Add(Person person)
        {
            Context.Persons.Add(person);
            Context.SaveChanges();
        }

        public void Delete(Guid id)
        {
            Context.Persons.Remove(Context.Persons.FirstOrDefault(e => e.Id == id));
            Context.SaveChanges();
        }

        public void Update(Guid id, Person delta)
        {
            delta.Id = id;
            var entity = Context.Persons.FirstOrDefault(e => e.Id == id);
            entity.Name = delta.Name ?? entity.Name;
            Context.SaveChanges();
        }

        public IEnumerable<Person> People()
        {
            return Context.Persons
                .Include(e => e.Dogs)
                .AsEnumerable();
        }
    }
}
