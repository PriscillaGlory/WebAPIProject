using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebAPIProject.Models
{
    
    [Table("Subjects")]
    public class Subjects
    {
        [Key]
        public int SubjectId { get; set; }
        public string? SubjectName { get; set; }
    }
}