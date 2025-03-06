using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace efassig2
{
    internal class Student_Annotated
    {
        [Key]
        public int ID { get; set; }

        [Required, MaxLength(50)]
        public string FName { get; set; }

        [Required, MaxLength(50)]
        public string LName { get; set; }

        public string Address { get; set; }

        [Range(18, 100)]
        public int Age { get; set; }

        public int Dep_Id { get; set; }

        [ForeignKey("Dep_Id")]
        public virtual Department Department { get; set; }
        public virtual ICollection<Stud_Course> Stud_Courses { get; set; }
    }
}
