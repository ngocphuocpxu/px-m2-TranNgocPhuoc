using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookManager.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> dbContextOptions) : base(dbContextOptions)
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(new Category { Id = 1, CategoryName = "Khoa Học - Kỹ Thuật" });
            modelBuilder.Entity<Category>().HasData(new Category { Id = 2, CategoryName = "Lịch Sử - Chính Trị" });
            modelBuilder.Entity<Category>().HasData(new Category { Id = 3, CategoryName = "Văn Học Việt Nam" });

            modelBuilder.Entity<Book>().HasData(new Book
            {
                Id = 1,
                Name = "Horrible Science - Vi Sinh Vật Vi Tính",
                Author= "Nick Arnold - Tony De Saulles",
                Description= "Cuốn sách thuộc bộ Horrible Science, được trình bày bằng giọng văn và các minh họa hài hước quen thuộc của hai tác giả Nick Arnold và Tony De Saulles giúp bạn dễ dàng làm quen với kiến thức cơ bản nhất liên quan đến các loại vi khuẩn vi sinh.",
                Year=2015,
                Count=100,
                CategoryId=1
            });
            modelBuilder.Entity<Book>().HasData(new Book
            {
                Id = 2,
                Name = "Lịch Sử Giao Thương: Thương Mại Định Hình Thế Giới Như Thế Nào?",
                Author = "William J. Bernstein",
                Description = "Toàn cầu hóa” hóa ra không phải là một hay thậm chí là một chuỗi sự kiện; mà đó là tiến trình diễn ra chậm rãi trong một thời gian rất, rất dài. Thế giới không đột nhiên trở nên “phẳng” với phát kiến về Internet, và thương mại không bất ngờ bị các tập đoàn lớn tầm cỡ toàn cầu chi phối vào cuối thế kỷ 20. ",
                Year = 2016,
                Count = 200,
                CategoryId = 2
            });
            modelBuilder.Entity<Book>().HasData(new Book
            {
                Id = 3,
                Name = "Chiếc Ngai Vàng",
                Author = "Lan Khai",
                Description = "Tiểu thuyết chủ đề lịch sử của nhà văn Lan Khai được xuất bản vào năm 1937. Ông được đánh giá là một cây bút sung mãn, một nhà văn đường rừng sáng giá. Dù ở thể loại nào ngòi bút của ông vẫn thuyết phục được cảm tình và lí tính của độc giả.",
                Year = 2018,
                Count = 250,
                CategoryId = 3
            });
        }
    }
}