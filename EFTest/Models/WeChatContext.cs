using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EFTest.Models
{
    public partial class WeChatContext : DbContext
    {
        public WeChatContext()
        {
        }

        public WeChatContext(DbContextOptions<WeChatContext> options)
            : base(options)
        {
        }

        public virtual DbSet<UserInfo> UserInfo { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=WeChat;User ID=sa;Password=niewei");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserInfo>(entity =>
            {
                entity.Property(e => e.PassWord)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sex)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.UserLoginName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });
        }
    }
}
