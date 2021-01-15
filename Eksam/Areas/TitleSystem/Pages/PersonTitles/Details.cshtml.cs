using System.Threading.Tasks;
using Domain.TitleSystem.People;
using Domain.TitleSystem.PersonTitles;
using Domain.TitleSystem.Titles;
using Microsoft.AspNetCore.Mvc;
using Pages.TitleSystem.PersonTitles;

namespace WebApp.Areas.TitleSystem.Pages.PersonTitles
{
    public class DetailsModel : PersonTitlesPage
    {

        public DetailsModel(IPersonTitlesRepository personTitlesRepository, IPeopleRepository personRepository, 
            ITitlesRepository titlesRepository) : base(personTitlesRepository, personRepository, titlesRepository)
        {
        }

        public async Task<IActionResult> OnGetAsync(string id, string fixedFilter, string fixedValue)
        {
            await GetObject(id, fixedFilter, fixedValue);
            return Page();
        }
    }
}
