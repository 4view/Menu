using System.Reflection.Metadata;

namespace Menu.Model;

class Dish
{
    public Dish (int type, string name, DateTime lastPreparation)
    {
        Type = type;
        Name = name.Trim();
        LastPreparation = lastPreparation;
    }

    public int Type { get; }

    public string Name { get; }

    public DateTime LastPreparation { get; }
}