// Пользователь вводит с клавиатуры M чисел 
// посчитайте сколько чисел больше 0 ввел пользователь
// 0, 7, 8, -2, -2->2
//1,-7, 567, 89, 223 ->3
Console.Clear();
Console.Write("Введите M чисел: ");
int[]array = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int count =0;

for (int i = 0; i<array.Length; i++)
{
    if (array[i] > 0)
    {
        count++;
    }
}
Console.WriteLine($"Колличество чисел больше 0 :{count}");