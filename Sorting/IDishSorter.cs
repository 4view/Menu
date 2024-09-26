using Menu.Model;

namespace Menu.Sorting;

public interface IDishSorter
{
    public List<Dish> Sort(List<Dish> dishes);
}