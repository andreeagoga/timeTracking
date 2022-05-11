using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace timeTracking.Models
{
    public class TimeTrackingContext : DbContext
    {
        public TimeTrackingContext(DbContextOptions<TimeTrackingContext> options)
            : base(options)
        {
        }

        public DbSet<TimeTrackingItem> TimeTrackingItems { get; set; } = null!;
    }
}