using System.Threading.Tasks;
using Domain.TitleSystem.PersonTitles;
using Domain.TitleSystem.Titles;
using Microsoft.AspNetCore.Mvc;
using Pages.TitleSystem.Titles;

namespace WebApp.Areas.TitleSystem.Pages.Titles
{
    public class EditModel : TitlesPage
    {
        public EditModel(ITitlesRepository titlesRepository, IPersonTitlesRepository personTitlesRepository) : base(titlesRepository, personTitlesRepository)
        {
        }

        public async Task<IActionResult> OnGetAsync(string id, string fixedFilter, string fixedValue)
        {
            await GetObject(id, fixedFilter, fixedValue);
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string fixedFilter, string fixedValue)
        {
            await UpdateObject(fixedFilter, fixedValue);
            return Redirect(IndexUrl);
        }
    }
}