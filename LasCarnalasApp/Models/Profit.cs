namespace LasCarnalasApp.Models;
using SQLite;

[Table("Profits")]
internal class Profit : BaseEntity
{
    public int Id { get; set; }
    public float Amount { get; set; }
}
