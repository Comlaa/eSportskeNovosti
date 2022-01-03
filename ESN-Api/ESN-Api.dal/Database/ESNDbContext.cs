using ESN_Api.Configuration;
using ESN_Api.ESN_Api.dal.Domain;
using Microsoft.EntityFrameworkCore;

namespace ESN_Api.ESN_Api.dal.Database
{
    public class ESNDbContext : DbContext
    {
        public DbSet<Article> Articles { get; set; }
        public DbSet<ArticleComment> ArticleComments { get; set; }
        public DbSet<ArticleRating> ArticleRatings { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Favourite> Favourites { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<SavedArticle> SavedArticles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }



        public ESNDbContext(DbContextOptions<ESNDbContext> options) : base(options) { }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(UserRoleConfiguration).Assembly);
            base.OnModelCreating(modelBuilder);
        }

    }
    
}
