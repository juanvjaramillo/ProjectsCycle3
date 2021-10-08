using System.Collections.Generic;
using BlazorProjectIII.Shared.Entity;

namespace BlazorProjectIII.Client.Services
{
    public interface IServiceMovie
    {
        List<Movie> GetMovies();
        /* List<Cast> GetCasting(); */
         
    }
}