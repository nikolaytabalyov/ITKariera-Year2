using CampRating.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CampRating.Data {
    public class ApplicationDbContext : IdentityDbContext<IdentityUser> {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) {
        }

        public DbSet<CampingSite> CampingSites { get; set; }
        public DbSet<Review> Reviews { get; set; }
    }
}