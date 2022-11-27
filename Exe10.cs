using System;
/* 10. Faça o algoritmo (diagrama de blocos e português estruturado) que receba dois valores inteiros nas variáveis A e B. O programa deve trocar os valores entre as variáveis (ou seja, ao término do programa a variável A deve ter o valor inicial de B e vice-versa). Apresentar as duas variáveis o final. */
class Program {
  public static void Main (string[] args) {
    double A, B, C;
    Console.Write ("Digite o valor A: ");
    A = double.Parse(Console.ReadLine());
    Console.Write ("Digite o valor B: ");
      B = double.Parse(Console.ReadLine());
  C = A;
    C = B;
    Console.WriteLine("O valor B é: {0}", A);
      Console.WriteLine("O valor A é: {0}", B);
     
    
  }
}
