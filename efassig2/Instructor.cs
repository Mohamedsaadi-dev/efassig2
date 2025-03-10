﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace efassig2
{
    internal class Instructor
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public string Address { get; set; }
        public decimal HourRate { get; set; }
        public decimal Bonus { get; set; }
        public int Dept_ID { get; set; }
        public virtual Department Department { get; set; }
        public virtual ICollection<Course_Inst> Course_Insts { get; set; }
    }
}
