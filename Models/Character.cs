namespace DeskUniverse_Backend.Models;

public class Character
{
    //Identificação do Personagem
    public int Id { get; set; }
    public int UserId { get; set; }
    public string Name { get; set; }
    public string? Race { get; set; }
    public string? Gender { get; set; }
    public string? Age { get; set; }
    public string? Class { get; set; }
    public string? History { get; set; }


    //Estatísticas do Personagem
    public int? Level { get; set; }
    public int? Health { get; set; }
    public int? Mana { get; set; }
    public int? STR { get; set; }
    public int? DEX { get; set; }
    public int? CON { get; set; }
    public int? INT { get; set; }
    public int? WIS { get; set; }
    public int? WIL { get; set; }
    public int? PD { get; set; }
    public int? MD { get; set; }
}