using System;

namespace CalculadoraSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual operação deseja realizar? \n Soma, Subtacao, Multiplicacao, Divisao");
            string operacao = Console.ReadLine().ToLower();

            Console.WriteLine("Digite o 1° número : ");
            float num1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o 2° número : ");
            float num2 = float.Parse(Console.ReadLine());

            float resultado = 0;

            switch (operacao){
                case "soma":
                    resultado = num1 + num2;
                    break;

                case "subtracao":
                    resultado = num1 - num2;
                    break;

                case "multiplicacao":
                    resultado = num1 * num2;
                    break;

                case "divisao":
                    resultado = num1 / num2;
                    break;

                default:
                    operacao = "invalida";
                    Console.WriteLine("Operação Inválida! :(");
                    break;
            }
            if(operacao != "invalida")
                Console.WriteLine($"Calculo: {num1} com {num2} = {resultado}");            
        }
    }
}
