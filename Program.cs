Console.WriteLine("Введите количество слов в вашем массиве");
int size = Convert.ToInt32(Console.ReadLine());
string [] array = new string [size];
for (int i = 0; i < size; i++)
{
    Console.WriteLine($"Введите  {i+1} слово массива");
    array[i] = Convert.ToString(Console.ReadLine());
}
Console.WriteLine("Ваш массив");
Console.WriteLine('[' + string.Join(" , ",array)+']');

int sizeResultArray = 0;

for (int i = 0; i < size; i++)
{
    if(array[i].Length <4)
    {
        sizeResultArray++;
    }
}
string [] resultArray = new string [sizeResultArray];
int Counter = 0;
for (int i = 0; i < size; i++)
{
    if(array[i].Length <4)
    {
        resultArray[Counter] = array[i];
        Counter++;
    }
}
Console.WriteLine("Массив из слов, длина которых меньше, либо равна 3 символам ");
Console.WriteLine('[' + string.Join(" , ",resultArray)+']');