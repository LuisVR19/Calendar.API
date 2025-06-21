using Microsoft.EntityFrameworkCore;

namespace Calendar.Data.Models
{
    public class CalendarDBContext : DbContext
    {
        public CalendarDBContext()
        {
        }

        public CalendarDBContext(DbContextOptions<CalendarDBContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Priority> Priorities { get; set; }
        public DbSet<Assigment> Assigments { get; set; }
        public DbSet<AssigmentRecord> AssigmentRecords { get; set; }
        public DbSet<WeekDay> WeekDays { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>()
                .HasIndex(u => u.Email)
                .IsUnique();

            modelBuilder.Entity<Priority>()
                .HasIndex(u => u.PriorityNumber)
                .IsUnique();

            modelBuilder.Entity<WeekDay>()
                .HasIndex(u => u.Day)
                .IsUnique();
        }
    }
}
