//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AhmadTaheri.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PolymersMatrices : DbContext
    {
        public PolymersMatrices()
            : base("name=PolymersMatrices")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Branch> Branches { get; set; }
        public virtual DbSet<BranchOnBranch> BranchOnBranches { get; set; }
        public virtual DbSet<D> D { get; set; }
        public virtual DbSet<Dprime> Dprimes { get; set; }
        public virtual DbSet<Kexp> Kexps { get; set; }
        public virtual DbSet<KMC> KMCs { get; set; }
        public virtual DbSet<N> N { get; set; }
        public virtual DbSet<P> P { get; set; }
        public virtual DbSet<Prk> Prks { get; set; }
        public virtual DbSet<Psec> Psecs { get; set; }
        public virtual DbSet<Ptert> Pterts { get; set; }
        public virtual DbSet<ReactionNumber> ReactionNumbers { get; set; }
        public virtual DbSet<RMC> RMCs { get; set; }
    }
}
