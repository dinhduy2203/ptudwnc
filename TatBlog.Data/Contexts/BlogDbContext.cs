﻿using Microsoft.EntityFrameworkCore;
using TatBlog.Core.Entities;
using TatBlog.Data.Mappings;

namespace TatBlog.Data.Contexts
{
    public class BlogDbContext : DbContext
    {
        public DbSet<Author> Author { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Tag> Tags { get; set; }

        //public BlogDbContext(DbContextOptions<BlogDbContext> options)
        //    : base(options)
        //{

        //}

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.ApplyConfigurationsFromAssembly(
        //        typeof(CategoryMap).Assembly);
        //}

        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=MSI;Database=Tatblog;Trusted_Connection=True;MultipleActiveResultSets=True;Encrypt=False");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(
                typeof(CategoryMap).Assembly );
        }
    }
}
