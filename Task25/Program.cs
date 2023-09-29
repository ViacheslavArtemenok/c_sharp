// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
int GetADegreeB(int a, int b){
    if(b < 0){
        Console.WriteLine("Введите натуральную степень числа B!!!");
        return 0;
    }
    int res = 1;
    for (int i = 0; i < b; i++)
    {
        res *= a; 
    }
        return res;
    }


void TestGetADegreeB(int a, int b, int pattern){
    bool res = GetADegreeB(a, b) == pattern;
    Console.WriteLine($"{a}^{b} -> {pattern}");
    Console.WriteLine($"{a}^{b} -> {GetADegreeB(a, b)}");
    Console.WriteLine($"{(res ? "Тест пройден!" : "Тест не пройден")}");
}

void ShowGetADegreeB(){
    Console.WriteLine("Введите число A");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число B");
    int b = Convert.ToInt32(Console.ReadLine());
    int res = GetADegreeB(a, b);
    Console.WriteLine($"{a}^{b} -> {res}");
}

TestGetADegreeB(3, 5, 243);
TestGetADegreeB(2, 4, 16);
ShowGetADegreeB();