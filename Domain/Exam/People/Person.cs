using System;
using System.Collections.Generic;
using System.Text;
using Data.Exam.People;
using Domain.Abstractions;

namespace Domain.Exam.People
{
    public sealed class Person : Entity<PersonData>
    {
        public Person() : this(null) { }

        public Person(PersonData data) : base(data) { }
    }
}
