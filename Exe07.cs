using System;
/* 07 - Faça o algoritmo (diagrama de blocos e português estruturado) para calcular o volume de uma esfera(VOL). O raio (R) da esfera será fornecido pelo usuário. Obs: VOL = 3.14*R2(apresentar o volume da esfera) */
class Program {
  public static void Main (string[] args) {
    double VOL, R;
    Console.Write("Digite o raio da esfera: ");
    R = double.Parse(Console.ReadLine());
    VOL = (4 * Math.Pow(R, 3)/3);
    Console.Write("O volume da esfera é de: {0}", VOL);
  }
}
