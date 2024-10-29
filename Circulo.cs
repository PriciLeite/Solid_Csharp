namespace Solid;

class Circulo : Forma
{
    public override void Desenhar()
    {
        System.Console.WriteLine("Este objeto foi desenhado a partir da classe derivada!");
    }

    public void Pintar()
    {
        System.Console.WriteLine("Este objeto foi pintado a partir da classe derivada!");
    }
}







