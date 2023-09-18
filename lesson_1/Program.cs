// See https://aka.ms/new-console-template for more information
/*
Console.WriteLine("Калькулятор");
int numberA = Convert.ToInt32(Console.ReadLine());
string? symbol = Console.ReadLine();
int numberB = Convert.ToInt32(Console.ReadLine());
string result;
switch (symbol)
{
    case "+":
        result = Convert.ToString(numberA + numberB);
        break;
    case "-":
        result = Convert.ToString(numberA - numberB);
        break;
     case "*":
        result = Convert.ToString(numberA * numberB);
        break;
    case "/":
        if(numberB == 0){
            Console.WriteLine("На ноль делить нельзя!!!");
            return;
        }
        result = Convert.ToString((double)numberA / numberB);
        break;
    default:
        Console.WriteLine("Неверный оператор!!!");
        return;
}


Console.WriteLine($"{numberA} {symbol} {numberB} = {result}");
*/
using System.Security.Cryptography.X509Certificates;

static void SetCursor(int x, int y){
Console.SetCursorPosition(x, y);
}

/*static void GetTriangle(int height){
for(int e = 1; e <= height; e++){
    for(int i = 0; i < e; i++){
        Console.Write("+");
    }
    Console.Write("\n");
    }
}*/

static void Getpyramid(int height){
    int x = 0;
    int y = 0;
    for(int e = 1; e <= height; e++){
        x = height - e;
        y = e - 1;
        SetCursor(x, y);
        int weight = e * 2 - 1;
        for(int i = 0; i < weight; i++){
            Console.Write("+");
        }
        Console.Write("\n");
    }
}
/*Console.Clear();
Console.WriteLine("Введите высоту треугольника");
int height = Convert.ToInt32(Console.ReadLine());
Console.Clear();
GetTriangle(height);*/

Console.Clear();
Console.WriteLine("Введите высоту пирамиды");
int height = Convert.ToInt32(Console.ReadLine());
Console.Clear();
Getpyramid(height);
