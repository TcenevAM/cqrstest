namespace CQRStest.Data.Dtos.PatchDtos;

public class BookPatchDto
{
    public Guid Id { get; set; }
    public DateTime PublicationDate { get; set; }
    public decimal Price { get; set; }
    public string? Title { get; set; }
    public int Pages { get; set; }
    public Guid AuthorId { get; set; }
}