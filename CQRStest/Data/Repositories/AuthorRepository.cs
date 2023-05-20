using CQRStest.Data.Models;
using CQRStest.Data.Repositories.interfaces;

namespace CQRStest.Data.Repositories;

public class AuthorRepository : GenericRepository<Author>, IAuthorRepository
{
    public AuthorRepository(Context dbContext) : base(dbContext)
    {
    }
}