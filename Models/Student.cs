using System.ComponentModel.DataAnnotations;
namespace BTH2.Models
{
    public class Student
    {
        [Key]
        public string? StudentID  { get; set; }
        public string? StudentName  { get; set; }
        public string? Address { get; set; }
    }
}