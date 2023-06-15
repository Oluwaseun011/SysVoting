using E_VotingApp.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace SysVoting.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options) : base(options)
        {
            
        }



        public DbSet<Address> Addresses { get; set; }

        public DbSet<Aspirant> Aspirants { get; set; }

        public DbSet<Association> Associations { get; set; }

        public DbSet<AssociationMember> AssociationsMembers { get; set; }

        public DbSet<Election> Elections { get; set; }

        public DbSet<ElectoralChairman> ElectoralChairmans { get; set; }

        public DbSet<Member> Members { get; set; }

        public DbSet<Position> Positions { get; set; }
        
        public DbSet<Result> Results { get; set; }

        public DbSet<Role> Roles { get; set; }

        public DbSet<RoleUser> RoleUsers { get; set; }

        public DbSet<User> Users { get;}

        public DbSet<Voting> Votings { get; set; }
    }
}
