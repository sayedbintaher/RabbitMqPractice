using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FormulaAirline.Api.models;
using Microsoft.EntityFrameworkCore;

namespace FormulaAirline.Api.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Booking> Bookings { get; set; }
    }
}