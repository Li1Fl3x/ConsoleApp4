Console.Write("Введите номер параметров треугольника: ");
//1 a = 3 b = 3.5 c = -2.1 2 a = 21; b = -6.55; c = 0. 1 3 a = -9; b = -3.7; c = -0.1

int number = int.Parse(Console.ReadLine());
string numberzero = Console.ReadLine();


switch (number)

{

    case 1:

        Console.Write("a = 3 ");
        Console.Write("b = 3.5 ");
        Console.Write("c = -2.1 ");
        Console.WriteLine("Треугольник прямоугольный");
        break;


    case 2:
        Console.Write("a = 21 ");
        Console.Write("b = -6.55 ");
        Console.Write("c = 0.1 ");
        Console.WriteLine("Треугольник прямоугольный");

        break;


    case 3:
        Console.Write("a = -9 ");
        Console.Write("b = -3.7 ");
        Console.Write("c = -0.1 ");
        Console.WriteLine("Треугольник не прямоугольный");
        break;

    default:

        Console.WriteLine("Такого варианта нет.");

        break;

}

switch (numberzero)

{

    case "1":

        Console.Write("вариант 1");

        break;

    case "2":

        Console.Write("вариант 2");

        break;

    case "3":

        Console.Write("вариант 3");
        break;
}

