public class Paginator<TEntity>
{
    public int PageSize { get; set; }
    public int PageCount { get; set;}
    public int PageOffset { get; set;}
    public int TotalItems { get; set; }
    public virtual List<TEntity> Items { get; set; }

    public Paginator(List<TEntity> items, int pageSize, int pageOffset)
    {
        TotalItems = items.Count;
        PageSize = pageSize;
        PageOffset = pageOffset;
        PageCount = (int)Math.Ceiling((double)items.Count / pageSize);
        Items = items.Skip(pageOffset * pageSize).Take(pageSize).ToList();
    }
}