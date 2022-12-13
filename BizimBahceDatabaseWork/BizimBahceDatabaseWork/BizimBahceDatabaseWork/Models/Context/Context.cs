using BizimBahceDatabaseWork.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace BizimBahceDatabaseWork.Models.Context
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=localhost; database=ProjectOliveOil; integrated security=true");

        }

        public DbSet<OliveOil> OliveOils { get; set; }
        public DbSet<OliveOilBenefit> OliveOilBenefits { get; set; }
        public DbSet<OliveOilPrice> OliveOilPrices { get; set; }
        public DbSet<OliveOilProperty> OliveOilProperties { get; set; }
        public DbSet<OliveOilType> OliveOilTypes { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Admin> Admins { get; set; }



    }
}
