using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Domain;

namespace BlazorFromServer.App.Services
{
    public interface IUserService
    {
        Task LoadPersons();
        List<User> AvailablePersons { get; }
        Task DeleteLastPerson();
        Task LoadSavedList();
    }
}
