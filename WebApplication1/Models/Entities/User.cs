namespace WebApplication1.Models.Entities
{
    public class User
    {
        public int UserID { get; set; }
        public string? UserName { get; set; }
        public string? Email { get; set; }
        public ICollection<Habit>? Habits { get; set; }

        public ICollection<UserReward>? userRewards { get; set; }
    }
}
