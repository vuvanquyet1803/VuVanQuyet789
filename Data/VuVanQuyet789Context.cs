#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VuVanQuyet789.Models;

    public class VuVanQuyet789Context : DbContext
    {
        public VuVanQuyet789Context (DbContextOptions<VuVanQuyet789Context> options)
            : base(options)
        {
        }

        public DbSet<VuVanQuyet789.Models.CompanyVVQ789> CompanyVVQ789 { get; set; }

        public DbSet<VuVanQuyet789.Models.VVQ0789> VVQ0789 { get; set; }
    }
