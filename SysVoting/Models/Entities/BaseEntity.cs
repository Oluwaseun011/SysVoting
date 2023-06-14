namespace E_VotingApp.Models.Entities
{
    public abstract class BaseEntity
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public bool IsDeleted { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.UtcNow;
        public string CreatedBy { get; set; } = null!;
        public string ModifiedBy { get; set; }
    }
}
