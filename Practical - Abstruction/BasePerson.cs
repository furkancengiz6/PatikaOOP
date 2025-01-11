using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalAbstraction
{
    internal abstract class BasePerson
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }

        public abstract string Position();





    }
}
