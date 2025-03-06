using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace efassig2
{
    internal class Department
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Ins_ID { get; set; }
        public DateTime HiringDate { get; set; }
        public virtual Instructor Instructor { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}
