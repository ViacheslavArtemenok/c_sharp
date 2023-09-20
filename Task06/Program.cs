/*Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет*/
bool CheckEvenNumber(int a){
    if(a % 2 == 0){
        return true;
    } else return false;
}
Console.WriteLine("Задача 6");
Console.WriteLine($"4 -> {(CheckEvenNumber(4) ? "да" : "нет")}");
Console.WriteLine($"-3 -> {(CheckEvenNumber(-3) ? "да" : "нет")}");
Console.WriteLine($"7 -> {(CheckEvenNumber(7) ? "да" : "нет")}");
Console.WriteLine("\n");
