namespace Calculos;
public class Calculadora
{
    public int Soma (int operador1, int operador2)=> operador1 + operador2;
    public int Subtracao (int operador1, int operador2)=> operador1 - operador2;

    public int Multiplicacao (int operador1, int operador2)=> operador1 * operador2;

    public double Divisao (double operador1, double operador2)
    {
        if(operador2==0)
        {
            return 0;
        }
        return operador1/operador2;
    }

  public (int quociente, int resto) RestoDivisao (int dividendo , int divisor) => (dividendo/divisor,dividendo % divisor);
}
