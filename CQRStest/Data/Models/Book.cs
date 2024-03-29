namespace CQRStest.Data.Models;

public class Book : IEntity
{
    public Guid Id { get; set; }
    public DateTime PublicationDate { get; set; }
    public decimal Price { get; set; }
    public required string Title { get; set; }
    public int Pages { get; set; }
    public required Author Author { get; set; }
}