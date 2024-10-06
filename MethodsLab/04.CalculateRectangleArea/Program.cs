
int width = int.Parse(Console.ReadLine());
int length = int.Parse(Console.ReadLine());

Console.WriteLine(CalculateArea(width , length));

static int CalculateArea(int width, int length) 
{
    int area = width * length;
    return area;
}