
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace MakeABill.Infraestrecture.Context
{
    public class MakeABillApiDbContext : IdentityDbContext<IdentityUser>
    {

        public MakeABillApiDbContext (DbContextOptions<MakeABillApiDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

    }


}
