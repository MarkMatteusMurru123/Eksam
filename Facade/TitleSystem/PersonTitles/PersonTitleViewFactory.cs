using Aids;
using Data.TitleSystem.PersonTitles;
using Domain.TitleSystem.PersonTitles;

namespace Facade.TitleSystem.PersonTitles
{
    public static class PersonTitleViewFactory
    {
        public static PersonTitle Create(PersonTitleView v)
        {
            var d = new PersonTitleData();
            Copy.Members(v, d);

            return new PersonTitle(d);
        }

        public static PersonTitleView Create(PersonTitle o)
        {
            var v = new PersonTitleView();
            if (!(o?.Data is null))
                Copy.Members(o.Data, v);

            return v;
        }
    }
}
