using System.Threading.Tasks;
using Domain.TitleSystem.People;
using Domain.TitleSystem.PersonTitles;
using Microsoft.AspNetCore.Mvc;
using Pages.TitleSystem.People;

namespace WebApp.Areas.TitleSystem.Pages.People
{
    public class DeleteModel : PeoplePage
    {
        public DeleteModel(IPeopleRepository peopleRepository, IPersonTitlesRepository personTitlesRepository) : base(peopleRepository,personTitlesRepository)
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