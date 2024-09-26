using Menu.Model;
using Menu.Sorting;

namespace Menu.Sorting;
/// <summary>
/// Class that sort collection by second dish
/// </summary>
public class SecondDishSorter : IDishSorter
{
    public List<Dish> Sort(List<Dish> dishes) =>
        dishes.Where(d => d.Type != 1).ToList();
}