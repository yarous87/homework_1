using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_1
{
    internal class Square
    {
        private int side;

        public Square(int side) {
            this.side = side;
        }

        public Square() : this(1)
        {
        }
    }
}
