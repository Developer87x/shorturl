namespace ShortUrl.Domain.SharedKernel;

public interface IUnitOfWork{

    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    Task<bool> SaveEntitiesAsync(CancellationToken cancellationToken);
}

