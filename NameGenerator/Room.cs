using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameGenerator
{
    public class Room
    {
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }

        public override bool Equals(object obj)
        {
            if(obj is Room)
            {
                return string.Equals(((Room)obj).Name, Name, StringComparison.InvariantCultureIgnoreCase);
            }

            return false;                   
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }
    }
}
