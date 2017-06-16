using Bogus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameGenerator
{
    public class RoomNameGenerator: Faker<Room>
    {
        public RoomNameGenerator()
        {
            RuleFor(x => x.Name, f => f.Address.City());
        }
    }
}
