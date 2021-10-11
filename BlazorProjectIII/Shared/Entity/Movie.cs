using System;
namespace BlazorProjectIII.Shared.Entity
{
    public class Movie
    {
        public int MovieId { get; set;}
        public string Title { get; set;}
        public string Synopsis { get; set;}
        public DateTime ReleaseDate { get; set;}
        public string UriImage { get; set;}
        public string UriTriler { get; set;}
        public string Runtime { get; set;}
        public string Genre { get; set;}
        public string Cast { get; set;}
        public double Rating { get; set;}
        public bool IsNowPlaying { get; set;}
    };
}

