// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
int GetSecondDigit(int number){
    if(number < 0){
        number *= -1;
    }
    if(number > 99 && number < 1000){
        int tmp = number / 10;
        return tmp %= 10;
    } else return -1;
}

void TestSecondDigit(int number, int pattern){
    bool res = GetSecondDigit(number) == pattern;
    Console.WriteLine($"{number} -> {pattern}");
    Console.WriteLine($"{number} -> {GetSecondDigit(number)}");
    Console.WriteLine($"{(res ? "Тест пройден!" : "Тест не пройден")}");
}

void ShowSecondDigit(){
    Console.WriteLine("Введите трёхзначное число");
    int number = Convert.ToInt32(Console.ReadLine());
    int res = GetSecondDigit(number);
    if(res == -1){
        Console.WriteLine("Error: Необходимо ввести трёхзначное число!!!");
        return;
    } else Console.WriteLine($"{number} -> {GetSecondDigit(number)}");
}

TestSecondDigit(456, 5);
TestSecondDigit(782, 8);
TestSecondDigit(915, 1);
TestSecondDigit(95, -1);
ShowSecondDigit();