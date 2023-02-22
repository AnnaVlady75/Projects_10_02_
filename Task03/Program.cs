// 2.	Напишите программу, которая
// будет выдавать название дня недели по заданному номеру.
// 3 -> Среда 5 -> Пятница
Console.WriteLine("Введите номер дня недели: ");
string? numWeek = Console.ReadLine();
if (numWeek == "1") Console.WriteLine("->Понедельник");
else if (numWeek == "2") Console.WriteLine("->Вторник");
else if (numWeek == "3") Console.WriteLine("->Среда");
else if (numWeek == "4") Console.WriteLine("->Четверг");
else if (numWeek == "5") Console.WriteLine("->Пятница");
else if (numWeek == "6") Console.WriteLine("->Суббота");
else if (numWeek == "7") Console.WriteLine("->Воскресенье");
else Console.WriteLine("Ошибка ввода.");