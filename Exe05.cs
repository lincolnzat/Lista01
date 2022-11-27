using System;
/* 05. Faça o algoritmo (diagrama de blocos e português estruturado) para calcular qual foi a porcentagem de
desconto dada em um determinado produto (DESC), sabendo-se o preço original do produto (PRECO) e o preço que foi cobrado por ele depois do desconto (PRECOF). */
class Program {
  public static void Main (string[] args) {
    double DESC, PRECO, PRECOF;
    Console.Write("Digite o preço original do produto: ");
    PRECO = double.Parse(Console.ReadLine());
    Console.Write("Digite o valor cobrado após o desconto: ");
    PRECOF = double.Parse(Console.ReadLine());
    DESC = 100 - (PRECOF*100)/PRECO;
    Console.Write("A porcentagem de desconto foi: {0:}% ", DESC);
    
  }
}
