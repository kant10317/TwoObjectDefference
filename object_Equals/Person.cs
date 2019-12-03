using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace object_Equals
{
    [Serializable]
    public class Person
    {
        public int Age { get; set; }

        public string Address { get; set; }

        public DateTime CreatAt { get; set; }

        public Name Name { get; set; }
    }
}
