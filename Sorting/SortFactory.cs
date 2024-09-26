namespace Menu.Sorting;

/// <summary>
/// Class that create sorter based on user choice
/// </summary>
class SortFactory
{
    public IDishSorter CreateSorter(SortBy sortBy)
    {
        switch(sortBy)
        {
            case SortBy.firstDish:
                return new FirstDishSorter();
            case SortBy.secondDish:
                return new SecondDishSorter();
            case SortBy.desert:
                return null;
            default:
                throw new InvalidOperationException("There no such sorter!");
        }
    }
}