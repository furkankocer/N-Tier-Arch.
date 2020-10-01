using System;
using System.Collections.Generic;
using System.Text;
using ToDo.Core.DataAccess.EntityFramework;
using ToDo.DataAccess.Abstract;
using ToDo.Entities.Concrete;

namespace ToDo.DataAccess.Concrete.EntityFramework
{
   public class EfProductDal : EfEntityRepositoryBase<User,ToDoContext>, IUserDal
    {
    }
}
