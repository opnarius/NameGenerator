using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            var generator = new RoomNameGenerator();

            var names = generator.Generate(1000);

            var rooms = names.Distinct().Take(12);

            foreach (var room in rooms)
            {
                Console.WriteLine(room);
            }
        }
    }
}
