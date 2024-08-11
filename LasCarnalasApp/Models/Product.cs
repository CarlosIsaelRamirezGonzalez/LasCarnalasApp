namespace LasCarnalasApp.Models;
using SQLite;


[Table("Products")]
internal class Product : BaseEntity
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public byte[] Image { get; set; }
    public float Cost { get; set; }
    public float PublicPrice { get; set; }
}
