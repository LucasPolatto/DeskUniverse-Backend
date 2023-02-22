using Microsoft.EntityFrameworkCore;

namespace DeskUniverse_Backend.Models;

public class DeskUniDB : DbContext
{
    public DeskUniDB (DbContextOptions<DeskUniDB> options) : base(options){}

    public DbSet<User> Users { get; set; }
    public DbSet<Character> Characters { get; set; }
    //public DbSet<> ... { get; set; }
}