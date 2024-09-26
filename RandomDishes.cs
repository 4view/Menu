using Menu.Model;

class RandomDishes
{
    public string DishRandom(List<Dish> dishes)
    {
        //Создаем экземпляр класса Random
        Random rnd = new Random();

        int randomIndex = rnd.Next(dishes.Count);
        string randomItem = dishes[randomIndex].Name;

        return randomItem;
    }
}