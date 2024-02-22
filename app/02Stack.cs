namespace app1;
public class MyStack<T>
{
    private List<T> items = new List<T>();
    public int Count()
    {
        return items.Count;
    }
    public T Pop()
    {
        T result = items[items.Count - 1];
        items.RemoveAt(items.Count - 1);
        return result;
    }
    public void Push(T item)
    {
        items.Add(item);
    }
}