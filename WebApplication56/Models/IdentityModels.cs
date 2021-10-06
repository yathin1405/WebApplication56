﻿using System.Data.Entity;
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
        //public DbSet<Customer> Customers { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        //public DbSet<RegisterAllViewModel> RegisterAllViewModel { get; set; }
        public System.Data.Entity.DbSet<WebApplication56.Models.Event> Events { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }

        public DbSet<Reservation> reservations { get; set; }
        public DbSet<Rooms> Rooms { get; set; }
        public DbSet<RoomTypes> roomTypes { get; set; }
        public DbSet<Payments> payment { get; set; }

        //public DbSet<Extras> extrass { get; set; }

        public DbSet<Shuttle> shuttle { get; set; }
        public DbSet<AddEvents> addEventD { get; set; }
        public DbSet<BookEvent> bookEvent { get; set; }
        public DbSet<PersonalData> personalData { get; set; }
        public DbSet<WalkinReserve> walkReserve { get; set; }
        public DbSet<Bill> bills { get; set; }




        public System.Data.Entity.DbSet<WebApplication56.Models.GuestDetails> GuestDetails { get; set; }

        public System.Data.Entity.DbSet<WebApplication56.Models.ViewModel> ViewModels { get; set; }

        public System.Data.Entity.DbSet<WebApplication56.Models.Description> Descriptions { get; set; }

        public System.Data.Entity.DbSet<WebApplication56.Models.VM> VMs { get; set; }

        public System.Data.Entity.DbSet<WebApplication56.Models.Cancellation> Cancellations { get; set; }

        public System.Data.Entity.DbSet<WebApplication56.Models.AddPrice> AddPrices { get; set; }

        public System.Data.Entity.DbSet<WebApplication56.Models.RoomService> RoomServices { get; set; }
        public System.Data.Entity.DbSet<WebApplication56.Models.Flight> Flights { get; set; }

        public System.Data.Entity.DbSet<WebApplication56.Models.Customer> Customers { get; set; }

        public System.Data.Entity.DbSet<WebApplication56.Models.RegisterAllViewModel> RegisterAllViewModels { get; set; }

        public System.Data.Entity.DbSet<WebApplication56.Models.PayPalModel> PayPalModels { get; set; }

        public System.Data.Entity.DbSet<WebApplication56.Models.Quote> Quotes { get; set; }

        public System.Data.Entity.DbSet<WebApplication56.Models.Cruise> Cruises { get; set; }

        public System.Data.Entity.DbSet<WebApplication56.Models.Tour> Tours { get; set; }

        //public System.Data.Entity.DbSet<WebApplication56.Models.Transaction> Transactions { get; set; }
    }
}