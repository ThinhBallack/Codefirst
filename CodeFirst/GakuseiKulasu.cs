using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst
{
    public class GakuseiKulasu: Entity<int>
    {
        public virtual Gakusei Gakusei { get; set; }
        public virtual Kulasu Kulasu { get; set; }

    }
}
