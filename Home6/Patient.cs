using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home6
{
    internal class Patient
    {
        internal string Name { get; set; }
        internal IlnessType Ilnes { get; set; }

        internal Patient ()
        {

        }
        internal Patient (string name, IlnessType ilnes)
        {
            Name = name;
            Ilnes = ilnes;
        }
    }
}