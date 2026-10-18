namespace Generics.Src;

public static class EnumerableExtensions
{
    
    public static IEnumerable<T> Page<T>(this IEnumerable<T> source, int pageNumber, int pageSize)
    {
        if (source == null) throw new ArgumentNullException(nameof(source));
        if (pageNumber < 1) throw new ArgumentOutOfRangeException(nameof(pageNumber), "Page number must be >= 1.");
        if (pageSize < 1) throw new ArgumentOutOfRangeException(nameof(pageSize), "Page size must be >= 1.");

        int skipCount = (pageNumber - 1) * pageSize;
        int current = 0;
        int yielded = 0;

        foreach (var item in source)
        {
            if (current >= skipCount && yielded < pageSize)
            {
                yield return item;
                yielded++;
            }
            current++;
            if (yielded == pageSize) break;
        }
    }

    
    public static T? FindById<T>(this IEnumerable<T> source, int id) where T : IHasId
    {
        if (source == null) throw new ArgumentNullException(nameof(source));

        foreach (var item in source)
        {
            if (item.Id == id) return item;
        }

        return default;
    }

    
    public static IReadOnlyDictionary<int, T> ToIDictionary<T>(this IEnumerable<T> source) where T : IHasId
    {
        if (source == null) throw new ArgumentNullException(nameof(source));

        var dict = new Dictionary<int, T>();
        foreach (var item in source)
        {
            dict.Add(item.Id, item);
        }

        return dict;
    }
}