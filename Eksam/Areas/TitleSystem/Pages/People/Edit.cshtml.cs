using System.Threading.Tasks;
using Domain.TitleSystem.People;
using Domain.TitleSystem.PersonTitles;
using Microsoft.AspNetCore.Mvc;
using Pages.TitleSystem.People;

namespace WebApp.Areas.TitleSystem.Pages.People
{
    public class EditModel : PeoplePage
    {
        public EditModel(IPeopleRepository peoplesRepository, IPersonTitlesRepository personTitlesRepository) : base(peoplesRepository, personTitlesRepository)
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