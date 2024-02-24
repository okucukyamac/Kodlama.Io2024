namespace Business.Abstract;

public interface IGenericService<T>
{
    List<T> GetAll();
    void Add(T t);
    void Update(T t);
    void Delete(T t);
}
