namespace Generic;

public class GenericRepository<T> : IRepository<T> where T : Entity
{
  private readonly List<T> items = [];

  public void Add(T item)
  {
    items.Add(item);
  }

  public void Remove(T item)
  {
    items.Remove(item);
  }

  public void Save()
  {
    Console.WriteLine("Saving data:");
    foreach (T item in items)
    {
      Console.WriteLine($"ID: {item.Id}");
    }
  }

  public IEnumerable<T> GetAll()
  {
    return items;
  }

  public T GetById(int id)
  {
    return items.FirstOrDefault(item => item.Id == id);
  }
}


