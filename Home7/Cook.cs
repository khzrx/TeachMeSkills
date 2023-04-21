using System;
using System.Collections.Generic;
using System.Linq;
namespace Home7
{
    internal class Cook : Staff, ICleanable, ICookable
    {
        public Cook(string name, string position) 
            : base(name, position)
        {
        }

        public override string ToString()
        {
            return $"{Position}";
        }

        public void Clean(Staff staff)
        {
            Console.WriteLine($"{staff.ToString()} {staff.Name} is cleaning");
        }

        public void ToCook(Staff staff)
        {
            Console.WriteLine($"{staff.ToString()} {staff.Name} is cooking");
        }

        public override void Work(Staff staff)
        {
            Clean(staff);
            ToCook(staff);
        }
    }
}
