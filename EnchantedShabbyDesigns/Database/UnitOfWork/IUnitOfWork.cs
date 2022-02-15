namespace Esd.Database.UnitOfWork;

public interface IUnitOfWork
{
    Task<int> SaveChangesAsync();
}
