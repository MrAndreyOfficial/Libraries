namespace EList;

public static class ListExtensions
{
    /// <summary>
    /// Remove all duplicate elements
    /// </summary>
    /// <exception cref="ArgumentOutOfRangeException">Throws if list is empty</exception>
    /// <returns>New list with unique elements</returns>
    public static List<T> RemoveDuplicate<T>(this IList<T> elements)
    {
        if (elements.Count < 1 || elements == null)
            throw new ArgumentOutOfRangeException(nameof(elements), "List is empty");

        var list = new List<T>();

        foreach (var element in elements)
        {
            if (list.Contains(element))
                continue;

            list.Add(element);
        }

        return list;
    }

    /// <summary>
    /// Remove all elements until element is found
    /// </summary>
    /// <exception cref="ArgumentOutOfRangeException">Throws if list is empty</exception>
    /// <exception cref="ArgumentNullException">Throws if item is null</exception>
    /// <returns>New list with unique elements</returns>
    public static void RemoveUntil<T>(this IList<T> elements, T item)
    {
        if (elements.Count < 1)
            throw new ArgumentOutOfRangeException(nameof(elements), "List is empty");

        if (item == null)
            throw new ArgumentOutOfRangeException(nameof(item), "Item is null");

        var tempList = new List<T>(elements);

        foreach (var element in tempList)
        {
            if (item.Equals(element))
                break;

            elements.Remove(element);
        }
    }

    /// <summary>
    /// Adds an element to the end of the list
    /// </summary>
    public static void Push<T>(this IList<T> list, T item) => list.Add(item);

    /// <summary>
    /// Removes the last element
    /// </summary>
    public static void Pop<T>(this IList<T> list) => list.RemoveAt(list.Count - 1);
}
