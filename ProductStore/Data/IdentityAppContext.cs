using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ProductStore.Data
{
    public class IdentityAppContext : IdentityDbContext
    {
        public IdentityAppContext(DbContextOptions options) : base(options)
        {
        }

        protected IdentityAppContext()
        {
        }


    }
}
