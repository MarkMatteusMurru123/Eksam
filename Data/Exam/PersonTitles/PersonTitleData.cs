using Data.Abstractions;

namespace Data.Exam.PersonTitles
{
    public sealed class PersonTitleData : NamedEntityData
    {
        public string TitleId { get; set; }
        public string PersonId { get; set; }

    }
}
