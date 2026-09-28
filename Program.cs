
// int dayNumber = 6;

// switch (dayNumber) {
//     case >= 5 and <= 7: Console.WriteLine("Выходной"); break;
//     default: Console.WriteLine("Будний"); break;
// }

// Console.WriteLine();

// int score = 101;

// switch (score) {
//     case >= 0 and < 40:
//         Console.WriteLine("Неудовлетворительно");
//         break;
//     case >= 40 and < 60:
//         Console.WriteLine("Удовлетворительно");
//         break;
//     case >= 60 and < 80:
//         Console.WriteLine("Хорошо");
//         break;
//     case >= 80 and <= 100:
//         Console.WriteLine("Отлично");
//         break;
//     default:
//         Console.WriteLine("Некорректный балл");
//         break;
// }

// Console.WriteLine();

// int score1 = 14;

// string result = score1 switch {
//     >= 35 => "Очень жарко",
//     >= 25 => "Жарко",
//     >= 15 => "Комфортно",
//     >= 0 => "Мороз",
//     _ => "Некорректная температура"    
// };

// Console.WriteLine(result);

Console.WriteLine();

string role = "admin";

string result1 = role switch {
    "admin" => "Доступ преподавателя",
    "teacher" => "Доступ преподавателя",
    not "teacher" => "Ограниченный доступ"
};

Console.WriteLine(result1);


Console.WriteLine();


int age = 20;
bool hasTicket = true;

switch (age) {
    case >= 18 when hasTicket:
        Console.WriteLine("Вход разрешён");
        break;
    case >= 18:
        Console.WriteLine("Нет билета");
        break;
    default:
        Console.WriteLine("Возраст не подходит");
        break;
}