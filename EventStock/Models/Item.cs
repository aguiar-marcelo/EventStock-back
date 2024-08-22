namespace EventStock.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Desc { get; set; }
        public int Quantity { get; set; }
        public bool Available { get; set; }
        public string? Img { get; set; }

    }
}
