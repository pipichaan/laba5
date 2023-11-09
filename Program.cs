Console.WriteLine("Введите значения массива с обязательными двумя нулями");
int a = Convert.ToInt32(Console.ReadLine());
int[] mas = new int[a];
int nol1 = 0;
int nol2 = 0;
for (int i = 0; i < mas.Length; i++)
{
    mas[i]= Convert.ToInt32(Console.ReadLine());

}
for( int i = 0;i < mas.Length; i++) 
{ 
    if (mas[i] == 0)
    {
        nol1 = i;
        break;
    }
}
for (int i = nol1 + 1; i < mas.Length; i++)
{
    if (mas[i] == 0)
    {
        nol2 = i;
        break;
    }
}
for (int i = nol1 + 1; i <= nol2 - 1; i++)
{
    Console.WriteLine(mas[i]);
}