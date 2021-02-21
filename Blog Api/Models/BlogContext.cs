using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog_Api.Models
{
    public class BlogContext : DbContext
    {
        public BlogContext(DbContextOptions<BlogContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<BlogPost> BlogPosts { get; set; }
    }
}
