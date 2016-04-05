using BigGame.Objects;
using System.Data.Entity;

namespace BigGame.DataAccess
{
    public class BigGameContext : DbContext
    {
        public BigGameContext()
            : base("BigGame")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasKey(e => e.Username);
            modelBuilder.Entity<User>().Property(e => e.DisplayName).IsRequired();

            modelBuilder.Entity<IdentityProvider>().HasKey(e => e.Id);
            modelBuilder.Entity<IdentityProvider>().Property(e => e.Name).IsRequired();

            modelBuilder.Entity<UserAccount>().HasKey(e => new { e.UserUsername, e.ProviderId });
            modelBuilder.Entity<UserAccount>().Property(e => e.Account).IsRequired();
        }
    }
}
