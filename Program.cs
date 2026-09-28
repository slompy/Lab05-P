
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

// string role = "admin";

// string result1 = role switch {
//     "admin" => "Доступ преподавателя",
//     "teacher" => "Доступ преподавателя",
//     not "teacher" => "Ограниченный доступ"
// };

// Console.WriteLine(result1);


// Console.WriteLine();


// int age = 20;
// bool hasTicket = true;

// switch (age) {
//     case >= 18 when hasTicket:
//         Console.WriteLine("Вход разрешён");
//         break;
//     case >= 18:
//         Console.WriteLine("Нет билета");
//         break;
//     default:
//         Console.WriteLine("Возраст не подходит");
//         break;
// }

// int level = 2

// switch (level) {
//     case 1:
//         Console.WriteLine("Начальный уровень");
//         break;
//     case 2:
//         Console.WriteLine("Средний уровен");
//         goto case 1;
//     case 3:
//         Console.WriteLine("Продвинутый уровень");
//         break;
// }


// // Задача А. Время года

// Console.WriteLine();

// int score1 = 4;

// string result = score1 switch {
//     12 or 1 or 2 => "Зима",
//     3 or 4 or 5 => "Весна",
//     6 or 7 or 8 => "Лето",
//     9 or 10 or 11 => "Осень",
//     _ => "Неверный месяц"    
// };

// System.Console.WriteLine(result);

// // Задача Б. Категория возраста

// Console.WriteLine();

// int scoreAge = 42;

// string result5 = scoreAge switch {
//     < 0 => "Ошибка",
//     >= 0 and <= 6 => "Ребёнок",
//     >= 7 and <= 17 => "Подросток",
//     >= 18 and <= 64 => "Взрослый",
//     _ => "Пенсионер"    
// };

// Console.WriteLine(result5);

// Console.Write("Введите свою фамилию: ");
// string surname = Console.ReadLine()!.Trim();

// if (string.IsNullOrEmpty(surname)) {
//     Console.WriteLine("Фамилия не введена. Завершение работы.");
//     return;
// }

// Random rnd = new(surname.GetHashCode() + DateTime.Now.DayOfYear);

// var assigned = Enumerable.Range(1, 10)
//     .OrderBy(_ => rnd.Next())
//     .Take(2)
//     .OrderBy(x => x)
//     .ToList();

// Console.WriteLine($"Задачи: №{assigned[0]} и №{assigned[1]}");

// // Вариант 5. Рекомендация по температуре

// Console.Write("Введите температуру: ");
// int temperatura = int.Parse(Console.ReadLine()!);

// string recommendation = temperatura switch
// {
//     < 0 => "Мороз",
//     >= 0 and <= 9 => "Прохладно",
//     >= 10 and <= 19 => "Комфортно",
//     >= 20 and <= 29 => "Тепло",
//     _ => "Жарко"
// };

// Console.WriteLine(recommendation);

// // Вариант 7. Уровень игрока

// Console.Write("Введите количество очков: ");
// int points = int.Parse(Console.ReadLine()!);

// string playerRank = points switch
// {
//     < 0 => "Ошибка",
//     >= 0 and <= 999 => "Новичок",
//     >= 1000 and <= 4999 => "Опытный",
//     >= 5000 and <= 9999 => "Продвинутый",
//     _ => "Мастер"
// };

// Console.WriteLine(playerRank);

// Доп задание

// int number = 2;

// string anotherResult = number switch
// {
//     < 0 => "Отрицательное",
//     1 or 2 or 3 => "Маленькое",
//     >= 0 and <= 9 => "Однозначное",
//     >= 10 and <= 99 => "Двузначное",
//     >= 100 and <= 999 => "Трехзначное",
//     _ => "Больше"
// };

// Console.WriteLine(anotherResult);