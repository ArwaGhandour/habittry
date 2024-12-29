namespace WebApplication1.Models.Entities
{
    public class Reward
    {
        public int CateogryID { get; set; }
        public string? Name { get; set; }
       
        public ICollection<UserReward>? userRewards { get; set; }
    }
}
