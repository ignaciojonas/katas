using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KataPrim
{
    public class Link
    {
        public int n1 { get; set; }
        public int n2 { get; set; }
        public int w { get; set; }

        public Link(int n1, int n2, int w)
        {
            this.n1 = n1;
            this.n2 = n2;
            this.w = w;
        }
    }
}
