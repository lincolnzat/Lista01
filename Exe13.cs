using System;
/* 13. No algoritmo abaixo, o que está errado? */
class Program {
  public static void Main (string[] args) {
    double A, B, Rascunho, Resultado;
    Console.Write("Digite o valor A: ");
    A = double.Parse(Console.ReadLine());
    Console.Write("Digite o valor B: ");
    B = double.Parse(Console.ReadLine());
    Rascunho = (A-B)*(A/3);
    Console.WriteLine("O resultado do rascunho é: {0}", Rascunho);
    Resultado = (B-100);
      Console.WriteLine("O resultado da operação é: {0}", Resultado);
  }
}
