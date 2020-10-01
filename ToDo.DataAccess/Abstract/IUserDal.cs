using System;
using System.Collections.Generic;
using System.Text;
using ToDo.Core.DataAccess;
using ToDo.Entities.Concrete;

namespace ToDo.DataAccess.Abstract
{
   public interface IUserDal : IEntityRepository<User>
    {
    }
}
