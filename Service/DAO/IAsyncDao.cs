using System.Threading.Tasks;

namespace tetofo.Service.DAO;

/// <summary>
/// Basic DAO definition.
/// Using R as object to store.
/// Using S as identification object to restore.
/// </summary>
public interface IAsyncDAO<R,S> {
    Task DeleteAsync(S s);
    Task<R> GetAsync(S s);
    Task<IList<R>> GetAllAsync();
    Task SaveAsync(R r);
    Task UpdateAsync(R r, S s);
}