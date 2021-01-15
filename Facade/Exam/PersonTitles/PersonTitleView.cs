using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Facade.Abstractions;

namespace Facade.Exam.PersonTitles
{
    public sealed class PersonTitleView : NamedEntityView
    {
        [Required]
        [DisplayName("Tiitel")]
        public string TitleId { get; set; }
        [Required]
        [DisplayName("Inimene")]
        public string PersonId { get; set; }

    }
}
