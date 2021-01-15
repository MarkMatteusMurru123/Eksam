using System.Threading.Tasks;
using Domain.TitleSystem.People;
using Domain.TitleSystem.PersonTitles;
using Domain.TitleSystem.Titles;
using Microsoft.AspNetCore.Mvc;
using Pages.TitleSystem.PersonTitles;

namespace WebApp.Areas.TitleSystem.Pages.PersonTitles
{
    public class CreateModel : PersonTitlesPage
    {

        public CreateModel(IPersonTitlesRepository personTitlesRepository, IPeopleRepository peopleRepository, 
            ITitlesRepository titlesRepository) : base(personTitlesRepository, peopleRepository, titlesRepository)
        {

        }

        public IActionResult OnGet(string fixedFilter, string fixedValue)
        {
            FixedFilter = fixedFilter;
            FixedValue = fixedValue;
            return Page();

        }

        public async Task<IActionResult> OnPostAsync(string fixedFilter, string fixedValue)
        {
            if (!await AddObject(fixedFilter, fixedValue)) return Page();
            return Redirect(IndexUrl);
        }
    }
}
