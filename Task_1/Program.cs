
Console.WriteLine("Введите количество чисел:");

int n = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[n];
int count = 0;

for (int i = 0; i < numbers.Length; i++)
{
Console.WriteLine($"Введите {i+1} число");
int b = Convert.ToInt32(Console.ReadLine());
numbers[i] = b;
if (b > 0)
count++;
}
Console.WriteLine($"Вы ввели {count} чисел больше 0");
