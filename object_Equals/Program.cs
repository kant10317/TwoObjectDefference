using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace object_Equals
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = DateTime.Now;
            Person target = new Person()
            {
                Age = 18,
                Address = "碩益科技",
                CreatAt= dateTime,
                Name = new Name("曾", "大頭"),
            };

            Person expected = new Person()
            {
                Age = 18,
                Address = "碩益科技",
                CreatAt = dateTime,
                Name = new Name("曾", "大頭"),
            };

            Console.WriteLine("===Equal=====");
            if (expected.Equals(target))
            {
                Console.WriteLine("兩物件的值相等");
            }
            else
            {
                Console.WriteLine("兩物件的值不相等");
            }

            Console.WriteLine("===EqualExtension=====");
            if (expected.EqualsObject(target))
            {
                Console.WriteLine("兩物件的值相等");
            }
            else
            {
                Console.WriteLine("兩物件的值不相等");
            }

            Console.ReadLine();
        }
    }
}
