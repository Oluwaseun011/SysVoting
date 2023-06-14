using E_VotingApp.Models.Enums;

namespace E_VotingApp.Models.Entities
{
    public class User : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Image { get ; set; }
        public string PhoneNumber { get; set; }
        public string MembershipCard { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Gender Gender { get; set; }  
        public Disability Disability { get; set; }
        public List<RoleUser> UserRoles { get; set; }
        public Aspirant Aspirant { get; set; }
        public ElectoralChairman ElectoralChairman { get; set; }
        public Member Member { get; set; }
        public int AddressId { get; set; }
        public Address Address { get; set; }
        public ICollection<Association> Associations { get; set; } = new HashSet<Association>();    
        
    }
}
