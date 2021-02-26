using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngularApi.Models
{
    public interface IUsersViewModel
    {
        void Add(UsersViewModel item);
        IEnumerable<UsersViewModel> GetAll();
    }
}
