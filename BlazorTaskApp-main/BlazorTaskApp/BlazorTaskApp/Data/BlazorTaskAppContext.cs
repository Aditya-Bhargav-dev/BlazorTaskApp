using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BlazorTaskApp.Models;

namespace BlazorTaskApp.Data
{
    public class BlazorTaskAppContext : DbContext
    {
        public BlazorTaskAppContext (DbContextOptions<BlazorTaskAppContext> options)
            : base(options)
        {
        }

        public DbSet<BlazorTaskApp.Models.Book> Book { get; set; } = default!;
    }
}
