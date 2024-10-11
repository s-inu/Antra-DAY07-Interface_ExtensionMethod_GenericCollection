namespace Generic;

public class MyStack<T>
{
  private List<T> elements = [];

  public int Count()
  {
    return elements.Count;
  }

  public T Pop()
  {
    if (elements.Count == 0)
    {
      throw new InvalidOperationException("Stack is empty");
    }
    T item = elements[^1];
    elements.RemoveAt(elements.Count - 1);
    return item;
  }

  public void Push(T item)
  {
    elements.Add(item);
  }
}
