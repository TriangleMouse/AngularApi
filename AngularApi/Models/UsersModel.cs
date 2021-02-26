using System;
using System.Collections.Generic;
using System.Collections.Concurrent;

namespace AngularApi.Models
{
    public class UsersModel:IUsersViewModel
    {


        private static ConcurrentDictionary<string, UsersViewModel> _todos =
             new ConcurrentDictionary<string, UsersViewModel>();
        public IEnumerable<UsersViewModel> GetAll()
        {
            return _todos.Values;
        }

        public void Add(UsersViewModel item)
        {
            _todos[item.firstName] = item;
        }
    }
}
