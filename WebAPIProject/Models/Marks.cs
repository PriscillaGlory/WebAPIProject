using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebAPIProject.Models
{
    [Table("Marks")]
    public class Marks
    {
        [Key]
        public int MarksId { get; set; }
        public int StudentId { get; set; }
        public int SubjectId { get; set; }
        public int MarksObtained { get; set; }

    }
}
