using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Data.Exam.People;
using Facade.Abstractions;

namespace Facade.Exam.People
{
    public sealed class PersonView : NamedEntityView
    {
        [Required]
        [DisplayName("Eesnimi")]
        public string FirstName { get; set; }
        [Required]
        [DisplayName("Perekonnanimi")]
        public string LastName { get; set; }
        [Required]
        [DisplayName("Sugu")]
        public PersonData.Gender Gender { get; set; }
        public string Email { get; set; }
        [Required]
        [DisplayName("Vanus")]
        public int Age { get; set; }
        [DisplayName("Lemmikaine")]
        public string FavouriteSubject { get; set; }
        [Required]
        [DisplayName("Alustas õppimist")]
        public DateTime EnrollmentDate { get; set; }
        public string GetId()
        {
            return Id;
        }

    }
}
