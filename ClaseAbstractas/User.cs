using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseAbstractas
{
    public abstract class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int AccountBalance { get; set; }

        public abstract void Login();
    }
}
