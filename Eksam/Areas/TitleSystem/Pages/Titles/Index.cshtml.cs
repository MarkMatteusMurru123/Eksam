using System.Threading.Tasks;
using Domain.TitleSystem.PersonTitles;
using Domain.TitleSystem.Titles;
using Pages.TitleSystem.Titles;

namespace WebApp.Areas.TitleSystem.Pages.Titles
{
    public class IndexModel : TitlesPage
    {
        public IndexModel(ITitlesRepository titlesRepository, IPersonTitlesRepository personTitlesRepository) : base(titlesRepository, personTitlesRepository)
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