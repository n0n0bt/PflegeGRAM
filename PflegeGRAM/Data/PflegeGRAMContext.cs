
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace PflegeGRAM.Data
{
    public class PflegeGRAMContext : IdentityDbContext
    {
        public PflegeGRAMContext(DbContextOptions<PflegeGRAMContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }


    }
}