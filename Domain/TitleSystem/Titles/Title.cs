using Data.TitleSystem.Titles;
using Domain.Abstractions;

namespace Domain.TitleSystem.Titles
{
    public sealed class Title : Entity<TitleData>
    {
        public Title() : this(null) { }

        public Title(TitleData data) : base(data) { }
    }
}
