using System.ComponentModel.DataAnnotations;
namespace BlazorProjectIII.Shared.Entity
{
    public class Category
    {
        public int Id { get; set;}
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string Name { get; set;}

    }
}