namespace MVCFriends
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class FriendsDBContext : DbContext
    {
        public FriendsDBContext()
            : base("name=FriendsDBContext")
        {
        }

        public virtual DbSet<Friend> Friends { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
