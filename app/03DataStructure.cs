
namespace app1;
public class MyList<T>
{
    private List<T> items = new List<T>();
    public void Add(T element)
    {
        items.Add(element);
    }
    public void Remove(int index)
    {
        items.RemoveAt(index);
    }
    public int Count()
    {
        return items.Count;
    }

    public bool Contains(T element)
    {
        return items.Contains(element);
    }

    public void Clear()
    {
        items.Clear();
    }

    public void InsertAt(T element, int index)
    {
        items.Insert(index, element);
    }

    public void DeleteAt(int index)
    {
        items.RemoveAt(index);
    }

    public T Find(int index)
    {
        return items[index];
    }

    public void MyPrint()
    {
        string result = "";
        foreach (var item in items)
        {
            result += item + " ";
        }
        Console.WriteLine(result);
    }
}
