using System;
using System.ComponentModel.DataAnnotations;
namespace BlazorProjectIII.Shared.Entity

{
    public class Actor
    {
        public int Id { get; set;}
        [Required]
        public string Name { get; set;}
        [Required]
        public DateTime? BirthDate { get; set;}
        public string Photo { get; set;}
        public int KnowCredits { get; set;}
        public string Biography { get; set;}
        public string Nominations { get; set;}
    }

}