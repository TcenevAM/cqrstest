namespace CQRStest.Data.Dtos.PostDtos;

public class AuthorPostDto
{
    public required string FirstName { get; set; }
    public required string SecondName { get; set; }
    public string? Patronymic { get; set; }
}