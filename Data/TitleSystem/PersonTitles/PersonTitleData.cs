using Data.Abstractions;

namespace Data.TitleSystem.PersonTitles
{
    public sealed class PersonTitleData : NamedEntityData
    {
        public string TitleId { get; set; }
        public string PersonId { get; set; }

    }
}
