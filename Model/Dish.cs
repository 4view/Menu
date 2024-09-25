namespace Menu.Model;

class Dish
{
    public Dish (string name, DateTime lastPreparation)
    {
        Name = name;
        LastPreparation = lastPreparation;
    }

    public string Name { get; }

    public DateTime LastPreparation { get; }
}