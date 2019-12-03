using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace object_Equals
{
    public static class EqualsObjectExtension
    {
        public static bool EqualsObject(this object obj1, object obj2)
        {
            var targetArray = getObjectByte(obj1);
            var expectedArray = getObjectByte(obj2);
            var equals = expectedArray.SequenceEqual(targetArray);
            return equals;
        }

        private static byte[] getObjectByte(object model)
        {
            GetPropertyValues(model);

            using (MemoryStream memory = new MemoryStream())
            {
                var resultType = model.GetType();
                PropertyInfo[] props = resultType.GetProperties();

                foreach (var prop in props)
                {
                    if (prop.GetIndexParameters().Length == 0)
                    {
                        if (prop.PropertyType == typeof(DateTime))
                        {
                            var date = prop.GetValue(model);
                        }
                    }
                }

                XmlSerializer xs = new XmlSerializer(resultType);
                xs.Serialize(memory, model);
                var array = memory.ToArray();
                return array;
            }
        }

        private static void GetPropertyValues(Object model)
        {
            Type t = model.GetType();
            Console.WriteLine("Type is: {0}", t.Name);
            PropertyInfo[] props = t.GetProperties();
            Console.WriteLine("Properties (N = {0}):",
                              props.Length);
            foreach (var prop in props)
                if (prop.GetIndexParameters().Length == 0)
                    Console.WriteLine("   {0} ({1}): {2}", prop.Name,
                                      prop.PropertyType.Name,
                                      prop.GetValue(model));
                else
                    Console.WriteLine("   {0} ({1}): <Indexed>", prop.Name,
                                      prop.PropertyType.Name);
        }


    }
}
