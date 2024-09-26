using Menu.Model;

/// <summary>
/// Class that select random dishes from filtered list
/// </summary>
class RandomDishes
{
    public string PickRandom(List<Dish> dishes)
    {
        Random rnd = new Random();

        int randomIndex = rnd.Next(dishes.Count);
        string randomItem = dishes[randomIndex].Name;

        return randomItem;
    }
}