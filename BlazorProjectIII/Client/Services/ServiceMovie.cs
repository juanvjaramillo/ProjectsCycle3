using System;
using System.Collections.Generic;
using BlazorProjectIII.Shared.Entity;

namespace BlazorProjectIII.Client.Services
{
    public class ServiceMovie : IServiceMovie
    {
        public List<Movie> GetMovies(){
            return new List<Movie>(){
                new Movie(){Id = 1, Name="Lorem Ipsum 1", Synopsis="Vivamus dapibus diam mauris, in ultrices urna porttitor a. Nunc a dignissim sapien. Vivamus at ipsum fringilla, aliquet erat sit amet, accumsan nibh.", Premier=new DateTime(2021,09,30), Poster="images/placeholders/movie_placeholder_350x480.jpg", Triler="/", Rating=4.8, IsNowPlaying=false},
                new Movie(){Id = 2, Name="Lorem Ipsum 2", Synopsis="Vivamus dapibus diam mauris, in ultrices urna porttitor a. Nunc a dignissim sapien. Vivamus at ipsum fringilla, aliquet erat sit amet, accumsan nibh.", Premier=new DateTime(2021,09,30), Poster="/images/placeholders/movie_placeholder_350x480.jpg", Triler="/", Rating=4.8, IsNowPlaying=false},
                new Movie(){Id = 3, Name="Lorem Ipsum 3", Synopsis="Vivamus dapibus diam mauris, in ultrices urna porttitor a. Nunc a dignissim sapien. Vivamus at ipsum fringilla, aliquet erat sit amet, accumsan nibh.", Premier=new DateTime(2021,09,30), Poster="images/placeholders/movie_placeholder_350x480.jpg", Triler="/", Rating=4.8, IsNowPlaying=false},
                new Movie(){Id = 4, Name="Lorem Ipsum 4", Synopsis="Vivamus dapibus diam mauris, in ultrices urna porttitor a. Nunc a dignissim sapien. Vivamus at ipsum fringilla, aliquet erat sit amet, accumsan nibh.", Premier=new DateTime(2021,09,30), Poster="images/placeholders/movie_placeholder_350x480.jpg", Triler="/", Rating=4.8, IsNowPlaying=false},
                new Movie(){Id = 5, Name="Lorem Ipsum 5", Synopsis="Vivamus dapibus diam mauris, in ultrices urna porttitor a. Nunc a dignissim sapien. Vivamus at ipsum fringilla, aliquet erat sit amet, accumsan nibh.", Premier=new DateTime(2021,09,30), Poster="images/placeholders/movie_placeholder_350x480.jpg", Triler="/", Rating=4.8, IsNowPlaying=false},
                new Movie(){Id = 6, Name="Lorem Ipsum 6", Synopsis="Vivamus dapibus diam mauris, in ultrices urna porttitor a. Nunc a dignissim sapien. Vivamus at ipsum fringilla, aliquet erat sit amet, accumsan nibh.", Premier=new DateTime(2021,09,30), Poster="images/placeholders/movie_placeholder_350x480.jpg", Triler="/", Rating=4.8, IsNowPlaying=false},
                new Movie(){Id = 7, Name="Lorem Ipsum 7", Synopsis="Vivamus dapibus diam mauris, in ultrices urna porttitor a. Nunc a dignissim sapien. Vivamus at ipsum fringilla, aliquet erat sit amet, accumsan nibh.", Premier=new DateTime(2021,09,30), Poster="images/placeholders/movie_placeholder_350x480.jpg", Triler="/", Rating=4.8, IsNowPlaying=false},
                new Movie(){Id = 8, Name="Lorem Ipsum 8", Synopsis="Vivamus dapibus diam mauris, in ultrices urna porttitor a. Nunc a dignissim sapien. Vivamus at ipsum fringilla, aliquet erat sit amet, accumsan nibh.", Premier=new DateTime(2021,09,30), Poster="images/placeholders/movie_placeholder_350x480.jpg", Triler="/", Rating=4.8, IsNowPlaying=false},
                new Movie(){Id = 9, Name="Lorem Ipsum 9", Synopsis="Vivamus dapibus diam mauris, in ultrices urna porttitor a. Nunc a dignissim sapien. Vivamus at ipsum fringilla, aliquet erat sit amet, accumsan nibh.", Premier=new DateTime(2021,09,30), Poster="images/placeholders/movie_placeholder_350x480.jpg", Triler="/", Rating=4.8, IsNowPlaying=false},
                new Movie(){Id = 10, Name="Lorem Ipsum 10", Synopsis="Vivamus dapibus diam mauris, in ultrices urna porttitor a. Nunc a dignissim sapien. Vivamus at ipsum fringilla, aliquet erat sit amet, accumsan nibh.", Premier=new DateTime(2021,09,30), Poster="images/placeholders/movie_placeholder_350x480.jpg", Triler="/", Rating=4.8, IsNowPlaying=false},
                new Movie(){Id = 11, Name="Lorem Ipsum 11", Synopsis="Vivamus dapibus diam mauris, in ultrices urna porttitor a. Nunc a dignissim sapien. Vivamus at ipsum fringilla, aliquet erat sit amet, accumsan nibh.", Premier=new DateTime(2021,09,30), Poster="images/placeholders/movie_placeholder_350x480.jpg", Triler="/", Rating=4.8, IsNowPlaying=false}
            };            
        }
    }
}