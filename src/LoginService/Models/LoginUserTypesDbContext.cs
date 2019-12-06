using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace employeeservice.Models
{
    public partial class LoginUserTypesDbContext : DbContext
    {
        public LoginUserTypesDbContext()
        {
        }

        public LoginUserTypesDbContext(DbContextOptions options) : base(options)
        {
        }
        
        public DbSet<LoginUserTypes> LoginUserTypes { get; set; }
    }
}
