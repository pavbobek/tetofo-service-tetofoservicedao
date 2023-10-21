using System.Threading.Tasks;

namespace tetofo.Service.DAO;

/// <summary>
/// Basic DAO definition.
/// Using R as object to store.
/// Using S as identification object to restore.
/// </summary>
public interface IAsyncDAO<R,S> {
    Task Delete(S s);
    Task<R> Get (S s);
    Task<IList<R>> GetAll();
    Task Update(R r, S s);
}