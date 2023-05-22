using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Database;

namespace ToDo.core
{
    public class DatabaseLocator
    {
        public static ToDoListDbContext Database { get; set; }
    }
}
