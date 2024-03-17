using System;
using Microsoft.EntityFrameworkCore;
using SkillSphere.Model.Db;

namespace SkillSphere.Data
{
	public class AppDbContext: DbContext
	{

		public DbSet<Freelancer> Freelancers { get; set; }

        public DbSet<Client> Clients { get; set; }

		public DbSet<Job> Jobs { get; set; }

		public DbSet<FreelancerJob> FreelancerJobs { get; set; }

        public DbSet<Message> Messages { get; set; }

        public DbSet<Chat> Chats { get; set; }

        public DbSet<Rating> Ratings { get; set; }

        public DbSet<Skill> Skills { get; set; }

        public DbSet<User> Users { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
		{

		}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Freelancer>()
                .ToTable("Freelancers");

            modelBuilder
                .Entity<Client>()
                .ToTable("Clients");

            modelBuilder
                .Entity<FreelancerJob>()
                .HasKey(e => new { e.FreelancerId, e.JobId });

            modelBuilder
                .Entity<Message>()
                .HasOne<User>()
                .WithMany()
                .HasForeignKey(e => e.SenderId);

            modelBuilder
                .Entity<Chat>()
                .HasKey(e => new { e.JobId, e.ClientId, e.FreelancerId });

            modelBuilder
              .Entity<Message>()
              .HasOne<User>()
              .WithMany()
              .HasForeignKey(e => e.ReceiverId);

            modelBuilder
                .Entity<Rating>()
                .HasKey(e => new { e.JobId, e.ClientId, e.FreelancerId });

            DisableCascadeDeletes(modelBuilder);

        }

        private void DisableCascadeDeletes(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Chat>()
                .HasOne(chat => chat.Freelancer)
                .WithMany(freelancer => freelancer.Chats)
                .HasForeignKey(chat => chat.FreelancerId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Chat>()
                .HasOne(chat => chat.Client)
                .WithMany(client => client.Chats)
                .HasForeignKey(chat => chat.ClientId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Chat>()
                .HasOne(chat => chat.Job)
                .WithMany(job => job.Chats)
                .HasForeignKey(chat => chat.JobId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<FreelancerJob>()
                .HasOne(e => e.Job)
                .WithMany(e => e.FreelancerJobs)
                .HasForeignKey(e => e.JobId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<FreelancerJob>()
                .HasOne(e => e.Freelancer)
                .WithMany(e => e.Jobs)
                .HasForeignKey(e => e.FreelancerId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder
                .Entity<Rating>()
                .HasOne(e => e.Freelancer)
                .WithMany(e => e.Ratings)
                .HasForeignKey(e => e.FreelancerId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder
                .Entity<Rating>()
                .HasOne(e => e.Client)
                .WithMany(e => e.Ratings)
                .HasForeignKey(e => e.ClientId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder
                .Entity<Rating>()
                .HasOne(e => e.Job)
                .WithMany(e => e.Ratings)
                .HasForeignKey(e => e.JobId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Message>()
                .HasOne<User>()
                .WithMany()
                .HasForeignKey(e => e.SenderId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Message>()
              .HasOne<User>()
              .WithMany(e => e.Messages)
              .HasForeignKey(e => e.ReceiverId)
              .OnDelete(DeleteBehavior.Restrict);


        }
    }
}

