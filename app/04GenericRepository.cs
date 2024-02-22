
namespace app1;
public interface IRepository<T> where T : IEntity
{
    void Add(T item);
    void Remove(T item);
    void Save();
    IEnumerable<T> GetAll();
    T GetById(int id);
}

public interface IEntity
{
    int Id { get; set; }
}

public class GenericRepository<T> : IRepository<T> where T : class, IEntity
{
    private List<T> dataSource = new List<T>();

    public void Add(T item)
    {
        dataSource.Add(item);
    }

    public void Remove(T item)
    {
        dataSource.Remove(item);
    }

    public void Save()
    {
        Console.WriteLine("Changes saved successfully.");
    }

    public IEnumerable<T> GetAll()
    {
        return dataSource;
    }

    public T GetById(int id)
    {
        return dataSource.FirstOrDefault(item => item.Id == id);
    }
}

public class Entity : IEntity
{
    public int Id { get; set; }
}