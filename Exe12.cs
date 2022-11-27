using System;
/* 12. Baseado no algoritmo abaixo, o que é apresentado como saída (em tela ou papel) desse programa? Programa_EXERC12 */
class Program {
  public static void Main (string[] args) {
    double A, B, C, D;
      A = 2;
      B = 4;
      C = (A + B)*B;
      D = C*B/(A*A);
      A = D/(C+B);
      B = B+A;
    Console.WriteLine ("A variável A vale: {0}", A);
    Console.WriteLine ("A variável B vale: {0}", B);
    Console.WriteLine ("A variável C vale: {0}", C);
    Console.WriteLine ("A variável D vale: {0}", D);
  }
}
