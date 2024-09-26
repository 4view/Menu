using System.Diagnostics;
using Menu.Model;

namespace Menu.Sorting;

/// <summary>
/// Class that defines waht sort stratage will be used
/// </summary>
class SortContext
{
    public List<Dish> SortUsing(IDishSorter strategy, List<Dish> dishList)
    {
        return strategy.Sort(dishList);
    }
}