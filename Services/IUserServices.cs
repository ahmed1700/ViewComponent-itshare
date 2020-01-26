using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ViewComponentSys.Domain;

namespace ViewComponentSys.Services
{
    public interface IUserServices
    {

        Task<List<User>> GetUsersAsync(); // Asynchronuius

        Task<User> GetUserAsync(int id);
        //Blocking : ASynchronuis p1->p2->p3
    }
}
