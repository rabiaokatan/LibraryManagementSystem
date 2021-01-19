using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementApp.Models
{
    public enum BookGenre
    {
        Poetry,
        Classic,
        History,
        Essay,
        Cookbook,
        Biography,
        Authobiography,
        [Display(Name = "Short Story")]
        ShortStory,
        [Display(Name = "Science Fiction")]
        ScienceFiction,
        [Display(Name = "Historical Fiction")]
        HistoricalFiction,
        [Display(Name = "Philosophical Fiction")]
        PhilosophicalFiction,
        Romance,
        Horror,
        Fantasy,
        Mystery,
        Adventure,
        [Display(Name = "Comic Book")]
        ComicBook

    }
}
