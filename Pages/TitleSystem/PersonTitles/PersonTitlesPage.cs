using System.Collections.Generic;
using Data.TitleSystem.People;
using Data.TitleSystem.PersonTitles;
using Data.TitleSystem.Titles;
using Domain.TitleSystem.People;
using Domain.TitleSystem.PersonTitles;
using Domain.TitleSystem.Titles;
using Facade.TitleSystem.PersonTitles;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Pages.TitleSystem.PersonTitles
{
    public abstract class PersonTitlesPage : CommonPage<IPersonTitlesRepository, PersonTitle, PersonTitleView, PersonTitleData>
    {
        public IEnumerable<SelectListItem> People { get; }
        public IEnumerable<SelectListItem> Titles { get; }

        protected internal PersonTitlesPage(IPersonTitlesRepository personTitlesRepository, 
            IPeopleRepository peopleRepository, ITitlesRepository titlesRepository) : base(personTitlesRepository)
        {
            PageTitle = "Inimeste tiitlid";
            People = CreateSelectList<Person, PersonData>(peopleRepository);
            Titles = CreateSelectList<Title, TitleData>(titlesRepository);

        }

        public override string ItemId => Item is null ? string.Empty : $"{Item.TitleId}.{Item.PersonId}";
       
        protected internal override string GetPageUrl() => "/TitleSystem/PersonTitles";

        protected internal override PersonTitle ToObject(PersonTitleView view)
        {
            return PersonTitleViewFactory.Create(view);
        }

        protected internal override PersonTitleView ToView(PersonTitle obj)
        {
            return PersonTitleViewFactory.Create(obj);
        }

        public string GetTitleName(string TitleId)
        {
            foreach (var m in Titles)
            {
                if (m.Value ==TitleId)
                    return m.Text;
            }

            return "Määramata";
        }

        public string GetPersonName(string personId)
        {
            foreach (var m in People)
            {
                if (m.Value == personId)
                    return m.Text;
            }

            return "Määramata";
        }

        protected internal override string GetPageSubTitle()
        {
            if (!GetTitleName(FixedValue).Equals("Määramata"))
            {
                return FixedValue is null ? base.GetPageSubTitle() : $"{GetTitleName(FixedValue)}";
            } 
            if (!GetPersonName(FixedValue).Equals("Määramata"))
            {
                return FixedValue is null ? base.GetPageSubTitle() : $"{GetPersonName(FixedValue)}";
            }

            return base.GetPageSubTitle();
        }
    }
}
