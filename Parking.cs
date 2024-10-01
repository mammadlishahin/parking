
class Parking
{
    public static void Main()
    {
        Console.Write("Neçə Saat qalacaq: ");
        int saatlar = Convert.ToInt32(Console.ReadLine());
        double deger = Hesabla(saatlar);
        Console.WriteLine($"Ümumi ödəniləcək deger: {deger} maat");
    }

    static double Hesabla(int saatlar)
    {
        double deger = 0;
        
        if (saatlar <= 3)
        {
            deger = saatlar * 1;
        }
        else if (saatlar <= 5)
        {
            deger = 3 * 1 + (saatlar - 3) * 0.80;
        }
        else if (saatlar <= 8)
        {
            deger = 3 * 1 + 2 * 0.80 + (saatlar - 5) * 0.50;
        }
        else
        {
            deger = 3 * 1 + 2 * 0.80 + 3 * 0.50 + (saatlar - 8) * 0.25;
        }

        return deger;
    }
}
