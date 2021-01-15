using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Facade.Abstractions;

namespace Facade.TitleSystem.PersonTitles
{
    public sealed class PersonTitleView : NamedEntityView
    {
        [Required]
        [DisplayName("Tiitel")]
        public string TitleId { get; set; }
        [Required]
        [DisplayName("Inimene")]
        public string PersonId { get; set; }
        public string GetId()
        {
            return Id;
        }

    }
}
