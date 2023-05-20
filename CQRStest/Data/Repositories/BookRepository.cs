using CQRStest.Data.Models;
using CQRStest.Data.Repositories.interfaces;

namespace CQRStest.Data.Repositories;

public class BookRepository : GenericRepository<Book>, IBookRepository
{
    public BookRepository(Context dbContext) : base(dbContext)
    {
    }
}