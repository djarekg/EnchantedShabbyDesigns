using Microsoft.EntityFrameworkCore;

namespace Esd.Database.UnitOfWork;

public sealed class UnitOfWork<TDbContext> : IUnitOfWork where TDbContext : DbContext
{
    private readonly TDbContext _context;

    public UnitOfWork(TDbContext context)
    {
        _context = context;
    }

    public Task<int> SaveChangesAsync()
    {
        return _context.SaveChangesAsync();
    }
}
