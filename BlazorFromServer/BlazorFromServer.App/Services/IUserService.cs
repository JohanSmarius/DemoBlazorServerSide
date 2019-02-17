using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Domain;

namespace BlazorFromServer.App.Services
{
    public interface IUserService
    {
        void LoadPersons();
        List<User> AvailablePersons { get; }
        void DeleteLastPerson();
    }
}
