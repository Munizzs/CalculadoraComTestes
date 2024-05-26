using ApiExemplo.Models;


Calculadora c = new Calculadora();

c.Somar(10,35);
c.Subtrair(40,15);
c.Multiplicar(10,10);
c.Dividir(100,2);

foreach(String show in c.Historico())
{
    Console.WriteLine(show);
}