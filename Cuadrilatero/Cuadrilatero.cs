using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Cuadrilatero
{
    public int X1 { get; set; }
    public int X2 { get; set; }
    public int X3 { get; set; }
    public int X4 { get; set; }
    public int Y1 { get; set; }
    public int Y2 { get; set; }
    public int Y3 { get; set; }
    public int Y4 { get; set; }

    protected Cuadrilatero(int x1, int x2, int x3, int x4, int y1, int y2, int y3, int y4)
    {
        this.X1 = x1;
        this.X2 = x2;
        this.X3 = x3;
        this.X4 = x4;
        this.Y1 = y1;
        this.Y2 = y2;
        this.Y3 = y3;
        this.Y4 = y4;
    }

    public abstract string CalcularArea();

    protected int CalcularDistancia(int x1, int x2, int y1, int y2)
    {
        double cuadratica = Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2);
        return (int) Math.Sqrt(cuadratica);
    }

}