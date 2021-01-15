using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Facade.Abstractions;

namespace Facade.TitleSystem.Titles
{
    public sealed class TitleView : DefinedEntityView
    {
        [DisplayName("Eesliide")]
        public string TitlePrefix { get; set; }

        public string GetId()
        {
            return Id;
        }


    }
}
