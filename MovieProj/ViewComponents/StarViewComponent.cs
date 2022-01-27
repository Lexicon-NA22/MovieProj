using Microsoft.AspNetCore.Mvc;
using MovieProj.Data;
using MovieProj.Models.ViewModels;

namespace MovieProj.ViewComponents
{
   // [ViewComponent(Name ="")]
    public class StarViewComponent : ViewComponent
    {
        private readonly MovieProjContext db;
        public StarViewComponent(MovieProjContext db)
        {
            this.db = db;
        }

        public async Task<IViewComponentResult> InvokeAsync(int movieId) //Kan lika gärna skicka in rating direkt
        {
            var movie = await db.Movie.FindAsync(movieId); //Check for null!
            var doubleRating = (int)Math.Round(movie.Rating * 2);

            var model = new StarViewModel
            {
                Stars = doubleRating / 2,
                IsHalfStar = doubleRating % 2 == 1
            };

            return View(model);
        }

    }
}
