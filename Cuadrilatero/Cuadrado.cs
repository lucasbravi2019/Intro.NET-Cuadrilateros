public class Cuadrado : Cuadrilatero
{
    public Cuadrado(int x1, int x2, int x3, int x4, int y1, int y2, int y3, int y4) : base(x1, x2, x3, x4, y1, y2, y3, y4)
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

        if (lado1 == lado2 && lado1 == lado3 && lado1 == lado4)
        {
            return $"{Math.Pow(lado1, 2)} cm2";
        }
        throw new Exception("Los vertices no pertenecen a un cuadrado");
    }
}