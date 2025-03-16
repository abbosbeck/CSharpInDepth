namespace AspDotNetInDepth.Models
{
    public record class Game
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
    }
}
