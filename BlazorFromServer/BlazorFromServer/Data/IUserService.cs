using System.Collections.Generic;
using Core.Domain;

namespace BlazorFromServer.Data
{
    public interface IUserService
    {
        void LoadPersons();
        List<User> AvailablePersons { get; }
        void DeleteLastPerson();
    }
}
