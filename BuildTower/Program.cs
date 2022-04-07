// See https://aka.ms/new-console-template for more information
static string[] TowerBuilder(int nFloors)
{
    List<string> strings = new List<string>();
    string str = "";
    for (int i = 1; i <= nFloors; i++) // Total number of layer for pramid  
    {
        for (int j = 1; j <= (nFloors - i); j++) // Loop For Space  
            str += " ";
        for (int j = 1; j <= i; j++) //increase the value  
            str += "*";
        for (int j = (i - 1); j >= 1; j--) //decrease the value  
            str += "*";  
        strings.Add(str);
    }

    return strings.ToArray();
}

string[] strings = TowerBuilder(3);
foreach (var str in strings)
{
    Console.Write(str);
}
TowerBuilder(3);

