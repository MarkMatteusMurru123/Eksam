using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Data.TitleSystem.People;
using Facade.Abstractions;

namespace Facade.TitleSystem.People
{
    public sealed class PersonView : NamedEntityView
    {
        [Required]
        [DisplayName("Sugu")]
        public Gender Gender { get; set; }
        public string Email { get; set; }
        [Required]
        [DisplayName("Vanus")]
        public int Age { get; set; }
        public string GetId()
        {
            return Id;
        }

    }
}
