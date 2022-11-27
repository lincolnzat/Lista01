using System;
/* 06. Faça o algoritmo (diagrama de blocos e português estruturado) que calcule a idade de uma pessoa, sendo que o ano atual (AA) e o ano do nascimento da pessoa (AN) são fornecidos pelo usuário. (onsidere que a pessoa já fez aniversário nesse ano). Apresentar a idade da pessoa depois de calculada. */
class Program {
  public static void Main (string[] args) {
    double AA, AN, idade;
      Console.Write("Digite o ano atual: ");
    AA = double.Parse(Console.ReadLine());
    Console.Write("Digite o ano de nascimento: ");
    AN = double.Parse(Console.ReadLine());
    idade = (AA - AN);
    Console.WriteLine ("A idade é: {0}", idade);
  }
}
