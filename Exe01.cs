using System;
/*01 - Faça o algoritmo para calcular a AREA de uma sala, sendo que os comprimentos são fornecidos pelo usuário. Apresente a área depois de calculada. */
class Program {
  public static void Main (string[] args) {
  double area, L, C;
  Console.Write ("Digite o primeiro valor (largura): ");
  L = double.Parse(Console.ReadLine());
  Console.Write ("Digite o segundo valor (comprimento): ");
  C = double.Parse(Console.ReadLine());
  area = (L * C);
  Console.WriteLine("A area é: {0}", area);
  }
}
