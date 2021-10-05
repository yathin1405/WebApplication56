using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace WebApplication56.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public string Address { get; set; }
        public string Gender { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserType { get; set; }
        public string CssTheme { get; set; }
        public int numBookings { get; set; }
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public System.Data.Entity.DbSet<WebApplication56.Models.Flight> Flights { get; set; }

        public System.Data.Entity.DbSet<WebApplication56.Models.Customer> Customers { get; set; }

        public System.Data.Entity.DbSet<WebApplication56.Models.RegisterAllViewModel> RegisterAllViewModels { get; set; }

        public System.Data.Entity.DbSet<WebApplication56.Models.PayPalModel> PayPalModels { get; set; }

        public System.Data.Entity.DbSet<WebApplication56.Models.Quote> Quotes { get; set; }

        //public System.Data.Entity.DbSet<WebApplication56.Models.Transaction> Transactions { get; set; }
    }
}