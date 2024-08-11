namespace LasCarnalasApp.Models;
using SQLite;

internal class BaseEntity
{
    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }
}
