using System;
using System.Collections.Generic;
using BlazorProjectIII.Shared.Entity;

namespace BlazorProjectIII.Client.Services
{
    public class ServiceMovie : IServiceMovie
    {
        public List<Movie> GetMovies(){
            return new List<Movie>(){
                new Movie(){Title="Lorem Ipsum 1", Synopsis="Vivamus dapibus diam mauris, in ultrices urna porttitor a. Nunc a dignissim sapien. Vivamus at ipsum fringilla, aliquet erat sit amet, accumsan nibh. Pellentesque non vulputate magna. Suspendisse eget tempus mi. Aenean mollis vel tellus eget faucibus. In ut ex quis ipsum aliquam vulputate vitae venenatis mauris. Vestibulum justo augue, imperdiet ut mauris id, venenatis mollis lacus. Nulla tempor et enim sed vehicula. Nunc pulvinar nisl non nibh euismod, eu semper leo rhoncus.", ReleaseDate=new DateTime(2021,09,30), UriImage="/images/movie_placeholder_350x480.jpg", UriTriler="/", Runtime="2 hr 6 min", Genre="Drama", Cast="Mark Wystrach", Rating=4.8, IsNowPlaying=false},
                new Movie(){Title="Lorem Ipsum 2", Synopsis="Vivamus dapibus diam mauris, in ultrices urna porttitor a. Nunc a dignissim sapien. Vivamus at ipsum fringilla, aliquet erat sit amet, accumsan nibh. Pellentesque non vulputate magna. Suspendisse eget tempus mi. Aenean mollis vel tellus eget faucibus. In ut ex quis ipsum aliquam vulputate vitae venenatis mauris. Vestibulum justo augue, imperdiet ut mauris id, venenatis mollis lacus. Nulla tempor et enim sed vehicula. Nunc pulvinar nisl non nibh euismod, eu semper leo rhoncus.", ReleaseDate=new DateTime(2021,09,30), UriImage="/images/movie_placeholder_350x480.jpg", UriTriler="/", Runtime="2 hr 6 min", Genre="Drama", Cast="Mark Wystrach", Rating=4.8, IsNowPlaying=false},
                new Movie(){Title="Lorem Ipsum 3", Synopsis="Vivamus dapibus diam mauris, in ultrices urna porttitor a. Nunc a dignissim sapien. Vivamus at ipsum fringilla, aliquet erat sit amet, accumsan nibh. Pellentesque non vulputate magna. Suspendisse eget tempus mi. Aenean mollis vel tellus eget faucibus. In ut ex quis ipsum aliquam vulputate vitae venenatis mauris. Vestibulum justo augue, imperdiet ut mauris id, venenatis mollis lacus. Nulla tempor et enim sed vehicula. Nunc pulvinar nisl non nibh euismod, eu semper leo rhoncus.", ReleaseDate=new DateTime(2021,09,30), UriImage="/images/movie_placeholder_350x480.jpg", UriTriler="/", Runtime="2 hr 6 min", Genre="Drama", Cast="Mark Wystrach", Rating=4.8, IsNowPlaying=false},
                new Movie(){Title="Lorem Ipsum 4", Synopsis="Vivamus dapibus diam mauris, in ultrices urna porttitor a. Nunc a dignissim sapien. Vivamus at ipsum fringilla, aliquet erat sit amet, accumsan nibh. Pellentesque non vulputate magna. Suspendisse eget tempus mi. Aenean mollis vel tellus eget faucibus. In ut ex quis ipsum aliquam vulputate vitae venenatis mauris. Vestibulum justo augue, imperdiet ut mauris id, venenatis mollis lacus. Nulla tempor et enim sed vehicula. Nunc pulvinar nisl non nibh euismod, eu semper leo rhoncus.", ReleaseDate=new DateTime(2021,09,30), UriImage="/images/movie_placeholder_350x480.jpg", UriTriler="/", Runtime="2 hr 6 min", Genre="Drama", Cast="Mark Wystrach", Rating=4.8, IsNowPlaying=false},
                new Movie(){Title="Lorem Ipsum 5", Synopsis="Vivamus dapibus diam mauris, in ultrices urna porttitor a. Nunc a dignissim sapien. Vivamus at ipsum fringilla, aliquet erat sit amet, accumsan nibh. Pellentesque non vulputate magna. Suspendisse eget tempus mi. Aenean mollis vel tellus eget faucibus. In ut ex quis ipsum aliquam vulputate vitae venenatis mauris. Vestibulum justo augue, imperdiet ut mauris id, venenatis mollis lacus. Nulla tempor et enim sed vehicula. Nunc pulvinar nisl non nibh euismod, eu semper leo rhoncus.", ReleaseDate=new DateTime(2021,09,30), UriImage="/images/movie_placeholder_350x480.jpg", UriTriler="/", Runtime="2 hr 6 min", Genre="Drama", Cast="Mark Wystrach", Rating=4.8, IsNowPlaying=false},
                new Movie(){Title="Lorem Ipsum 6", Synopsis="Vivamus dapibus diam mauris, in ultrices urna porttitor a. Nunc a dignissim sapien. Vivamus at ipsum fringilla, aliquet erat sit amet, accumsan nibh. Pellentesque non vulputate magna. Suspendisse eget tempus mi. Aenean mollis vel tellus eget faucibus. In ut ex quis ipsum aliquam vulputate vitae venenatis mauris. Vestibulum justo augue, imperdiet ut mauris id, venenatis mollis lacus. Nulla tempor et enim sed vehicula. Nunc pulvinar nisl non nibh euismod, eu semper leo rhoncus.", ReleaseDate=new DateTime(2021,09,30), UriImage="/images/movie_placeholder_350x480.jpg", UriTriler="/", Runtime="2 hr 6 min", Genre="Drama", Cast="Mark Wystrach", Rating=4.8, IsNowPlaying=false},
                new Movie(){Title="Lorem Ipsum 7", Synopsis="Vivamus dapibus diam mauris, in ultrices urna porttitor a. Nunc a dignissim sapien. Vivamus at ipsum fringilla, aliquet erat sit amet, accumsan nibh. Pellentesque non vulputate magna. Suspendisse eget tempus mi. Aenean mollis vel tellus eget faucibus. In ut ex quis ipsum aliquam vulputate vitae venenatis mauris. Vestibulum justo augue, imperdiet ut mauris id, venenatis mollis lacus. Nulla tempor et enim sed vehicula. Nunc pulvinar nisl non nibh euismod, eu semper leo rhoncus.", ReleaseDate=new DateTime(2021,09,30), UriImage="/images/movie_placeholder_350x480.jpg", UriTriler="/", Runtime="2 hr 6 min", Genre="Drama", Cast="Mark Wystrach", Rating=4.8, IsNowPlaying=false},
                new Movie(){Title="Lorem Ipsum 8", Synopsis="Vivamus dapibus diam mauris, in ultrices urna porttitor a. Nunc a dignissim sapien. Vivamus at ipsum fringilla, aliquet erat sit amet, accumsan nibh. Pellentesque non vulputate magna. Suspendisse eget tempus mi. Aenean mollis vel tellus eget faucibus. In ut ex quis ipsum aliquam vulputate vitae venenatis mauris. Vestibulum justo augue, imperdiet ut mauris id, venenatis mollis lacus. Nulla tempor et enim sed vehicula. Nunc pulvinar nisl non nibh euismod, eu semper leo rhoncus.", ReleaseDate=new DateTime(2021,09,30), UriImage="/images/movie_placeholder_350x480.jpg", UriTriler="/", Runtime="2 hr 6 min", Genre="Drama", Cast="Mark Wystrach", Rating=4.8, IsNowPlaying=false},
                new Movie(){Title="Lorem Ipsum 9", Synopsis="Vivamus dapibus diam mauris, in ultrices urna porttitor a. Nunc a dignissim sapien. Vivamus at ipsum fringilla, aliquet erat sit amet, accumsan nibh. Pellentesque non vulputate magna. Suspendisse eget tempus mi. Aenean mollis vel tellus eget faucibus. In ut ex quis ipsum aliquam vulputate vitae venenatis mauris. Vestibulum justo augue, imperdiet ut mauris id, venenatis mollis lacus. Nulla tempor et enim sed vehicula. Nunc pulvinar nisl non nibh euismod, eu semper leo rhoncus.", ReleaseDate=new DateTime(2021,09,30), UriImage="/images/movie_placeholder_350x480.jpg", UriTriler="/", Runtime="2 hr 6 min", Genre="Drama", Cast="Mark Wystrach", Rating=4.8, IsNowPlaying=false},
                new Movie(){Title="Lorem Ipsum 10", Synopsis="Vivamus dapibus diam mauris, in ultrices urna porttitor a. Nunc a dignissim sapien. Vivamus at ipsum fringilla, aliquet erat sit amet, accumsan nibh. Pellentesque non vulputate magna. Suspendisse eget tempus mi. Aenean mollis vel tellus eget faucibus. In ut ex quis ipsum aliquam vulputate vitae venenatis mauris. Vestibulum justo augue, imperdiet ut mauris id, venenatis mollis lacus. Nulla tempor et enim sed vehicula. Nunc pulvinar nisl non nibh euismod, eu semper leo rhoncus.", ReleaseDate=new DateTime(2021,09,30), UriImage="/images/movie_placeholder_350x480.jpg", UriTriler="/", Runtime="2 hr 6 min", Genre="Drama", Cast="Mark Wystrach", Rating=4.8, IsNowPlaying=false},
                new Movie(){Title="Lorem Ipsum 11", Synopsis="Vivamus dapibus diam mauris, in ultrices urna porttitor a. Nunc a dignissim sapien. Vivamus at ipsum fringilla, aliquet erat sit amet, accumsan nibh. Pellentesque non vulputate magna. Suspendisse eget tempus mi. Aenean mollis vel tellus eget faucibus. In ut ex quis ipsum aliquam vulputate vitae venenatis mauris. Vestibulum justo augue, imperdiet ut mauris id, venenatis mollis lacus. Nulla tempor et enim sed vehicula. Nunc pulvinar nisl non nibh euismod, eu semper leo rhoncus.", ReleaseDate=new DateTime(2021,09,30), UriImage="/images/movie_placeholder_350x480.jpg", UriTriler="/", Runtime="2 hr 6 min", Genre="Drama", Cast="Mark Wystrach", Rating=4.8, IsNowPlaying=false}
            };            
        }
    }
}