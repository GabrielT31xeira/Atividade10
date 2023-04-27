using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using atividade10.Models;

namespace atividade10.Data
{
    public class atividade10Context : DbContext
    {
        public atividade10Context (DbContextOptions<atividade10Context> options)
            : base(options)
        {
        }

        public DbSet<atividade10.Models.Movie> Movie { get; set; } = default!;
    }
}
