namespace E_VotingApp.Models.Entities
{
    public class Aspirant : BaseEntity
    {
        public string NickName { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int PositionId { get; set; }
        public Position Position { get; set; }
    }
}
