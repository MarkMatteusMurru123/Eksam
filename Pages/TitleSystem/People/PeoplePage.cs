using System;
using System.Collections.Generic;
using System.Linq;
using Aids;
using Data.TitleSystem.People;
using Data.TitleSystem.PersonTitles;
using Domain.TitleSystem.People;
using Domain.TitleSystem.PersonTitles;
using Facade.TitleSystem.People;
using Facade.TitleSystem.PersonTitles;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Pages.TitleSystem.People
{
    public abstract class PeoplePage : CommonPage<IPeopleRepository, Person, PersonView, PersonData>
    {


        public IEnumerable<SelectListItem> PersonTitles { get; }
        public IEnumerable<SelectListItem> Genders { get; }
        public IList<PersonTitleView> titles { get; }


        protected internal readonly IPersonTitlesRepository personTitles;

        protected internal PeoplePage(IPeopleRepository peopleRepository, IPersonTitlesRepository personTitlesRepository) : base(peopleRepository)
        {
            PageTitle = "Inimesed";
            PersonTitles = CreateSelectList<PersonTitle, PersonTitleData>(personTitlesRepository);
            Genders = CreateGendersSelectList<Gender>();
            titles = new List<PersonTitleView>();

            personTitles = personTitlesRepository;
        }

        private static IEnumerable<SelectListItem> CreateGendersSelectList<TrainingLevel>()
        {
            var items = new SelectList(Enum.GetValues(typeof(TrainingLevel)).Cast<TrainingLevel>().Select(v => new SelectListItem
            {
                Text = v.ToString(),
                Value = Convert.ToInt32(v).ToString()
            }).ToList(), "Value", "Text");

            return items;
        }

        public string GetPersonTitleName(string PersonTitleId)
        {
            foreach (var m in PersonTitles)
            {
                if (m.Value == PersonTitleId)
                    return m.Text;
            }

            return "Määramata";
        }
        public string GetTitleName(string personId)
        {
            foreach (var m in titles)
            {
                if (m.TitleId == personId)
                    return m.Name;
            }

            return "Määramata";
        }
        public override string ItemId => Item.Id;

        protected internal override string GetPageUrl() => "/TitleSystem/People";

        protected internal override Person ToObject(PersonView view)
        {
            return PersonViewFactory.Create(view);
        }

        protected internal override PersonView ToView(Person obj)
        {
            return PersonViewFactory.Create(obj);
        }
        public void LoadDetails(PersonView item)
        {
            titles.Clear();

            if (item is null) return;
            personTitles.FixedFilter = GetMember.Name<PersonTitleData>(x => x.PersonId);
            personTitles.FixedValue = item.Id;
            var list = personTitles.Get().GetAwaiter().GetResult();

            foreach (var e in list)
            {
                titles.Add(PersonTitleViewFactory.Create(e));
            }
        }

    }
}
