// See https://aka.ms/new-console-template for more information
Console.Clear();
Console.WriteLine();
double[] arrr = new double[10];
FilArray(arrr);
PrintArray(arrr);
Console.WriteLine();
Console.WriteLine($"Минимальный элемент равен: {MaxEl(arrr):F2}");
Console.WriteLine($"Минимальный элемент равен: {MinEl(arrr):F2}");
Console.WriteLine($"Разность максимального и минимального равна: {MaxEl(arrr) - MinEl(arrr):F2}");


void FilArray(double[] ar)
{
    Random rnd = new Random();

    for (int i = 0; i < ar.Length; i++) ar[i] = rnd.NextDouble() * 100;
}

void PrintArray(double[] ar)
{
    for (int i = 0; i < ar.Length; i++) Console.WriteLine(string.Format("{0:F2}", ar[i]));
}

double MaxEl(double[] ar)
{
    double Mx = ar[0];
    for (int i = 1; i < ar.Length; i++)
    {
        if (ar[i] > Mx) Mx = ar[i];
    }
    return Mx;
}

double MinEl(double[] ar)
{
    double Mn = ar[0];
    for (int i = 1; i < ar.Length; i++)
    {
        if (ar[i] < Mn) Mn = ar[i];
    }
    return Mn;
}