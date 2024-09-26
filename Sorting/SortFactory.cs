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
            case SortBy.FirstDish:
                return new FirstDishFilter();
            case SortBy.SecondDish:
                return new SecondDishFilter();
            case SortBy.Dessert:
                return null;
            default:
                throw new InvalidOperationException("There no such dishes!");
        }
    }
}