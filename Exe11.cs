using System;
/* 11. Faça o algoritmo (diagrama de blocos e português estruturado) que calcule a quantidade de tijolos
iguais (QTD) necessários para construir uma determinada parede. São dados de entrada do programa: dimensões do tijolo (comprimento – CT e largura – LT) e dimensões da parede a ser construída
(comprimento – CP e largura – LP). */

class Program {
  public static void Main (string[] args) {
    double CT, LT, CP, LP, QTD;
    Console.Write ("Digite o comprimento do tijolo: ");
   CT = double.Parse(Console.ReadLine());
    Console.Write("Digite a largura do tijolo: ");
    LT = double.Parse(Console.ReadLine());
    Console.Write("Digite o comprimento da parede: ");
    CP = double.Parse(Console.ReadLine());
    Console.Write("Digite a largura da parede: ");
    LP = double.Parse(Console.ReadLine());
    QTD = (CT +  CP) * (LT + LP);
      Console.WriteLine("A quantidade de tijolos a ser utilizado é: {0}", QTD);
  }
}
