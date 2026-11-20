using Microsoft.EntityFrameworkCore;

public class Day6_NguyenThuyQuynhContext(DbContextOptions<Day6_NguyenThuyQuynhContext> options) : DbContext(options)
{
    public DbSet<Day6_NguyenThuyQuynh.Models.Product> Product { get; set; } = default!;
    public DbSet<Day6_NguyenThuyQuynh.Models.Grenre> Grenres { get; set; } = default!;
    public DbSet<Day6_NguyenThuyQuynh.Models.Movie> Movie { get; set; } = default!;
}
