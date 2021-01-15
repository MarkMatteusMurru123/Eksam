using System.ComponentModel;

namespace Facade.Abstractions
{
    public abstract class DefinedEntityView : NamedEntityView
    {
        [DisplayName("Kirjeldus")]
        public string Description { get; set; }
    }
}
