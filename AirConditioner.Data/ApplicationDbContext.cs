using AirConditioner.Core.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AirConditioner.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql("Host=raja.db.elephantsql.com;Database=mnoyzxti;Username=mnoyzxti;Password=zMykjICPmmoO7zIpOIs-YIZbqDCHOvV-");
            //=> optionsBuilder.UseNpgsql("Host=ec2-54-197-239-115.compute-1.amazonaws.com" +
            //    "Database=dfa7g11820kube" +
            //    "User=staqclgjerrwcu" +
            //    "Password=ca959d87135967a053502d78199e58fcbde01e3d7d9fda0644f774c3e64c1de4");


        public DbSet<AirConditionerModel> AirConditionerModels { get; set; }       
        public DbSet<Customer> Customers { get; set; }

        private DbSet<EngineVolume> engineVolumes { get; set; }     

        public DbSet<EnumMember> EnumMembers { get; set; }
        public DbSet<EnumType> EnumTypes { get; set; }
        public DbSet<Factor> Factors { get; set; }
        public DbSet<FactorPiece> FactorPieces { get; set; }
        public DbSet<Piece> Pieces { get; set; }
        public DbSet<UserAssistant> UserAssistants { get; set; }
        public DbSet<UserExpert> UserExperts { get; set; }
        public DbSet<UserOperator> UserOperators { get; set; }
        public DbSet<UserTechnician> UserTechnicians { get; set; }
        public DbSet<EngineVolume> EngineVolumes { get; set; }
        public DbSet<Work> Works { get; set; }
        public DbSet<FactorWork>  FactorWorks { get; set; }
        public DbSet<PieceCost>  PieceCosts { get; set; }
    }
}
