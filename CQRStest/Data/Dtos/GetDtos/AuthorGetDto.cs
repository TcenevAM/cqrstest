namespace CQRStest.Data.Dtos.GetDtos;

public class AuthorGetDto
{
    public Guid Id { get; set; }
    public string FullName { get; set; }
    public List<Guid> BooksIds { get; set; } = new List<Guid>();
}