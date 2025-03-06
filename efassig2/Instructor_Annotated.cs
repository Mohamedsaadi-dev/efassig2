using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace efassig2
{
    internal class Instructor_Annotated
    {
        [Key]
        public int ID { get; set; }

        [Required, MaxLength(100)]
        public string Name { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Salary { get; set; }

        public string Address { get; set; }

        public decimal HourRate { get; set; }

        public decimal Bonus { get; set; }

        public int Dept_ID { get; set; }

        [ForeignKey("Dept_ID")]
        public virtual Department Department { get; set; }
        public virtual ICollection<Course_Inst> Course_Insts { get; set; }
    }
}
