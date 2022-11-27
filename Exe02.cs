using System;
/* 02 -Faça o algoritmo (diagrama de blocos e português estruturado) para calcular a área (AREA) e o perímetro (P) de uma sala, sendo que os comprimentos (L e C) são fornecidos pelo usuário. Apresente a área e o perímetro depois de calculados. */
class Program {
  public static void Main (string[] args) {
      double Base1, altura, area, perimetro;
  Console.Write ("Digite o primeiro valor (base): ");
  Base1 = double.Parse(Console.ReadLine());
  Console.Write ("Digite o segundo valor (altura): ");
  altura = double.Parse(Console.ReadLine());
  area = (Base1 * altura);
  Console.WriteLine("A area é: {0}", area);
    perimetro = (Base1 * 2) + (altura * 2);
      Console.WriteLine("O perimetro é: {0}", perimetro);
  }
}
