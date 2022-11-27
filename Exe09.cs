using System;
/* 09. Faça o algoritmo (diagrama de blocos e português estruturado) que calcule o valor em Reais (VAL_REAL), correspondente aos dólares que um turista possui no cofre do hotel. O programa deve solicitar os seguintes dados: Quantidade de dólares guardados no cofre (VAL_DOLAR) e cotação do dólar naquele dia (COT). */
class Program {
  public static void Main (string[] args) {
  double VAL_REAL, VAL_DOLAR, COT ;
 Console.Write("Digite a quantidade de doláres guardados: ");
VAL_DOLAR = double.Parse(Console.ReadLine());
    Console.Write("Digite a cotação do dólar: ");
    COT = double.Parse(Console.ReadLine());
    VAL_REAL = (VAL_DOLAR * COT);
      Console.Write("O valor em real é: {0}", VAL_REAL);
  }
}
