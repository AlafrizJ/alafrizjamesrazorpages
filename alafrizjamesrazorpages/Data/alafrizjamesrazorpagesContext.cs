#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using alafrizjamesrazorpages.Pages.Basketball;

namespace alafrizjamesrazorpages.Data
{
    public class alafrizjamesrazorpagesContext : DbContext
    {
        public alafrizjamesrazorpagesContext (DbContextOptions<alafrizjamesrazorpagesContext> options)
            : base(options)
        {
        }

        public DbSet<alafrizjamesrazorpages.Pages.Basketball.Class> Class { get; set; }
    }
}
