using System.Collections.Generic;
using BlazorProjectIII.Shared.Entity;

namespace BlazorProjectIII.Client.Services
{
    public interface IServicePerson
    {
        List<Person> GetPerson();
    }
}