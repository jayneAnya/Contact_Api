using Contact.Domain.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact.Infrastructure
{
    public class ContactDbContext : DbContext
    {
        public ContactDbContext(DbContextOptions<ContactDbContext> option) : base(option)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserContact>()
                .HasMany(u => u.Email)
                .WithOne(e => e.UserContact)
                .HasForeignKey(e => e.UserContactId)
                .OnDelete(DeleteBehavior.Cascade);
        }


        public DbSet<Address> Addresses { get; set; } = null!;
        public DbSet<Email> Emails { get; set; } = null!;
        public DbSet<PhoneNumber> PhoneNumbers { get; set; } = null!;
        public DbSet<UserContact> UserContacts { get; set; } = null!;
    }
}
