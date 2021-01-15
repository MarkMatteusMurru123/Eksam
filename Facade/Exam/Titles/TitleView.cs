using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Facade.Abstractions;

namespace Facade.Exam.Titles
{
    public sealed class TitleView : DefinedEntityView
    {
        [Required]
        [DisplayName("Eesliide")]
        public string TitlePrefix { get; set; }

        public string GetId()
        {
            return Id;
        }


    }
}
