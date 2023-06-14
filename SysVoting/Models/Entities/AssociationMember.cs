namespace E_VotingApp.Models.Entities
{
    public class AssociationMember : BaseEntity
    {
        public int AssociationId { get; set; }
        public  int MemberId { get; set; }
        public Association Association { get; set; }
        public Member Member { get; set; }
    }
}
