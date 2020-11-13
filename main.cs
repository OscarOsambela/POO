using System;

class MainClass {
  public static void Main (string[] args) {
    Conversor obj = new Conversor();
    Console.WriteLine("Ingresa una cantidad en dólares para convertir a soles:");
    double s = double.Parse(Console.ReadLine());
    Console.WriteLine(obj.Convertir(s));
  }
} 
class Conversor{
  private double dolar = 3.54;
  public double Convertir(double s){
    return s * dolar;
  
  }
}

