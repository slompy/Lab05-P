
int dayNumber = 6;

switch (dayNumber) {
    case >= 5 and <= 7: Console.WriteLine("Выходной"); break;
    default: Console.WriteLine("Будний"); break;
}

Console.WriteLine();

int score = 101;

switch (score) {
    case >= 0 and < 40:
        Console.WriteLine("Неудовлетворительно");
        break;
    case >= 40 and < 60:
        Console.WriteLine("Удовлетворительно");
        break;
    case >= 60 and < 80:
        Console.WriteLine("Хорошо");
        break;
    case >= 80 and <= 100:
        Console.WriteLine("Отлично");
        break;
    default:
        Console.WriteLine("Некорректный балл");
        break;
}

