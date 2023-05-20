using CQRStest.Data.Models;
using CQRStest.Data.Repositories.interfaces;

namespace CQRStest.Data.Repositories;

public class LibraryRepository : GenericRepository<Library>, ILibraryRepository
{
    public LibraryRepository(Context dbContext) : base(dbContext)
    {
    }
}