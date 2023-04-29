using Microsoft.EntityFrameworkCore;

namespace DeskUniverse_Backend.Models;

public class DeskUniDB : DbContext
{
    public DeskUniDB (DbContextOptions<DeskUniDB> options) : base(options){}

    public DbSet<User> Users { get; set; }
    public DbSet<Character> Characters { get; set; }
    public DbSet<Skill> Skills { get; set; }
    public DbSet<Item> Itens { get; set; }
    public DbSet<Campaign> Campaigns { get; set; }
    public DbSet<Image> Images { get; set; }
    public DbSet<Token> Tokens { get; set; }
    public DbSet<Board> Boards { get; set; }
}