// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
bool CheckDayOfWeek(int number){
    if(number > 5 && number < 8){
        return true;
    }
    else return false;
}

void TestDayOfWeek(int number, bool pattern){
    bool res = CheckDayOfWeek(number) == pattern;
    Console.WriteLine($"{number} -> {pattern}");
    Console.WriteLine($"{number} -> {CheckDayOfWeek(number)}");
    Console.WriteLine($"{(res ? "Тест пройден!" : "Тест не пройден")}");
}

void ShowDayOfWeek(){
    Console.WriteLine("Введите цифру, обозначающую день недели");
    int number = Convert.ToInt32(Console.ReadLine());
    if(number > 0 && number < 8){
        Console.WriteLine("Это выходной?");
        Console.WriteLine($"{number} -> {(CheckDayOfWeek(number) ? "да" : "нет")}");
    } else {
        Console.WriteLine("Error: Необходимо ввести цифру, обозначающую день недели!!!");
    }
}

TestDayOfWeek(6, true);
TestDayOfWeek(7, true);
TestDayOfWeek(1, false);
ShowDayOfWeek();