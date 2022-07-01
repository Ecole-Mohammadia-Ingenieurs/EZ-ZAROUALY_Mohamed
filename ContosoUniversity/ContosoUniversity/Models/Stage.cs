using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class Stage
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Number")]
        public int StageID { get; set; }

        [StringLength(50, MinimumLength = 3)]
        public string Title { get; set; }


        public int DepartmentID { get; set; }

        public Department Department { get; set; }
        public Student Student { get; set; }
        public Instructor Encadrant { get; set; }
    }
}