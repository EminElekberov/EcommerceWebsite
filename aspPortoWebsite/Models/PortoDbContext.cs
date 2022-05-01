using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspPortoWebsite.Models
{
    public class PortoDbContext:IdentityDbContext<User>
    {
        public PortoDbContext(DbContextOptions<PortoDbContext> options):base(options) { }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<StudentAdress> StudentAdresses { get; set; }
        public DbSet<Group> Groups { get; set; } 
        public DbSet<Work> Works { get; set; } 
        public DbSet<tests> test { get; set; } 
        public DbSet<Product> Products { get; set; } 
        public DbSet<UserToProduct> UserToProducts { get; set; } 
        //public DbSet<Teacher> Teacher { get; set; } 
       // public DbSet<Hobby> Hobby { get; set; } 
       // public DbSet<TechertoHobby> TechertoHobby { get; set; } 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Slider>().HasData(
            new Slider
            {
                ID = 1,
                Image = "slide1.jpg",
                ClothType = "On Jackets",
                DisCount = "Get up to 60% off",
                Price = 130,
                TrendWord = "Winter Fashion Trends"
            },
            new Slider
            {
                ID = 2,
                Image = "slide2.jpg",
                ClothType = "On Coat",
                DisCount = "Get up to 10% off",
                Price = 200,
                TrendWord = "Season Fashion Trends"
            });
            //one to one 
            modelBuilder.Entity<Student>()
                .HasOne(a => a.Adress)
                .WithOne(b => b.Student)
                .HasForeignKey<StudentAdress>(b => b.StudentId);

            //one to many
            modelBuilder.Entity<Student>()
               .HasOne(a => a.Group)
               .WithMany(b => b.Students)
               .HasForeignKey(a => a.GroupId);

            ////many to many
            //modelBuilder.Entity<TechertoHobby>()
            //    .HasNoKey();


            modelBuilder.Entity<TechertoHobby>()
               .HasOne(a => a.Teacher)
               .WithMany(b => b.TechertoHobbies)
               .HasForeignKey(a => a.TeacherID);

            modelBuilder.Entity<TechertoHobby>()
              .HasOne(a => a.Hobby)
              .WithMany(b => b.TechertoHobbies)
              .HasForeignKey(a => a.HobbyId);

            modelBuilder.Entity<TechertoHobby>()
                .HasKey(bc => new { bc.TeacherID, bc.HobbyId });

        }

    }
  
}
