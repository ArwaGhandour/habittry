using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models.Entities
{
    public class UserReward
    {
        public int UserIDd { get; set; }
        [ForeignKey("UserIDd")]
        public User? user { get; set; }
        public int Rewarddid { get; set; }
        [ForeignKey("Rewarddid")]
        public Reward? reward { get; set; }
    }
}
