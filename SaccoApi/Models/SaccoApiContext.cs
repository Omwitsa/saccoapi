using Microsoft.EntityFrameworkCore;

namespace SaccoApi.Models
{
    public class SaccoApiContext : DbContext
    {
        public SaccoApiContext()
        {
        }

        public SaccoApiContext(DbContextOptions<SaccoApiContext> options)
        : base(options)
        {
        }

        public virtual DbSet<Member> MEMBERS { get; set; }
        public virtual DbSet<Repay> REPAY { get; set; }
        public virtual DbSet<GlTransaction> GLTRANSACTIONS { get; set; }
        public virtual DbSet<Contrib> CONTRIB { get; set; }
        public virtual DbSet<ShareType> sharetype { get; set; }
        public virtual DbSet<LoansType> LOANTYPE { get; set; }
        public virtual DbSet<LoanBal> LOANBAL { get; set; }
    }
}
