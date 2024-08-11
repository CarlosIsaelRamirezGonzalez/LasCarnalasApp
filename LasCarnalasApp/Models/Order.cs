namespace LasCarnalasApp.Models;
using SQLite;
using System.ComponentModel.DataAnnotations.Schema;

[Table("Orders")]
internal class Order : BaseEntity
{
    public int Id { get; set; }
    public string Recomendation { get; set; }
    [NotNull]
    public Int16 Quantity { get; set; }
    [NotNull]
    public DateTime Date { get; set; }
    public int ProductId { get; set; }
    
}
