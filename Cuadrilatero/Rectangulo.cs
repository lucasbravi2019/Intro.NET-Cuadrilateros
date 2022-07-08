using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Rectangulo : Cuadrilatero
{
    public Rectangulo(int x1, int x2, int x3, int x4, int y1, int y2, int y3, int y4) : base(x1, x2, x3, x4, y1, y2, y3, y4)
    {
    }

    public override string CalcularArea()
    {
        int lado1 = CalcularDistancia(X1, X2, Y1, Y2);
        int lado2 = CalcularDistancia(X2, X3, Y2, Y3);
        int lado3 = CalcularDistancia(X3, X4, Y3, Y4);
        int lado4 = CalcularDistancia(X4, X1, Y4, Y1);

        Console.WriteLine($"Lado 1: {lado1}");
        Console.WriteLine($"Lado 2: {lado2}");
        Console.WriteLine($"Lado 3: {lado3}");
        Console.WriteLine($"Lado 4: {lado4}");

        if (lado1 == lado2 && lado3 == lado4)
        {
            return $"{lado1 * lado3} cm2";
        }
        if (lado1 == lado3 && lado2 == lado4 || lado1 == lado4 && lado2 == lado3)
        {
            return $"{lado1 * lado2} cm2";
        }
        throw new Exception("Los vertices no pertenecen a un rectangulo");
    }

}
