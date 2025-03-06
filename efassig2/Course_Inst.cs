using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace efassig2
{
    internal class Course_Inst
    {
        public int Inst_ID { get; set; }
        public int Course_ID { get; set; }
        public int Evaluate { get; set; }
        public virtual Instructor Instructor { get; set; }
        public virtual Course Course { get; set; }
    }
}
