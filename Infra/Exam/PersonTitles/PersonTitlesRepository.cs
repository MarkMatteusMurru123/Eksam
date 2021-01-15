using Data.TitleSystem.PersonTitles;
using Domain.TitleSystem.PersonTitles;

namespace Infra.Exam.PersonTitles
{
    public sealed class PersonTitlesRepository : UniqueEntityRepository<PersonTitle, PersonTitleData>, IPersonTitlesRepository
    {
        public PersonTitlesRepository(ProjectDbContext c) : base(c, c.PersonTitles) { }

        protected internal override PersonTitle ToDomainObject(PersonTitleData d) => new PersonTitle(d);
    }
}
