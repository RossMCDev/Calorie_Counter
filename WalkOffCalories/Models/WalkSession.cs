namespace WalkOffCalories.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class WalkSession : DbContext
    {
        public WalkSession()
            : base("name=WalkSession")
        {
        }

        public virtual DbSet<Walk> Walks { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
 
        }
    }
}
