using System.Threading.Tasks;
using Domain.TitleSystem.People;
using Domain.TitleSystem.PersonTitles;
using Microsoft.AspNetCore.Mvc;
using Pages.TitleSystem.People;

namespace WebApp.Areas.TitleSystem.Pages.People
{
    public class DetailsModel : PeoplePage
    {
        public DetailsModel(IPeopleRepository peopleRepository, IPersonTitlesRepository personTitlesRepository) : base(peopleRepository, personTitlesRepository)
        {
        }

        public async Task<IActionResult> OnGetAsync(string id, string fixedFilter, string fixedValue)
        {
            await GetObject(id, fixedFilter, fixedValue);

            return Page();
        }
    }
}