using System;
/* Faça o algoritmo (diagrama de blocos e português estruturado) para calcular o valor a ser pago pelo período de estacionamento do automóvel (PAG). O usuário entra com os seguintes dados: hora (HE) e minuto (ME) de entrada, hora (HS) e minuto (MS) de saída. Sabe-se que este estacionamento cobra R$ 4,00, mas calcula as frações de hora também. Por exemplo, se a pessoa ficar 1 hora e quinze minutos, pagará R$ 5,00 (R$ 4,00 pela hora e R$ 1,00 pelos quinze
minutos). */
class Program {
  public static void Main (string[] args) {
     double HE, ME, HS, MS, PAG;
    Console.Write ("Digite a hora e minuto de entrada: ");
    HE = double.Parse(Console.ReadLine());
    ME = double.Parse(Console.ReadLine());
    Console.Write ("Digite a hora e minuto de saída: ");
    HS = double.Parse(Console.ReadLine());
    MS = double.Parse(Console.ReadLine());
    PAG = (HE + ME) / (HS + MS);
      Console.Write ("O preço a ser pago é: {0} ", PAG);
    
  }
}
