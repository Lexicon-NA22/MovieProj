using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MovieProj.Data;

namespace MovieProj.Services
{
    public class GenreSelectListService : IGenreSelectListService
    {
        private readonly MovieProjContext db;

        public GenreSelectListService(MovieProjContext db)
        {
            this.db = db;
        }

        public async Task<IEnumerable<SelectListItem>> GetGenresAsync()
        {
            return await db.Movie
                           .Select(m => m.Genre)
                           .Distinct()
                           .Select(g => new SelectListItem
                           {
                               Text = g.ToString(),
                               Value = g.ToString()
                           })
                           .ToListAsync();
        }
    }
}
