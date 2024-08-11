namespace LasCarnalasApp.Models;
using SQLite;

[Table("RestaurantTable")]
internal class RestaurantTable : BaseEntity
{
    public int Id { get; set; }
    
    [NotNull, MaxLength(15)]
    public string Name { get; set; }
}
