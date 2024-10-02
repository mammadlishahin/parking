/*
1)Userdən integer bir dəyər alırsınız.Aldığınız ədədin sadə vəya mürəkkəb olub olmamasını yoxlayan alqoritm qurursunuz.
2)Userdən integer dəyər götürürsünüz və userin daxil etdiyi ədədə qədər olan sadə ədədlərin cəmini çap edən alqoritm qurun.
3)Userdən en və uzunluq dəyərləri götürün və daxil edilən dəyərlər üzrə düzbucaqlı yaradan alqoritm qurun.
*/

class MyClass1
{
    public static int MinValue(int[] num)
    {
        int i = 0;
        int @return = num[0];
        do
        {
            if (num[i] < @return)
            {
                @return = num[i];
            }
            i++;
        } while (num.Length > i);
        return @return;
    }

    public static bool IsPolindrom()
    {
        Console.Write("Dəyər gir: ");
        string StringValue = Console.ReadLine();
        for (int i = 0; i < StringValue.Length; i++)
        {
            if (StringValue[i] != StringValue[StringValue.Length - i - 1])
            {
                return false;
            }
        }
        return true;
    }

    public static double Rectangle(double en, double uzun) // Düzbucaqlı
    {
        return en * uzun;
    }

    
}