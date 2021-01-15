using Data.Exam.People;
using Domain.Exam.People;

namespace Infra.Exam.People
{
    public sealed class PeopleRepository : UniqueEntityRepository<Person, PersonData>, IPeopleRepository
    {
        public PeopleRepository(ProjectDbContext c) : base(c, c.People) { }

        protected internal override Person ToDomainObject(PersonData d) => new Person(d);
    }
}
