using aspPortoWebsite.Models.ForBook;
using aspPortoWebsite.Models.ForCart;
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
        public DbSet<Banner> Banners { get; set; } 
        public DbSet<ProductCategory> productCategories { get; set; } 
        public DbSet<UserToProduct> UserToProducts { get; set; } 
        public DbSet<ContactsForm> ContactsForms { get; set; } 
        public DbSet<Service> Services { get; set; } 
        public DbSet<HomeFooter> HomeFooters { get; set; } 
        public DbSet<OurStory> OurStories { get; set; } 
        public DbSet<WhyChoose> WhyChooses { get; set; } 
        public DbSet<Clients> Clients { get; set; } 
        public DbSet<MyBlogCollection> MyBlogCollections { get; set; } 
        public DbSet<AskedQuestion> AskedQuestions { get; set; }
        public DbSet<Books> Books { get; set; }
        public DbSet<BookGallery> BookGallery { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Size> Sizes { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<SizeToBooks> SizeToBooks { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<BooksToColor> BooksToColors { get; set; }
        public DbSet<ShopByCategory> ShopByCategories { get; set; }
        public DbSet<Checkout> Checkouts { get; set; }
        public DbSet<Sales> Sales { get; set; }
        public DbSet<MyBlogCollectionReview> MyBlogCollectionReviews { get; set; }
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

            modelBuilder.Entity<ShopByCategory>()
               .HasOne(a => a.ProductCategoryies)
               .WithMany(b => b.shopByCategories)
               .HasForeignKey(a => a.ProductsCategoryId);

            modelBuilder.Entity<Books>()
               .HasOne(a => a.productCategory)
               .WithMany(b => b.Books)
               .HasForeignKey(a => a.ProductsCategoryId);

            modelBuilder.Entity<MyBlogCollectionReview>()
               .HasOne(a => a.MyBlogCollection)
               .WithMany(b => b.myBlogCollectionReviews)
               .HasForeignKey(a => a.MyBlogCollectionid);

            modelBuilder.Entity<Checkout>()
               .HasOne(a => a.User)
               .WithMany(b => b.Checkouts)
               .HasForeignKey(a => a.UserId);

            modelBuilder.Entity<Sales>()
              .HasOne(a => a.User)
              .WithMany(b => b.Sales)
              .HasForeignKey(a => a.UserId);

            modelBuilder.Entity<Sales>()
              .HasOne(a => a.Books)
              .WithMany(b => b.sales)
              .HasForeignKey(a => a.BooksId);
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


            modelBuilder.Entity<BooksToColor>()
              .HasOne(a => a.Books)
              .WithMany(b => b.booksToColors)
              .HasForeignKey(a => a.BookId);

            modelBuilder.Entity<BooksToColor>()
              .HasOne(a => a.Color)
              .WithMany(b => b.booksToColors)
              .HasForeignKey(a => a.ColorId);

            modelBuilder.Entity<BooksToColor>()
                .HasKey(bc => new { bc.BookId, bc.ColorId });


            modelBuilder.Entity<SizeToBooks>()
              .HasOne(a => a.Books)
              .WithMany(b => b.sizeToBooks)
              .HasForeignKey(a => a.BooksId);

            modelBuilder.Entity<SizeToBooks>()
              .HasOne(a => a.Size)
              .WithMany(b => b.sizeToBooks)
              .HasForeignKey(a => a.SizeId);

            modelBuilder.Entity<SizeToBooks>()
                .HasKey(bc => new { bc.BooksId, bc.SizeId });

        }

    }
  
}
