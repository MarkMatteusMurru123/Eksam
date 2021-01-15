using System.Threading.Tasks;
using Domain.TitleSystem.People;
using Domain.TitleSystem.PersonTitles;
using Microsoft.AspNetCore.Mvc;
using Pages.TitleSystem.People;

namespace WebApp.Areas.TitleSystem.Pages.People
{
    public class CreateModel : PeoplePage
    {
        public CreateModel(IPeopleRepository personRepository, IPersonTitlesRepository personTitlesRepository) : base(personRepository, personTitlesRepository)
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