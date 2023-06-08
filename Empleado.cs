namespace Empleado;


public enum cargos
{
    Auxiliar = 0,
    Administrativo = 1,
    Ingeniero = 2,
    Especialista = 3,
    Investigador = 4    
}


public class Empleado
{
    private String Nombre;
    private String Apellido;
    private DateTime fechaNac;
    private char EstadoCivil;
    private char Genero;
    private DateTime FechaIngreso;
    private double SueldoBasic;
    //falta el cargo
    private cargos Cargo;


    public void Antiguedad() //tendria que devolver un datetime?
    {
        TimeSpan antiguedad; 

        antiguedad = (DateTime.Now - FechaIngreso);
        //me faltaria escribirlo, y preguntar si debe ser un void o debe retornar el valor de diferencia...
    }

    public void Edad() //podria ser una propiedad?
    {
        TimeSpan edad;
        edad = (DateTime.Now - fechaNac);
        
        Console.WriteLine("La edad del empleado es: "+ edad.Days); //como pongo años?

    }

    public void Juvilacion()
    {
        int edad = 0; // cambiar por el valor que coresponderia
        int faltantes = 0;

        if (Genero == 'F')
        {
            faltantes = 60 - edad;
        }
        if (Genero == 'M')
        {
            faltantes = 65 - edad;
        }

        Console.WriteLine("La cantidad de anios faltantes para juvilarse es: "+ faltantes);
    }


    //b
    public void Salario()
    {
        //salario = sueldo basico + adicional
    }

    public void Adicional()
    {
        double adicional = 0;
        int antiguedad = 0; //reemplazar por la prop o metodo

        if (antiguedad < 20)
        {
            adicional = SueldoBasic * (antiguedad/100);
        } else
        {
            adicional = SueldoBasic * 0.25;
        }

        //ver como utilizar el enum


        if (EstadoCivil == 'C') //casado
        {
            adicional = adicional + 15000; 
        }

    }

}