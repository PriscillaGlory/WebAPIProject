using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebAPIProject.Models
{
    [Table("Students")]
    public class Students
    {
        [Key]
        public int StudentId { get; set; }
        public string? StudentName { get; set; }
    }
}