﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SkillSphere.Data;

#nullable disable

namespace SkillSphere.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SkillSphere.Model.Db.Chat", b =>
                {
                    b.Property<int>("JobId")
                        .HasColumnType("int");

                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<int>("FreelancerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("JobId", "ClientId", "FreelancerId");

                    b.HasIndex("ClientId");

                    b.HasIndex("FreelancerId");

                    b.ToTable("Chats");
                });

            modelBuilder.Entity("SkillSphere.Model.Db.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double>("Paid")
                        .HasColumnType("float");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Clients", (string)null);
                });

            modelBuilder.Entity("SkillSphere.Model.Db.Freelancer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double>("Earned")
                        .HasColumnType("float");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Freelancers", (string)null);
                });

            modelBuilder.Entity("SkillSphere.Model.Db.FreelancerJob", b =>
                {
                    b.Property<int>("FreelancerId")
                        .HasColumnType("int");

                    b.Property<int>("JobId")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("FreelancerId", "JobId");

                    b.HasIndex("JobId");

                    b.ToTable("FreelancerJobs");
                });

            modelBuilder.Entity("SkillSphere.Model.Db.Job", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.ToTable("Jobs");
                });

            modelBuilder.Entity("SkillSphere.Model.Db.Message", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ChatClientId")
                        .HasColumnType("int");

                    b.Property<int>("ChatFreelancerId")
                        .HasColumnType("int");

                    b.Property<int>("ChatId")
                        .HasColumnType("int");

                    b.Property<int>("ChatJobId")
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ReceiverId")
                        .HasColumnType("int");

                    b.Property<int>("SenderId")
                        .HasColumnType("int");

                    b.Property<DateTime>("SentAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ReceiverId");

                    b.HasIndex("SenderId");

                    b.HasIndex("ChatJobId", "ChatClientId", "ChatFreelancerId");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("SkillSphere.Model.Db.Rating", b =>
                {
                    b.Property<int>("JobId")
                        .HasColumnType("int");

                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<int>("FreelancerId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsFreelancerRated")
                        .HasColumnType("bit");

                    b.Property<double>("Value")
                        .HasColumnType("float");

                    b.HasKey("JobId", "ClientId", "FreelancerId");

                    b.HasIndex("ClientId");

                    b.HasIndex("FreelancerId");

                    b.ToTable("Ratings");
                });

            modelBuilder.Entity("SkillSphere.Model.Db.Skill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("JobId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.HasIndex("JobId");

                    b.ToTable("Skills");
                });

            modelBuilder.Entity("SkillSphere.Model.Db.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("SkillSphere.Model.Db.Chat", b =>
                {
                    b.HasOne("SkillSphere.Model.Db.Client", "Client")
                        .WithMany("Chats")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("SkillSphere.Model.Db.Freelancer", "Freelancer")
                        .WithMany("Chats")
                        .HasForeignKey("FreelancerId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("SkillSphere.Model.Db.Job", "Job")
                        .WithMany("Chats")
                        .HasForeignKey("JobId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Client");

                    b.Navigation("Freelancer");

                    b.Navigation("Job");
                });

            modelBuilder.Entity("SkillSphere.Model.Db.Client", b =>
                {
                    b.HasOne("SkillSphere.Model.Db.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("SkillSphere.Model.Db.Freelancer", b =>
                {
                    b.HasOne("SkillSphere.Model.Db.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("SkillSphere.Model.Db.FreelancerJob", b =>
                {
                    b.HasOne("SkillSphere.Model.Db.Freelancer", "Freelancer")
                        .WithMany("Jobs")
                        .HasForeignKey("FreelancerId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("SkillSphere.Model.Db.Job", "Job")
                        .WithMany("FreelancerJobs")
                        .HasForeignKey("JobId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Freelancer");

                    b.Navigation("Job");
                });

            modelBuilder.Entity("SkillSphere.Model.Db.Job", b =>
                {
                    b.HasOne("SkillSphere.Model.Db.Client", "Client")
                        .WithMany("Jobs")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");
                });

            modelBuilder.Entity("SkillSphere.Model.Db.Message", b =>
                {
                    b.HasOne("SkillSphere.Model.Db.User", null)
                        .WithMany("Messages")
                        .HasForeignKey("ReceiverId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("SkillSphere.Model.Db.User", null)
                        .WithMany()
                        .HasForeignKey("SenderId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("SkillSphere.Model.Db.Chat", "Chat")
                        .WithMany("Messages")
                        .HasForeignKey("ChatJobId", "ChatClientId", "ChatFreelancerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Chat");
                });

            modelBuilder.Entity("SkillSphere.Model.Db.Rating", b =>
                {
                    b.HasOne("SkillSphere.Model.Db.Client", "Client")
                        .WithMany("Ratings")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("SkillSphere.Model.Db.Freelancer", "Freelancer")
                        .WithMany("Ratings")
                        .HasForeignKey("FreelancerId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("SkillSphere.Model.Db.Job", "Job")
                        .WithMany("Ratings")
                        .HasForeignKey("JobId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Client");

                    b.Navigation("Freelancer");

                    b.Navigation("Job");
                });

            modelBuilder.Entity("SkillSphere.Model.Db.Skill", b =>
                {
                    b.HasOne("SkillSphere.Model.Db.Job", null)
                        .WithMany("Skills")
                        .HasForeignKey("JobId");
                });

            modelBuilder.Entity("SkillSphere.Model.Db.Chat", b =>
                {
                    b.Navigation("Messages");
                });

            modelBuilder.Entity("SkillSphere.Model.Db.Client", b =>
                {
                    b.Navigation("Chats");

                    b.Navigation("Jobs");

                    b.Navigation("Ratings");
                });

            modelBuilder.Entity("SkillSphere.Model.Db.Freelancer", b =>
                {
                    b.Navigation("Chats");

                    b.Navigation("Jobs");

                    b.Navigation("Ratings");
                });

            modelBuilder.Entity("SkillSphere.Model.Db.Job", b =>
                {
                    b.Navigation("Chats");

                    b.Navigation("FreelancerJobs");

                    b.Navigation("Ratings");

                    b.Navigation("Skills");
                });

            modelBuilder.Entity("SkillSphere.Model.Db.User", b =>
                {
                    b.Navigation("Messages");
                });
#pragma warning restore 612, 618
        }
    }
}
