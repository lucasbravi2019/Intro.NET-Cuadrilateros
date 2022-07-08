using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Trapecio : Cuadrilatero
{
    public Trapecio(int x1, int x2, int x3, int x4, int y1, int y2, int y3, int y4) : base(x1, x2, x3, x4, y1, y2, y3, y4)
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

        List<int> numeros = new List<int>();
        numeros.Add(lado1);
        numeros.Add(lado2);
        numeros.Add(lado3);
        numeros.Add(lado4);
        Dictionary<string, int> ladosCalculados = EncontrarLados(numeros);
        int hipotenusa = ladosCalculados.GetValueOrDefault("hipotenusa");
        int mayor = ladosCalculados.GetValueOrDefault("mayor");
        int menor = ladosCalculados.GetValueOrDefault("menor");
        return $"{CalcularSuperFicieConAltura(hipotenusa, mayor, menor)} cm2";  
    }

    private double CalcularAltura(int hipotenusa, int baseMayor, int baseMenor)
    {
        double cateto = (baseMayor - baseMenor) / 2;
        double cuadratica = Math.Pow(cateto, 2) + Math.Pow(hipotenusa, 2);
        return Math.Sqrt(cuadratica);
    }

    private double CalcularSuperFicieConAltura(int hipotenusa, int baseMayor, int baseMenor)
    {
        double altura = CalcularAltura(hipotenusa, baseMayor, baseMenor);
        Console.WriteLine($"Altura: {altura} cm");
        Console.WriteLine($"Base Mayor: {baseMayor} cm");
        Console.WriteLine($"Base Menor: {baseMenor} cm");
        return (baseMayor + baseMenor) * altura / 2;
    }

    private Dictionary<string, int> EncontrarLados(List<int> lados)
    {
        int mayor = 0;
        int menor = 0;
        int? hipotenusa = null;
        for (int i = 0; i < lados.Count(); i++)
        {
            for (int j = 0; j < lados.Count(); j++)
            {
                if (i != j && lados[i] == lados[j])
                {
                    hipotenusa = i;
                }
                if (i != j && mayor < lados[i])
                {
                    mayor = lados[i];
                    if (menor == 0) menor = mayor;
                }
                if (i != j && menor > lados[i])
                {
                    menor = lados[i];
                }
            }
        }
        if (hipotenusa == null) throw new Exception("No se encontraron lados iguales");
        Dictionary<string, int> ladosCalculados = new Dictionary<string, int>();
        ladosCalculados.Add("hipotenusa", hipotenusa ?? throw new Exception("Hipotenusa es null"));
        ladosCalculados.Add("mayor", mayor);
        ladosCalculados.Add("menor", menor);
        return ladosCalculados;
    }

}