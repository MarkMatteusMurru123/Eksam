using Data.Exam.Titles;
using Domain.Abstractions;

namespace Domain.Exam.Titles
{
    public sealed class Title : Entity<TitleData>
    {
        public Title() : this(null) { }

        public Title(TitleData data) : base(data) { }
    }
}
