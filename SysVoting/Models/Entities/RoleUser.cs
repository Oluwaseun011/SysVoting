namespace E_VotingApp.Models.Entities
{
    public class RoleUser : BaseEntity
    {
        public int UserId { get; set; }
        public int RoleId { get; set; }
        public User User { get; set; }
        public Role Role { get; set; }
    }
}
