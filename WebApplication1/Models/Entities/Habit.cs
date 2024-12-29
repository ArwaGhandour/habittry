using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models.Entities
{
    public class Habit
    {
        public int HabitID { get; set; }
        public string? Name { get; set; }
        public string? StartDate { get; set; }
        public bool IsCompleted { get; set; }
        public int UserIDD { get; set; }
        [ForeignKey("UserIDD")]
        public User? User { get; set; }
        public int CateogryIDD { get; set; }
        [ForeignKey("CateogryIDD")]
        public HabitCategory? Category { get; set; }
    }
}
