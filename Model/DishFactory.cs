using Menu.Model;

class DishFactory
{
    public List<Dish> CreateDish(List<string> lines)
    {
        List<Dish> dishes = new List<Dish>();

        foreach (string line in lines)
        {
            string[] item = line.Split("-");
            Dish dish = new Dish(item[0], DateTime.Parse(item[1]));
            dishes.Add(dish);
        }

        return dishes;
    }
}