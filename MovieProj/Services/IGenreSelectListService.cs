using Microsoft.AspNetCore.Mvc.Rendering;

namespace MovieProj.Services
{
    public interface IGenreSelectListService
    {
        Task<IEnumerable<SelectListItem>> GetGenresAsync();
    }
}