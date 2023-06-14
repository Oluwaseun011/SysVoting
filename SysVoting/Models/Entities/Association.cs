namespace E_VotingApp.Models.Entities
{
    public class Association : BaseEntity
    {
        public string Name{ get; set; }
        public string Description { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public ICollection<Election> Elections { get; set;}
        public ICollection<AssociationMember> AssociationMembers { get; set;}
       
        
    }
}
