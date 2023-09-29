// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
int GetSumOfDigits(int number){
    int res = 0;
    if(number < 0){
        number *= -1;
    }
       while(number > 0){
            res += number % 10;
            number /= 10;
        }
        return res;
    
}

void TestGetSumOfDigits(int number, int pattern){
    bool res = GetSumOfDigits(number) == pattern;
    Console.WriteLine($"{number} -> {pattern}");
    Console.WriteLine($"{number} -> {GetSumOfDigits(number)}");
    Console.WriteLine($"{(res ? "Тест пройден!" : "Тест не пройден")}");
}

void ShowGetSumOfDigits(){
    Console.WriteLine("Введите целое число");
    int number = Convert.ToInt32(Console.ReadLine());
    int res = GetSumOfDigits(number);
    Console.WriteLine($"{number} -> {res}");
}

TestGetSumOfDigits(452, 11);
TestGetSumOfDigits(82, 10);
TestGetSumOfDigits(9012, 12);
ShowGetSumOfDigits();