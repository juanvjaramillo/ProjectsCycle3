using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System;

namespace BlazorProjectIII.Shared.Entity
{
    public class Movie
    {
        public int Id { get; set;}
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string Name { get; set;}
        public bool IsNowPlaying { get; set;}
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string Synopsis { get; set;}
        public string Poster { get; set;}
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public DateTime Premier { get; set;}
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string Triler { get; set;}
        public double Rating { get; set;}

        [Required(ErrorMessage = "El campo {0} es requerido")]
        public List <CategoryMovie> CategoriesMovie { get; set;} = new List <CategoryMovie> ();
        public List <MovieActor> MoviesActor { get; set; } = new List <MovieActor> ();
        public string ShortName {
            get{
                if (string.IsNullOrWhiteSpace(Name)){
                    return null;
                }
                if (Name.Length > 60) {
                    return Name.Substring(0, 60) + "...";
                } else {
                    return Name;
                }
            }
        }
    }
}

