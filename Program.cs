using System.ComponentModel.Design;
using System.Data.Common;
using Menu.Model;
using Menu.Storage;
using Menu.Sorting;

namespace Menu;

class Program
{
    static void Main (string[] args)
    {
        Console.InputEncoding = System.Text.Encoding.GetEncoding("utf-16");
        var path = @"C:\Users\User\Desktop\sharp\Menu.txt";     

        //Читаем данные с файла и записываем в переменную
        FileReader fileReade = new FileReader();
        List<string> lines = fileReade.ReadFile(path);

        Console.Write("Введите число от скольки дней блюдо подходит к фильтрации: ");
        var userDays = int.Parse(Console.ReadLine());

        Console.Write("Введите тип блюда (1/2): ");
        var userType = (SortBy)int.Parse(Console.ReadLine());

        //Создаем экземпляр класса DishFactory и записываем все обхекты в переменную dishes
        DishFactory dishFactory = new DishFactory();
        var dishes = dishFactory.CreateDish(lines);

        //Создаем переменную по которой определяем от какого числа мы можем рекомендовать блюдо
        var maxDate = DateTime.Now.AddDays(-userDays);
        List<Dish> dateFilteredDishes = dishes.Where(d => d.LastPreparation < maxDate).ToList();

        SortFactory sorter = new SortFactory();
        var sorterType = sorter.CreateSorter(userType);

        SortContext sortBy = new SortContext();
        var resultDishes = sortBy.SortUsing(sorterType, dateFilteredDishes);

        foreach (var item in resultDishes)
        {
            Console.WriteLine(item.Type + item.Name + item.LastPreparation);
        }

        RandomDishes myRandomDish = new RandomDishes();
        string randomItem = myRandomDish.DishRandom(resultDishes);        

        Console.WriteLine($"Случайное блюдо: {randomItem}");
    }   
}