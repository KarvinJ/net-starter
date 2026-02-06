using Microsoft.EntityFrameworkCore;
using Starter.Models;

namespace Starter.Helpers;

public class DataContext(DbContextOptions<DataContext> options) : DbContext(options)
{
    public DbSet<Character> Characters { get; set; }
}