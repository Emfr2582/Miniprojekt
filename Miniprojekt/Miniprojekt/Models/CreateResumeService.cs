using Miniprojekt.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Miniprojekt.Models
{
    public class CreateResumeService
    {
        List<CreateResumeVM> people = new List<CreateResumeVM>();

        public void AddPerson(CreateResumeVM person)
        {
            person.Id = people.Count == 0 ? 1 : people.Max(p => p.Id) + 1;

            people.Add(person);
        }
    }
}
