﻿// <auto-generated />
using System;
using BikolTwitter.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BikolTwitter.Migrations
{
    [DbContext(typeof(BikolTwitterDbContext))]
    [Migration("20230121111612_AddBikolSubTweetsTable")]
    partial class AddBikolSubTweetsTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.2");

            modelBuilder.Entity("BikolTwitter.Entities.BikolPost", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("BikolSubId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Profit")
                        .HasColumnType("decimal(5,2)");

                    b.Property<string>("TwitterId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("BikolSubId");

                    b.HasIndex("TwitterId")
                        .IsUnique();

                    b.ToTable("BikolPosts");
                });

            modelBuilder.Entity("BikolTwitter.Entities.BikolSub", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("ProfitSum")
                        .HasColumnType("decimal(10,2)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("Username")
                        .IsUnique();

                    b.ToTable("BikolSubs");
                });

            modelBuilder.Entity("BikolTwitter.Entities.BikolSubTweet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("TEXT");

                    b.Property<int>("FavoriteCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FullText")
                        .HasColumnType("TEXT");

                    b.Property<string>("Prefix")
                        .HasColumnType("TEXT");

                    b.Property<string>("Suffix")
                        .HasColumnType("TEXT");

                    b.Property<string>("Text")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("BikolSubTweets");
                });

            modelBuilder.Entity("BikolTwitter.Entities.BikolPost", b =>
                {
                    b.HasOne("BikolTwitter.Entities.BikolSub", "BikolSub")
                        .WithMany()
                        .HasForeignKey("BikolSubId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BikolSub");
                });
#pragma warning restore 612, 618
        }
    }
}
