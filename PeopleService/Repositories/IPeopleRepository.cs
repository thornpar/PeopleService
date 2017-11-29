using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using netcore.Models;

namespace netcore.Repositories
{
    public interface IPeopleRepository
    {
        void Add(Person person);
        void Delete(Guid id);
        void Update(Guid id, Person delta);
        IEnumerable<Person> People();

    }
}
