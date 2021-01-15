using Data.Abstractions;

namespace Data.Exam.People
{
    public sealed class PersonData : NamedEntityData
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public enum Gender
        {
            Mees = 0,
            Naine = 1,
            Muu = 2,
        }
        public int Age { get; set; }
        public string Email { get; set; }
        
    }
}
