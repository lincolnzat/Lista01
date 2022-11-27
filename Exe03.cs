using System;
/* 3. Faça o algoritmo (diagrama de blocos e português estruturado) para calcular o valor monetário do desconto (D), sendo que o preço do produto (PR) é fornecido pelo usuário e o desconto é de 5%. Apresentar o valor do desconto. */
class Program {
  public static void Main (string[] args) {
    double PR, desc; 
Console.Write("Digite o preço do produto: ");
PR = double.Parse(Console.ReadLine());
    Console.Write("O desconto é de 5%: ");
      desc = (PR * 5/100);
      Console.WriteLine("O valor é: {0}", desc);
  }
}
