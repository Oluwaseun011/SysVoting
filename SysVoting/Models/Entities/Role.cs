namespace E_VotingApp.Models.Entities
{
    public class Role : BaseEntity
    {
        public string Name { get; set; }
        public ICollection<RoleUser> UserRoles { get; set; } = new HashSet<RoleUser>();
    }
}
