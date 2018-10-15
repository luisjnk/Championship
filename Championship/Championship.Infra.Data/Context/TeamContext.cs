using Championship.Domain.Entities;
using System.Data.Entity;

namespace Championship.Infra.Data.Context
{
   public class TeamContext : DbContext
    {
        public TeamContext() 
            :base("Championship")
        {

        }

        public DbSet<Team> Teams { get; set; }
    }
}
