using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Diagnostics.Metrics;

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
        public virtual DbSet<GlTransactionS> GLTRANSACTIONS { get; set; }
    }
}
