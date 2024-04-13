using Calculando;

public class Program{
    public static void Main(string[] args){
        calculadraCientifica calculadora = new calculadraCientifica(1,"Yamaha");



        Console.WriteLine($"La raiz cuadrada de 25 es: {calculadora.RaizCuadrada(25)}");
        
    }
}