using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeDesignPattern
{
    public class ObjectClone
    {
        public static T Clone<T>(T obj)
        {
            using (var ms = new MemoryStream())
            {
                var formater = new BinaryFormatter();
                formater.Serialize(ms, obj);
                ms.Position = 0;

                return (T)formater.Deserialize(ms);
            }
        }
    }
}
