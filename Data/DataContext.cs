namespace Rest_Demo.Data
{
    public class DataContext : DbContext
    {
        //protected readonly IConfiguration Configuration;
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }
        //public DataContext(IConfiguration configuration)
        //{
        //    Configuration = configuration;
        //}

        //protected override void OnConfiguring(DbContextOptionsBuilder options)
        //{
        //    // connect to postgres with connection string from app settings
        //    options.UseNpgsql(Configuration.GetConnectionString("WebApiDatabase"));
        //}

        public DbSet<Character> Characters { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Character>().ToTable("Character");
        }
    }
}

