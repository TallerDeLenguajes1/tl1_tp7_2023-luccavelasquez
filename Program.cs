using EspacioCalculadora;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        //probando

        Calculadora operacion = new Calculadora();
        
        float num1 = 1; 
        float num2 = 5;

        operacion.Sumar(num1,num2);
        operacion.Restar(num1,num2);

        Console.WriteLine(operacion.MostrarResult());

        //1
        string opcion = "";
        string sNum1="", sNum2="";
        do
        {
            Console.WriteLine("Ingrese la opcion de que decea realizar: ");
            Console.WriteLine("1-Sumar");
            Console.WriteLine("2-Restar");
            Console.WriteLine("3-Multipilicar");
            Console.WriteLine("4-Dividir");
            opcion = Console.ReadLine();

            Console.WriteLine("Ingrese el primer numero");
            sNum1 = Console.ReadLine();
            Console.WriteLine("Ingrese el segundo numero");
            sNum2 = Console.ReadLine();

            //terminar de hace la interfaz, ver para que sirve el limpiar

        } while (true);

    }

}