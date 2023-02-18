// Задача 18: Напишите программу, которая по
// заданному номеру четверти, показывает 
// диапазон возможных координат точек в этой четверти (x и y).

// Тело программы
string number = Prompt("введите номер четверти: ");

string range = Range(number);

string result = range=="0"
                ?"Ошибка ввода"
                :$"Диапазон возможных координат точек в этой четверти {range}";
Console.WriteLine(result);

// Методы
string Prompt(string message)
{
    Console.Write(message);
    string num = Console.ReadLine();
    return num;
}

string Range(string num)
{
    if (num == "1") return "x > 0 && y > 0";
    if (num == "2") return "x < 0 && y > 0";
    if (num == "3") return "x < 0 && y < 0";
    if (num == "4") return "x > 0 && y < 0";
    return "0";
}