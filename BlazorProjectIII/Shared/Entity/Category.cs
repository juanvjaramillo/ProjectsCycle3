using System.ComponentModel.DataAnnotations;
namespace BlazorProjectIII.Shared.Entity
{
    public class Category
    {
        public int CategoryId { get; set;}
        [Required(ErrorMessage="El campo {0} es requerido")]
        public string CategoryName { get; set;}

    }
}