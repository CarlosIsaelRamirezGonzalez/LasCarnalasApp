namespace LasCarnalasApp.Models;
using SQLite;


[Table("Clients")]
internal class Client : BaseEntity
{
    public int Id { get; set; }

    [NotNull, MaxLength(100)]
    public string Description { get; set; }

    [NotNull]
    public int RestaurantTableId { get; set; }

    [Ignore]
    public RestaurantTable RestaurantTable { get; set; }
}
