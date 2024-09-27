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

        bool foundDishes = false;

        while (!foundDishes)
        {
            Console.Write("Введите число от скольки дней блюдо подходит к фильтрации: ");
            if (int.TryParse(Console.ReadLine(), out int userDays))
            {
                //Создаем экземпляр класса DishFactory и записываем все обхекты в переменную dishes
                DishFactory dishFactory = new DishFactory();
                var dishes = dishFactory.CreateDish(lines);

                //Создаем переменную по которой определяем от какого числа мы можем рекомендовать блюдо
                var maxDate = DateTime.Now.AddDays(-userDays);
                List<Dish> dateFilteredDishes = dishes.Where(d => d.LastPreparation < maxDate).ToList();

                if (dateFilteredDishes.Any())
                {
                    Console.Write("Введите тип блюда (1/2): ");
                    if (int.TryParse(Console.ReadLine(), out int userType))
                    {
                        foundDishes = true;

                        SortFactory sorter = new SortFactory();
                        var sorterType = sorter.CreateSorter((SortBy)userType);

                        SortContext sortBy = new SortContext();
                        var resultDishes = sortBy.SortUsing(sorterType, dateFilteredDishes);

                        foreach (var item in resultDishes)
                        {
                            Console.WriteLine(item.Type + item.Name + item.LastPreparation.ToString("dd/MM/yyyy"));
                        }

                        RandomDishes myRandomDish = new RandomDishes();
                        string randomItem = myRandomDish.PickRandom(resultDishes);        

                        Console.WriteLine($"Случайное блюдо:{randomItem}");
                    }
                    else
                    {
                        Console.WriteLine($"Нет {userType} блюд. Попробуйте еще раз!");
                    }                    
                }
                else
                {
                    Console.WriteLine($"Блюд, приготовленных {userDays} назад не найдено! Попробуйте снова!\n");
                }
            }
            else
            {
                Console.WriteLine("Ошибка ввода! Введите корректное число");
            }
        } 
    }   
}