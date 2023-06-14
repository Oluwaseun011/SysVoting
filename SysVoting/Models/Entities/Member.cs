namespace E_VotingApp.Models.Entities
{
    public class Member : BaseEntity
    {
        public int UserId { get; set; }
        public User User { get; set; }
        public int AssociationId { get; set; }
        public ICollection<AssociationMember> AssociationMembers { get; set; } = new HashSet<AssociationMember>();  
    } 
}
