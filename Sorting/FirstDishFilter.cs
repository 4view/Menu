using Menu.Model;
using Menu.Sorting;

namespace Menu.Sorting;

/// <summary>
/// Class that sort collection by first dish
/// </summary>
public class FirstDishFilter : IDishSorter
{
    public List<Dish> Sort(List<Dish> dishes) =>
        dishes.Where(d => d.Type != 2).ToList();
}