using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace efassig2
{
    internal class Course_Annotated
    {
        [Key]
        public int ID { get; set; }

        public int Duration { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        public int Top_ID { get; set; }

        [ForeignKey("Top_ID")]
        public virtual Topic Topic { get; set; }
        public virtual ICollection<Course_Inst> Course_Insts { get; set; }
        public virtual ICollection<Stud_Course> Stud_Courses { get; set; }
    }
}
