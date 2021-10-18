using System.Collections.Generic;
using BlazorProjectIII.Shared.Entity;
using System.Threading.Tasks;

namespace BlazorProjectIII.Client.Services
{
    public interface IServiceMovie
    {
        List <Movie> GetMovies();
        Task<HttpResponseWrapper<object>> Post<T>(string url, T send);
    }
}