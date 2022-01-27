using MovieProj.Models.Entities;

namespace MovieProj.Models.ViewModels
{
    public class IndexViewModel2
    {
        public IEnumerable<Movie> Movies { get; set; } = new List<Movie>();
        public string? Title { get; set; }
        public Genre? Genre { get; set; }
    }
}
