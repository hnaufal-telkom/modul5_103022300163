// See https://aka.ms/new-console-template for more information
class PemrosesData
{
    public T DapatkanNilaiTerbesar<T>(ref T first, ref T second, ref T third)
    {
        dynamic max = first;
        if (second as dynamic >= first as dynamic)
        {
            max = second;
        }
        if (third as dynamic >= first as dynamic)
        {
            max = third;
        }

        return max;
    }
}

class Program
{
    public static void Main(string[] args)
    {
        double atu = 10;
        double ua = 30;
        double iga = 22;
        PemrosesData data = new PemrosesData();
        Console.WriteLine("Data terbesar : " + data.DapatkanNilaiTerbesar<double>(ref atu,ref ua,ref iga));
    }
}