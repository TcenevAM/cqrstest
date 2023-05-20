namespace CQRStest.Data.Dtos.GetDtos;

public class LibraryGetDto
{
    public Guid Id { get; set; }
    public required string Address { get; set; }
    public List<Guid> AuthorsIds { get; set; } = new List<Guid>();
    public List<Guid> BooksIds { get; set; } = new List<Guid>();
}