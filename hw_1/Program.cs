/*Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3*/
string GetGreaterNumber(int a, int b){
    if(a == b){
        return $"a = {a}; b = {b} -> Числа равны";
    }
    else if(a > b){
        return $"a = {a}; b = {b} -> max = {a}";
    }
    else return $"a = {a}; b = {b} -> max = {b}";
}
Console.WriteLine("Задача 2");
//Console.WriteLine(GetGreaterNumber(3, 3));
Console.WriteLine(GetGreaterNumber(5, 7));
Console.WriteLine(GetGreaterNumber(2, 10));
Console.WriteLine(GetGreaterNumber(-9, -3));
Console.WriteLine("\n");

/*Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44, 5, 78 -> 78
22, 3, 9 -> 22*/
string GetMaxNumber(int a, int b, int c){
    string res = $"{a}, {b}, {c} -> ";
    int max = a;
    if(b > max){
        max = b;
    }
    if(c > max){
        max = c;
    }
    return res += $"{max}";
}
Console.WriteLine("Задача 4");
Console.WriteLine(GetMaxNumber(2, 3, 7));
Console.WriteLine(GetMaxNumber(44, 5, 78));
Console.WriteLine(GetMaxNumber(22, 3, 9));
Console.WriteLine("\n");

/*Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет*/
string CheckEvenNumber(int a){
    if(a % 2 == 0){
        return $"{a} -> Да";
    } else return $"{a} -> Нет";
}
Console.WriteLine("Задача 6");
Console.WriteLine(CheckEvenNumber(4));
Console.WriteLine(CheckEvenNumber(-3));
Console.WriteLine(CheckEvenNumber(7));
Console.WriteLine("\n");

/*Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8*/

string ShowAllEvenNumbers(int n){
    string res = $"{n} -> ";
    if(n > 1){
        for(int e = 1; e <= n; e++){
            if(e % 2 == 0){
                if(e == 2){
                    res += $"{e}";
                }
                else res += $", {e}";
            }   
        }
    }
    else {
        res += "empty";
    }
    return res;
}
Console.WriteLine("Задача 8");
//Console.WriteLine(ShowAllEvenNumbers(1));
//Console.WriteLine(ShowAllEvenNumbers(2));
Console.WriteLine(ShowAllEvenNumbers(5));
Console.WriteLine(ShowAllEvenNumbers(8));
Console.WriteLine("\n");


