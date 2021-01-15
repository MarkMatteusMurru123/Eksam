using System.Collections.Generic;
using Aids;
using Data.TitleSystem.Titles;
using Data.TitleSystem.PersonTitles;
using Domain.TitleSystem.Titles;
using Domain.TitleSystem.PersonTitles;
using Facade.TitleSystem.Titles;
using Facade.TitleSystem.PersonTitles;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Pages.TitleSystem.Titles
{
    public abstract class TitlesPage : CommonPage<ITitlesRepository, Title, TitleView, TitleData>
    {
        public IList<PersonTitleView> PersonTitles { get; }
        public IEnumerable<SelectListItem> People { get; }

        protected internal readonly IPersonTitlesRepository personTitles;

        protected internal TitlesPage(ITitlesRepository titlesRepository, IPersonTitlesRepository personTitlesRepository) :
            base(titlesRepository)
        {
            PageTitle = "Tiitlid";
            PersonTitles = new List<PersonTitleView>();
            personTitles = personTitlesRepository;
        }

        public override string ItemId => Item?.Id ?? string.Empty;


        protected internal override string GetPageUrl() => "/TitleSystem/Titles";

        protected internal override Title ToObject(TitleView view)
        {
            return TitleViewFactory.Create(view);
        }

        protected internal override TitleView ToView(Title obj)
        {
            return TitleViewFactory.Create(obj);
        }

        public string GetPersonTitleName(string personTitleId)
        {
            foreach (var m in PersonTitles)
            {
                if (m.Id == personTitleId)
                    return m.Name;
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
        public void LoadDetails(TitleView item)
        {
            PersonTitles.Clear();

            if (item is null) return;
            personTitles.FixedFilter = GetMember.Name<PersonTitleData>(x => x.TitleId);
            personTitles.FixedValue = item.Id;
            var list = personTitles.Get().GetAwaiter().GetResult();

            foreach (var e in list)
            {
                PersonTitles.Add(PersonTitleViewFactory.Create(e));
            }
        }
    }
}
