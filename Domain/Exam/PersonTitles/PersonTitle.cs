using Data.Exam.PersonTitles;
using Domain.Abstractions;

namespace Domain.Exam.PersonTitles
{
    public sealed class PersonTitle : Entity<PersonTitleData>
    {
        public PersonTitle() : this(null)
        {

        }

        public PersonTitle(PersonTitleData data) : base(data)
        {

        }
    }
}
