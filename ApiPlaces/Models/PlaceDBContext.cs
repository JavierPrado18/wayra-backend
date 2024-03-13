using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ApiPlaces.Models
{
    public class PlaceDBContext(DbContextOptions<PlaceDBContext> options) : DbContext(options)
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Place> Places { get; set; }
    }
}