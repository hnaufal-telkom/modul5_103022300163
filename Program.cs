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

        SimpleDataBase<double> db = new SimpleDataBase<double>();
        db.AddNewData(10);
        db.AddNewData(30);
        db.AddNewData(22);
        db.PrintAllData();
    }
}


class SimpleDataBase<T>
{
    private List<T> storedData;
    private List<DateTime> inputDates;

    public SimpleDataBase()
    {
        storedData = new List<T>();
        inputDates = new List<DateTime>();
    }

    public void AddNewData(T data)
    {
        storedData.Add(data);
        inputDates.Add(DateTime.Now);
    }

    public void PrintAllData()
    {
        Console.WriteLine("Semua Data\n");
        for (int i = 0; i < storedData.Count; i++)
        {
            Console.WriteLine("Data " + i + " berisi: " + storedData[i] + ", yang disimpan pada waktu UTC: " + inputDates[i]);
        }
    }
}