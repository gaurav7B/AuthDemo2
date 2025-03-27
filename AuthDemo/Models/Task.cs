using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AuthDemo.Models
{
    public class Task
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public string Priority { get; set; }
        public string Status { get; set; }
        public int AssignedEmployeeId { get; set; }
        public string AssignedEmployeeName { get; set; }
        public string AssignedEmployeeEmail { get; set; }
        public string AssignedEmployeeDepartment { get; set; }
    }
}
