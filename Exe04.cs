using System;
/* 4. Faça o algoritmo (diagrama de blocos e português estruturado) para calcular quanto será pago por um
produto (PAG), sendo que o preço do produto (PR) e o desconto (D) são fornecidos pelo usuário. Apresentar o valor a ser pago pelo produto.*/
class Program {
  public static void Main (string[] args) {
    double PR, D, PAG;
    Console.Write ("Digite o preço do produto: ");
    PR = double.Parse(Console.ReadLine());
    Console.Write("Digite o valor do desconto: ");
    D = double.Parse(Console.ReadLine());
    PAG = (PR - D);
      Console.WriteLine("O valor a ser pago é: {0}", PAG);
  }
}
