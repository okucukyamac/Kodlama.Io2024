using Entities.Abstract;


namespace DataAccess.Abstract;

public interface IEntityRepository<T> where T : class, IEntity, new()
{
    List<T> GetAll();
    T Get(int id);
    void Add(T entity);
    void Update(T entity);
    void Delete(T entity);
}
