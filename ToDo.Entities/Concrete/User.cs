using System;
using System.Collections.Generic;
using System.Text;

namespace ToDo.Entities.Concrete
{
    public class User : IEntity
    {
        public int UserId { get; set; }
        public string Name { get; set; }
    }
}
