namespace CQRStest.Data.Dtos.GetDtos;

public class BookGetDto
{
    public Guid Id { get; set; }
    public DateTime PublicationDate { get; set; }
    public decimal Price { get; set; }
    public required string Title { get; set; }
    public int Pages { get; set; }
    public required Guid AuthorId { get; set; }
}