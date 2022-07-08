Rectangulo rectangulo = new Rectangulo(x1: 0, x2: 4, x3: 4, x4: 0, y1: 0, y2: 0, y3: 2, y4: 2);
Cuadrado cuadrado = new Cuadrado(x1: 0, x2: 4, x3: 4, x4: 0, y1: 0, y2: 0, y3: 4, y4: 4);
Trapecio trapecio = new Trapecio(x1: 0, x2: 4, x3: 3, x4: 1, y1: 0, y2: 0, y3: 2, y4: 2);
Console.WriteLine("Primer rectangulo");
Console.WriteLine($"Area primer rectangulo correcto: {rectangulo.CalcularArea()}\n");
Console.WriteLine("Primer cuadrado");
Console.WriteLine($"Area primer cuadrado correcto: {cuadrado.CalcularArea()}\n");
Console.WriteLine("Primer trapecio");
Console.WriteLine($"Area primer trapecio correcto: {trapecio.CalcularArea()}\n");
Rectangulo rectangulo2 = new Rectangulo(x1: 0, x2: 10, x3: 10, x4: 0, y1: 0, y2: 0, y3: 2, y4: 2);
Cuadrado cuadrado2 = new Cuadrado(x1: 0, x2: 10, x3: 10, x4: 0, y1: 0, y2: 0, y3: 10, y4: 10);
Trapecio trapecio2 = new Trapecio(x1: 0, x2: 10, x3: 4, x4: 1, y1: 0, y2: 0, y3: 4, y4: 4);
Console.WriteLine("Segundo rectangulo");
Console.WriteLine($"Area segundo rectangulo correcto: {rectangulo2.CalcularArea()} \n");
Console.WriteLine("Segundo cuadrado");
Console.WriteLine($"Area segundo cuadrado correcto: {cuadrado2.CalcularArea()} \n");
Console.WriteLine("Segundo trapecio");
Rectangulo rectangulo3 = new Rectangulo(x1: 0, x2: 10, x3: 9, x4: 0, y1: 0, y2: 0, y3: 2, y4: 2);
Cuadrado cuadrado3 = new Cuadrado(x1: 0, x2: 10, x3: 10, x4: 0, y1: 0, y2: 0, y3: 9, y4: 10);
try
{
    Console.WriteLine(trapecio2.CalcularArea());
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message + "\n");
}
try
{
    Console.WriteLine($"Tercer rectangulo");
    Console.WriteLine(rectangulo3.CalcularArea());
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message + "\n");
}
try
{
    Console.WriteLine($"Tercer cuadrado");
    Console.WriteLine(cuadrado3.CalcularArea());
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message + "\n");
}

