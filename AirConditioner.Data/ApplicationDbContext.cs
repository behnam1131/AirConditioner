using AirConditioner.Core.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AirConditioner.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            
        }
        public DbSet<AirConditionerModel> AirConditionerModels { get; set; }       
        public DbSet<Customer> Customers { get; set; }

        private DbSet<EngineVolume> engineVolumes { get; set; }     

        public DbSet<EnumMember> EnumMembers { get; set; }
        public DbSet<EnumType> EnumTypes { get; set; }
        public DbSet<Factor> Factors { get; set; }
        public DbSet<FactorPiece> FactorPieces { get; set; }
        public DbSet<Piece> Pieces { get; set; }
        public DbSet<PiecePrice> PiecePrices { get; set; }
        public DbSet<PiecePercent> piecePercents { get; set; }
        public DbSet<UserAssistant> UserAssistants { get; set; }
        public DbSet<UserExpert> UserExperts { get; set; }
        public DbSet<UserOperator> UserOperators { get; set; }
        public DbSet<UserTechnician> UserTechnicians { get; set; }
        public DbSet<EngineVolume> EngineVolumes { get; set; }
        public DbSet<Work> Works { get; set; }
        public DbSet<FactorWork>  FactorWorks { get; set; }
    }
}
