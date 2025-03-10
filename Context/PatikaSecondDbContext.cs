using Code_First_Relation.Entities;
using Microsoft.EntityFrameworkCore;

namespace Code_First_Relation.Context
{
    public class PatikaSecondDbContext:DbContext
    {
        public PatikaSecondDbContext(DbContextOptions<PatikaSecondDbContext> options) : base(options) { }

        public DbSet<UserEntity> Users  => Set<UserEntity>();

        public DbSet<PostEntity> Posts => Set<PostEntity>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //İlişki tanımlama 
            modelBuilder.Entity<PostEntity>().HasOne(p => p.User).WithMany(u => u.Posts).HasForeignKey(u => u.UserId);
            // Post'in bir User'ı var
            // User'ın birden çok Post'u olabilir
            // Post'taki foreign key => UserId

        }
    }
}
