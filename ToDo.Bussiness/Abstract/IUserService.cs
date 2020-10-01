using System;
using System.Collections.Generic;
using System.Text;
using ToDo.Entities.Concrete;

namespace ToDo.Bussiness.Abstract
{
    public interface IUserService
    {
        List<User> GetAll();
        List<User> GetByUserId();
        void Add(User user);
        void Update(User user);
        void Delete(int userId);
    }
}
