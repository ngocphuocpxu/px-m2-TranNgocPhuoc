﻿// <auto-generated />
using BookManager.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BookManager.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20201113051323_seeder_table_Category")]
    partial class seeder_table_Category
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("BookManager.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Author = "Nick Arnold - Tony De Saulles",
                            CategoryId = 1,
                            Count = 100,
                            Description = "Cuốn sách thuộc bộ Horrible Science, được trình bày bằng giọng văn và các minh họa hài hước quen thuộc của hai tác giả Nick Arnold và Tony De Saulles giúp bạn dễ dàng làm quen với kiến thức cơ bản nhất liên quan đến các loại vi khuẩn vi sinh.",
                            Name = "Horrible Science - Vi Sinh Vật Vi Tính",
                            Year = 2015
                        },
                        new
                        {
                            Id = 2,
                            Author = "William J. Bernstein",
                            CategoryId = 2,
                            Count = 200,
                            Description = "Toàn cầu hóa” hóa ra không phải là một hay thậm chí là một chuỗi sự kiện; mà đó là tiến trình diễn ra chậm rãi trong một thời gian rất, rất dài. Thế giới không đột nhiên trở nên “phẳng” với phát kiến về Internet, và thương mại không bất ngờ bị các tập đoàn lớn tầm cỡ toàn cầu chi phối vào cuối thế kỷ 20. ",
                            Name = "Lịch Sử Giao Thương: Thương Mại Định Hình Thế Giới Như Thế Nào?",
                            Year = 2016
                        },
                        new
                        {
                            Id = 3,
                            Author = "Lan Khai",
                            CategoryId = 3,
                            Count = 250,
                            Description = "Tiểu thuyết chủ đề lịch sử của nhà văn Lan Khai được xuất bản vào năm 1937. Ông được đánh giá là một cây bút sung mãn, một nhà văn đường rừng sáng giá. Dù ở thể loại nào ngòi bút của ông vẫn thuyết phục được cảm tình và lí tính của độc giả.",
                            Name = "Chiếc Ngai Vàng",
                            Year = 2018
                        });
                });

            modelBuilder.Entity("BookManager.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryName = "Khoa Học - Kỹ Thuật"
                        },
                        new
                        {
                            Id = 2,
                            CategoryName = "Lịch Sử - Chính Trị"
                        },
                        new
                        {
                            Id = 3,
                            CategoryName = "Văn Học Việt Nam"
                        });
                });

            modelBuilder.Entity("BookManager.Models.Book", b =>
                {
                    b.HasOne("BookManager.Models.Category", "Category")
                        .WithMany("Books")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("BookManager.Models.Category", b =>
                {
                    b.Navigation("Books");
                });
#pragma warning restore 612, 618
        }
    }
}
