using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home5
{
    public class MarkCreator
    {
        Random random = new Random();

        public int RandomMark()
        {
            return random.Next(1, 10);
        }
    }
}
