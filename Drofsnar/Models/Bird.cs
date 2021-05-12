using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drofsnar
{
    public class Bird : IBird
    {
        public string Name => "Bird";

        public int Value => 10;
    }
}
