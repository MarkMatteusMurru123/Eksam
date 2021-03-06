﻿using System.Threading.Tasks;
using Domain.TitleSystem.People;
using Domain.TitleSystem.PersonTitles;
using Domain.TitleSystem.Titles;
using Microsoft.AspNetCore.Mvc;
using Pages.TitleSystem.PersonTitles;

namespace WebApp.Areas.TitleSystem.Pages.PersonTitles
{
    public class EditModel : PersonTitlesPage
    {
        public EditModel(IPersonTitlesRepository personTitlesRepository, IPeopleRepository peopleRepository, 
            ITitlesRepository titlesRepository) : base(personTitlesRepository, peopleRepository, titlesRepository)
        {
        }

        public async Task<IActionResult> OnGetAsync(string id, string fixedFilter, string fixedValue)
        {
            FixedFilter = fixedFilter;
            FixedValue = fixedValue;
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
