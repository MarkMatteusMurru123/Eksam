using Data.Abstractions;

namespace Data.TitleSystem.People
{
    public sealed class PersonData : NamedEntityData
    {

        public Gender Gender { get; set; }

        public int Age { get; set; }
        public string Email { get; set; }
        
    }
}
