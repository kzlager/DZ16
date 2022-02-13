// Дано число обозначающее день недели. Выяснить является номер дня недели выходным.
int GetRandom()
{
    int number = new Random().Next(1, 8);
    return number;
}
int randomazer = GetRandom();
Console.WriteLine($"Номер дня недели: {randomazer}");
if (randomazer >= 6) Console.WriteLine($"{randomazer} выходной день");
else Console.WriteLine($"{randomazer} будний день");
