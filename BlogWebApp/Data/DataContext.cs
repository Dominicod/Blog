using Microsoft.EntityFrameworkCore;

namespace BlogWebApp.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options) { }
}