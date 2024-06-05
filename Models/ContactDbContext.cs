using Microsoft.EntityFrameworkCore;

namespace GTSLQP_ContactManager.Models
{
    public class ContactDbContext : DbContext
    {
        public DbSet<Contact> Contacts { get; set; } = null!;
        public DbSet<Category> Categories { get; set; } = null!;

        public ContactDbContext(DbContextOptions<ContactDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Fluent API for defining relationships, constraints, etc.

            modelBuilder.Entity<Contact>()
                .HasOne(c => c.Category)
                .WithMany(c => c.Contacts)
                .HasForeignKey(c => c.CategoryId)
                .OnDelete(DeleteBehavior.Cascade); // adjust delete behavior as needed

            // Add some dummy categories
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, CategoryName = "Family" },
                new Category { CategoryId = 2, CategoryName = "Friends" },
                new Category { CategoryId = 3, CategoryName = "Work" }
            );

            // Add some dummy contacts
            modelBuilder.Entity<Contact>().HasData(
                new Contact
                {
                    ContactId = 1,
                    FirstName = "Saanj",
                    LastName = "Seetha",
                    Phone = "9900932702",
                    Email = "saanjseets@gmail.com",
                    CategoryId = 1
                },
                 new Contact
                 {
                     ContactId = 2,
                     FirstName = "Nyla",
                     LastName = "Soms",
                     Phone = "7335568990",
                     Email = "nilsoms12@yahoo.com",
                     CategoryId = 2
                 },

                new Contact
                {
                    ContactId = 3,
                    FirstName = "Drishya",
                    LastName = "Dech",
                    Phone = "8905347812",
                    Email = "dechy1603@hotmail.com",
                    CategoryId = 2
                }
            );
        }
    }
}
