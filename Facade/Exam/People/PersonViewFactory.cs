using Aids;
using Data.Exam.People;
using Domain.Exam.People;

namespace Facade.Exam.People
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
