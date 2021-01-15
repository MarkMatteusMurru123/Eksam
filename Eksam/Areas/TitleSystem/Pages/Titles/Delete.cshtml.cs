using System.Threading.Tasks;
using Domain.TitleSystem.PersonTitles;
using Domain.TitleSystem.Titles;
using Microsoft.AspNetCore.Mvc;
using Pages.TitleSystem.Titles;

namespace WebApp.Areas.TitleSystem.Pages.Titles
{
    public class DeleteModel : TitlesPage
    {
        public DeleteModel(ITitlesRepository titlesRepository, IPersonTitlesRepository personTitlesRepository
            ) : base(titlesRepository, personTitlesRepository )
        {
        }

        public async Task<IActionResult> OnGetAsync(string id, string fixedFilter, string fixedValue)
        {
            await GetObject(id, fixedFilter, fixedValue);

            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string id, string fixedFilter, string fixedValue)
        {
            await DeleteObject(id, fixedFilter, fixedValue);

            return Redirect(IndexUrl);
        }
    }
}