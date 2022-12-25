// Задача 2: Напишите программу, которая на вход
// принимает два числа и выдаёт, какое число большее,
// а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3
Console.Clear();

Console.WriteLine("Введите первое число: ");
int namberA = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int namberB = int.Parse(Console.ReadLine()!);

if(namberA>namberB){
    Console.WriteLine($"Число {namberA} больше {namberB} ");
}
else {
    Console.WriteLine($"Число {namberB} больше {namberA}");
}