# nullable disable
string[] RecordString()
{
    string[] someString = new string[5];
    for (int i = 0; i < 5; i++)
    {
        Console.WriteLine("Введите строку:");
        someString[i] = Console.ReadLine();
    }
    return someString;
}

string[] recordString = RecordString();
Console.Write("[");
int i = 0;
while(i < recordString.Length)
{
    if (recordString[i].Length <= 3)
    {
        Console.Write($" {recordString[i]}");
    }
    i++;
}
Console.WriteLine("]");