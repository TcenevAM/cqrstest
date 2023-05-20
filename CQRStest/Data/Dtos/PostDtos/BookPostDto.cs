namespace CQRStest.Data.Dtos.PostDtos;

public class BookPostDto
{
    public DateTime PublicationDate { get; set; }
    public decimal Price { get; set; }
    public required string Title { get; set; }
    public int Pages { get; set; }
    public required Guid AuthorId { get; set; }
}