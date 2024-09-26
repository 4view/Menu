using Menu.Model;

/// <summary>
/// Class that create dishes and split by property
/// </summary>
class DishFactory
{
    public List<Dish> CreateDish(List<string> lines)
    {
        List<Dish> dishes = new List<Dish>();

        foreach (string line in lines)
        {
            string[] item = line.Split("-");
            Dish dish = new Dish(int.Parse(item[0]), item[1], DateTime.Parse(item[2]));
            dishes.Add(dish);
        }

        return dishes;
    }
}