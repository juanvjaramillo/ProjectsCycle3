using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BlazorProjectIII.Shared.Entity;

namespace BlazorProjectIII.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoriesController : ControllerBase
    {
        private readonly ApplicationDbContext context;
         public CategoriesController(ApplicationDbContext context)
        {
            this.context = context;
        }

        /* Almacenar información de película */
        /* Método que nos permite crear un nuevo recurso Espesificamos que tipo de recurso: Post*/
        [HttpPost]
        public async Task<ActionResult<int>> Post(Category category) {
            context.Add(category);
            await context.SaveChangesAsync();
            return category.Id;
        }
    }
}