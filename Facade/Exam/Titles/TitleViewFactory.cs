using Aids;
using Data.Exam.Titles;
using Domain.Exam.Titles;

namespace Facade.Exam.Titles
{
    public static class TitleViewFactory
    {
        public static Title Create(TitleView v)
        {
            var d = new TitleData();
            Copy.Members(v, d);

            return new Title(d);
        }

        public static TitleView Create(Title o)
        {
            var v = new TitleView();
            if (!(o?.Data is null))
                Copy.Members(o.Data, v);

            return v;
        }
    }
}
