using System.Threading.Tasks;
using Domain.TitleSystem.People;
using Domain.TitleSystem.PersonTitles;
using Pages.TitleSystem.People;

namespace WebApp.Areas.TitleSystem.Pages.People
{
    public class IndexModel : PeoplePage
    {
        public IndexModel(IPeopleRepository peopleRepository, IPersonTitlesRepository personTitlesRepository) : base(peopleRepository, personTitlesRepository)
        {
        }

        public async Task OnGetAsync(string sortOrder, string id, string currentFilter, string searchString,
            int? pageIndex, string fixedFilter, string fixedValue)
        {
            SelectedId = id;
            await GetList(sortOrder, currentFilter, searchString, pageIndex, fixedFilter, fixedValue);
        }
    }
}