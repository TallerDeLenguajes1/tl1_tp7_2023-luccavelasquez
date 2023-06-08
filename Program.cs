using EspacioCalculadora;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        DateTime ahora = DateTime.Now;
        DateTime fechita = new DateTime(2003, 5, 15, 8, 30, 52);

        //DateTime result = ahora - fechita;
        TimeSpan result = (ahora - fechita);
        Console.WriteLine(result.TotalDays);




        //Console.WriteLine(ahora);

    }

}