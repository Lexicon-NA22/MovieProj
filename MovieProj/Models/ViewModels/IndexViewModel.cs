using Microsoft.AspNetCore.Mvc.Rendering;
using MovieProj.Models.Entities;

namespace MovieProj.Models.ViewModels

{
    public class IndexViewModel
    {
        public IEnumerable<Movie> Movies { get; set; } = new List<Movie>();
        public IEnumerable<SelectListItem> Genres { get; set; } = new List<SelectListItem>();
        public string? Title { get; set; }
        public Genre? Genre { get; set; }
    }
}
