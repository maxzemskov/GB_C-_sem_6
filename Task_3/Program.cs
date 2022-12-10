int[] x_array = new int[4]; //массив для x
int[] y_array = new int[4]; //массив для y
double[] distance = new double[3]; //массив для длин треугольника
int i = 0;

double Length()
{
	double c = Math.Sqrt(Math.Pow((x_array[i] - x_array[i+1]), 2) + Math.Pow((y_array[i] - y_array[i+1]), 2));
	return c;
}


Console.WriteLine("Введите координату X 1ой точки");
x_array[0] = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату Y 1ой точки");
y_array[0] = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату X 2ой точки");
x_array[1] = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату Y 2ой точки");
y_array[1] = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату X 3ей точки");
x_array[2] = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату Y 3ей точки");
y_array[2] = Convert.ToInt32(Console.ReadLine());

x_array[3] = x_array[0];
y_array[3] = y_array[0];


for (i = 0; i < 3; i++)
	{
	distance[i] = Length();
	}


double s = Math.Sqrt(((distance[0] + distance[1] + distance[2]) / 2) * (((distance[0] + distance[1] + distance[2]) / 2) - distance[0]) * (((distance[0] + distance[1] + distance[2]) / 2) - distance[1]) * (((distance[0] + distance[1] + distance[2]) / 2) - distance[2]));

Console.WriteLine(Math.Round(s, 1)); //округляем до одного знака (судя по output условия)