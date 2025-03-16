namespace EList;

public static class ListExtensions
{
    /// <summary>
    /// Remove all duplicate elements
    /// </summary>
    /// <exception cref="ArgumentOutOfRangeException">Throws if count is less than 0</exception>
    /// <exception cref="ArgumentNullException">Throws if list is empty</exception>
    /// <returns>New list with unique elements</returns>
    public static List<T> RemoveDuplicate<T>(this IList<T> elements)
    {
        if (elements.Count < 1 || elements == null)
            throw new ArgumentOutOfRangeException(nameof(elements.Count), "List is empty");

        if (elements == null)
            throw new ArgumentNullException(nameof(elements), "List is null");

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
    /// Remove all elements until element (exclusive)
    /// Working with current list
    /// </summary>
    /// <exception cref="ArgumentOutOfRangeException">Throws if list is empty</exception>
    /// <exception cref="ArgumentNullException">Throws if item is null</exception>
    public static void RemoveUntil<T>(this IList<T> elements, T item)
    {
        if (elements.Count < 1)
            throw new ArgumentOutOfRangeException(nameof(elements), "List is empty");

        if (item == null)
            throw new ArgumentNullException(nameof(item), "Item is null");

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
    /// <exception cref="ArgumentNullException">Throws if item is null</exception>
    /// </summary>
    public static void Push<T>(this IList<T> list, T item)
    {
        if (list == null)
            throw new ArgumentNullException(nameof(item), "Item is null");

        list.Add(item);
    }

    /// <summary>
    /// Removes the last element
    /// <exception cref="ArgumentNullException">Throws if item is null</exception>
    /// </summary>
    public static void Pop<T>(this IList<T> list)
    {
        if (list == null)
            throw new ArgumentNullException(nameof(list), "Item is null");

        list.RemoveAt(list.Count - 1);
    }
}
