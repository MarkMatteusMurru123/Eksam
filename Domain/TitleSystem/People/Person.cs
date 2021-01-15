using Data.TitleSystem.People;
using Domain.Abstractions;

namespace Domain.TitleSystem.People
{
    public sealed class Person : Entity<PersonData>
    {
        public Person() : this(null) { }

        public Person(PersonData data) : base(data) { }
    }
}
