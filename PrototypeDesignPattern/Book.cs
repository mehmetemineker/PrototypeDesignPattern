using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeDesignPattern
{
    [Serializable]
    public class Book : ICopyable, ICloneable
    {
        public string Name { get; set; }
        public Author Author { get; set; }

        public object Clone()
        {
            return ObjectClone.Clone(this);
        }

        public object Copy()
        {
            return MemberwiseClone();
        }
    }
}
