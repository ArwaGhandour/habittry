namespace WebApplication1.Models.Entities
{
    public class HabitCategory
    {
        public int CateogryID { get; set; }
        public string? Name { get; set; }
        public ICollection<Habit>? Habitss { get; set; }
    }
}
