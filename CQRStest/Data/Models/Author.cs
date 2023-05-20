namespace CQRStest.Data.Models;

public class Author : IEntity
{
    public Guid Id { get; set; }
    public string FullName
    {
        get
        {
            var result = $"{FirstName} {SecondName}";
            if (Patronymic != null) result += $" {Patronymic}";
            return result;
        }
    }

    public required string FirstName { get; set; }
    public required string SecondName { get; set; }
    public string? Patronymic { get; set; }
    public List<Book> Books { get; set; } = new List<Book>();
}