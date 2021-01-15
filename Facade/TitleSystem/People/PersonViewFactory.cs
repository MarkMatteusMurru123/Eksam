using Aids;
using Data.TitleSystem.People;
using Domain.TitleSystem.People;

namespace Facade.TitleSystem.People
{
    public static class PersonViewFactory
    {
        public static Person Create(PersonView v)
        {
            var d = new PersonData();
            Copy.Members(v, d);

            return new Person(d);
        }

        public static PersonView Create(Person o)
        {
            var v = new PersonView();
            if (!(o?.Data is null))
                Copy.Members(o.Data, v);

            return v;
        }
    }
}
