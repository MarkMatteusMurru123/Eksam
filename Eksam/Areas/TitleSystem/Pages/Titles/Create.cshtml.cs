using System.Threading.Tasks;
using Domain.TitleSystem.PersonTitles;
using Domain.TitleSystem.Titles;
using Microsoft.AspNetCore.Mvc;
using Pages.TitleSystem.Titles;

namespace WebApp.Areas.TitleSystem.Pages.Titles
{
    public class CreateModel : TitlesPage
    {
        public CreateModel(ITitlesRepository titlesRepository, IPersonTitlesRepository personTitlesRepository) : base(titlesRepository, personTitlesRepository)
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
