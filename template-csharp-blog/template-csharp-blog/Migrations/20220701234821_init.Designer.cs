﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using template_csharp_blog;

#nullable disable

namespace template_csharp_blog.Migrations
{
    [DbContext(typeof(BlogContext))]
    [Migration("20220701234821_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("template_csharp_blog.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Video Games"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Consoles"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Game Store"
                        });
                });

            modelBuilder.Entity("template_csharp_blog.Models.Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Body")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("PublishDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Posts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Author = "Michael",
                            Body = "It's an amazing game",
                            CategoryId = 1,
                            PublishDate = new DateTime(2022, 7, 1, 19, 48, 21, 347, DateTimeKind.Local).AddTicks(5513),
                            Title = "Breath of the Wild"
                        },
                        new
                        {
                            Id = 2,
                            Author = "Michael",
                            Body = "it's the fastest console ever",
                            CategoryId = 2,
                            PublishDate = new DateTime(2022, 7, 1, 19, 48, 21, 347, DateTimeKind.Local).AddTicks(5557),
                            Title = "Xbox Series X"
                        },
                        new
                        {
                            Id = 3,
                            Author = "Michael",
                            Body = "Great place for old games",
                            CategoryId = 3,
                            PublishDate = new DateTime(2022, 7, 1, 19, 48, 21, 347, DateTimeKind.Local).AddTicks(5559),
                            Title = "GOG"
                        });
                });

            modelBuilder.Entity("template_csharp_blog.Models.Post", b =>
                {
                    b.HasOne("template_csharp_blog.Models.Category", null)
                        .WithMany("Post")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("template_csharp_blog.Models.Category", b =>
                {
                    b.Navigation("Post");
                });
#pragma warning restore 612, 618
        }
    }
}
