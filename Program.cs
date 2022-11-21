Console.Clear();
string[] company = {"Bloody", "A4tech", "X7", "Asus", "JBL", "HP", "Xtrfy", "Destiny-brand", "Evga", "Ducky"};
string[] rezultat = new string[company.Length];


void Array(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}

void Print(string[] massiv)
{
    for (int i = 0; i < massiv.Length; i++)
    {
        Console.Write(massiv[i]+" ");
    }
    Console.WriteLine();
}

Array(company, rezultat);
Print(company);
Console.WriteLine();
Print(rezultat);