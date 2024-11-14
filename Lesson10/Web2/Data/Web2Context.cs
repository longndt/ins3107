using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Web2.Models;

namespace Web2.Data
{
    public class Web2Context : DbContext
    {
        public Web2Context (DbContextOptions<Web2Context> options)
            : base(options)
        {
        }

        public DbSet<Web2.Models.Student> Student { get; set; } = default!;
    }
}
