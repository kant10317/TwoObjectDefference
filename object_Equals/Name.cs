using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace object_Equals
{
    public class Name
    {
        public string FristName { get; set; }

        public string LastName { get; set; }

        public Name()
        {
        }

        public Name(string frisName, string lastName)
        {
            this.FristName = frisName;
            this.LastName = lastName;
        }
    }
}
