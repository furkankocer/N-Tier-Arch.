using System;
using System.Collections.Generic;
using System.Text;
using ToDo.Bussiness.Abstract;
using ToDo.DataAccess.Abstract;
using ToDo.Entities.Concrete;

namespace ToDo.Bussiness.Concrete
{
    public class UserService : IUserService
    {
        private IUserDal _userDal;

        public UserService(IUserDal userDal)
        {
            _userDal = userDal;
        }
        public List<User> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<User> GetByUserId()
        {
            throw new NotImplementedException();
        }

        public void Add(User user)
        {
            throw new NotImplementedException();
        }

        public void Update(User user)
        {
            throw new NotImplementedException();
        }

        public void Delete(int userId)
        {
            throw new NotImplementedException();
        }
    }
}
