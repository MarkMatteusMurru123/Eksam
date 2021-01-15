using Data.TitleSystem.PersonTitles;
using Domain.Abstractions;

namespace Domain.TitleSystem.PersonTitles
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
