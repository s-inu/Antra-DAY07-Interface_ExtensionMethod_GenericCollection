namespace Generic;

public class MyList<T>
{
  private List<T> elements = new List<T>();

  public void Add(T element)
  {
    elements.Add(element);
  }

  // Removes the element at the specified index and returns it
  public T Remove(int index)
  {
    T item = elements[index];
    elements.RemoveAt(index);
    return item;
  }

  public bool Contains(T element)
  {
    return elements.Contains(element);
  }

  // Clears all elements from the list
  public void Clear()
  {
    elements.Clear();
  }

  // Inserts an element at the specified index
  public void InsertAt(T element, int index)
  {
    elements.Insert(index, element);
  }

  public void DeleteAt(int index)
  {
    elements.RemoveAt(index);
  }

  public T Find(int index)
  {
    return elements[index];
  }
}

