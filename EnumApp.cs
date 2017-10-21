using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enumTest
{
    class Program
    {
        public enum Test
        {
            Monday=1, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
        };
        static void Main(string[] args)

        {
            Array dayArray = Enum.GetValues(typeof(enumTest.Program.Test));
            foreach (Test day in dayArray)
                Console.WriteLine("Number " + day.ToString("d") + " of EnumTest.DAYS is " + day); Console.ReadKey();
        }
    }
}
