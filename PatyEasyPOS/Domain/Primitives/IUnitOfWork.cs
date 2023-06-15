namespace Domain.Primitives;

public interface IunitOfwokr
{
    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}