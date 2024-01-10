using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SistemaInventario.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventario.Infraestructure.DbContexts
{
    public class UserAppDbContext : IdentityDbContext<UserApp>
    {
        public UserAppDbContext(DbContextOptions<UserAppDbContext> options) : base(options)
        {

        }
        public virtual DbSet<UserApp> Users { get; set; }
    }
}
