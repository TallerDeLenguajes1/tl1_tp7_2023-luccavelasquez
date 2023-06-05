namespace EspacioCalculadora;

public class Calculadora
{
    private float dato;

    public float resultado //propiedad?
    {
        get => dato; // ver para que nos lo pide
    }

    public Calculadora() //constructor
    {

    }

    public void Sumar(float num1,float num2)
    {
        dato = num1 + num2;
    }
    public void Restar(float num1,float num2)
    {
        dato = num1 - num2;
    }

    public void Multiplicar(float num1,float num2)
    {
        dato = num1 * num2;
    }

    public void Dividir(float num1,float num2)
    {
        dato = num1 / num2;
    }
    public void Limpiar()
    {
        dato = 0; //preg para que sirve, yq eu va en este bloque
    }

    public String MostrarResult()
    {
        return "El resulatado es:"+resultado;
    }

}