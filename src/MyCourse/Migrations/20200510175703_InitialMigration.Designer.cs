﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyCourse.Models.Services.Infrastructure;

namespace MyCourse.Migrations
{
    [DbContext(typeof(MyCourseDbContext))]
    [Migration("20200510175703_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity("MyCourse.Models.Entities.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Author")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("ImagePath")
                        .HasColumnType("TEXT");

                    b.Property<double>("Rating")
                        .HasColumnType("REAL");

                    b.Property<string>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("MyCourse.Models.Entities.Lesson", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CourseId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<TimeSpan>("Duration")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.ToTable("Lessons");
                });

            modelBuilder.Entity("MyCourse.Models.Entities.Course", b =>
                {
                    b.OwnsOne("MyCourse.Models.ValueTypes.Money", "CurrentPrice", b1 =>
                        {
                            b1.Property<int>("CourseId")
                                .HasColumnType("INTEGER");

                            b1.Property<float>("Amount")
                                .HasColumnName("CurrentPrice_Amount")
                                .HasColumnType("REAL");

                            b1.Property<string>("Currency")
                                .IsRequired()
                                .HasColumnName("CurrentPrice_Currency")
                                .HasColumnType("TEXT");

                            b1.HasKey("CourseId");

                            b1.ToTable("Courses");

                            b1.WithOwner()
                                .HasForeignKey("CourseId");
                        });

                    b.OwnsOne("MyCourse.Models.ValueTypes.Money", "FullPrice", b1 =>
                        {
                            b1.Property<int>("CourseId")
                                .HasColumnType("INTEGER");

                            b1.Property<decimal>("Amount")
                                .HasColumnType("TEXT");

                            b1.Property<string>("Currency")
                                .IsRequired()
                                .HasColumnType("TEXT");

                            b1.HasKey("CourseId");

                            b1.ToTable("Courses");

                            b1.WithOwner()
                                .HasForeignKey("CourseId");
                        });
                });

            modelBuilder.Entity("MyCourse.Models.Entities.Lesson", b =>
                {
                    b.HasOne("MyCourse.Models.Entities.Course", "Course")
                        .WithMany("Lessons")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
