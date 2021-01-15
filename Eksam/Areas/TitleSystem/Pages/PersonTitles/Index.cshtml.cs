using System.Threading.Tasks;
using Domain.TitleSystem.People;
using Domain.TitleSystem.PersonTitles;
using Domain.TitleSystem.Titles;
using Pages.TitleSystem.PersonTitles;

namespace WebApp.Areas.TitleSystem.Pages.PersonTitles
{
    public class IndexModel : PersonTitlesPage
    {
        public IndexModel(IPersonTitlesRepository participantsRepository, IPeopleRepository peopleRepository, 
            ITitlesRepository titlesRepository) : base(participantsRepository, peopleRepository, titlesRepository)
        {
        }

        public async Task OnGetAsync(string sortOrder, string currentFilter, string searchString, 
            int? pageIndex, string fixedFilter, string fixedValue)
        {
            await GetList(sortOrder,
                currentFilter, searchString, pageIndex, fixedFilter, fixedValue);
        }
    }
}
