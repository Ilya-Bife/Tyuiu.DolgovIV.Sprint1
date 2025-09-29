using Tyuiu.DolgovIV.Sprint1.Task5.V1.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #1 | Выполнил: Долгов И. В. | АСОиУб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                               *");
        Console.WriteLine("* Тема: Преобразование типов и класс Convert                              *");
        Console.WriteLine("* Задание #5                                                              *");
        Console.WriteLine("* Вариант #1                                                              *");
        Console.WriteLine("* Выполнил: Долгов Илья Витальевич | АСОиУб-25-1                          *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая решает следующую задачу:                    *");
        Console.WriteLine("* Найти расстояние между двумя точками с заданными координатами (x, y).   *");
        Console.WriteLine("* Ответ привести к целому с помощью класса Convert.                       *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        double x1, y1, x2, y2;
        Console.WriteLine("Введите значение X1:");
        x1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите значение Y1:");
        y1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите значение X2:");
        x2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите значение Y2:");
        y2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine(Convert.ToInt32(ds.DistanceBetweenDots(x1, y1, x2, y2)));

        Console.ReadLine();
    }
}