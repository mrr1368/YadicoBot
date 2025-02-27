using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yadico.DataLayer.Models;

namespace Yadico.DataLayer.ApplicationDbContext
{
    class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("name = DefaultConnection")
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Plan> Plans { get; set; }
        public DbSet<MotivationMessage> MotivationMessages { get; set; }
    }
}
