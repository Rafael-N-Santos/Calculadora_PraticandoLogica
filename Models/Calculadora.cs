using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Menu_Interativo.Models
{
    public class Calculadora
    {
        public decimal Somatoria { get; set; }
        decimal numero1, numero2;
        public void ApresentarSoma()
        {
            Console.Write("Digite um numero: ");
            numero1 = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Digite um numero: ");
            numero2 = Convert.ToDecimal(Console.ReadLine());

            decimal somaResultado = numero1 + numero2;
            Console.WriteLine($"O resultado da soma entre {numero1} e {numero2} é: {somaResultado.ToString("f")}");
        }

        public decimal Subtracao { get; set; }
        decimal numeroSubtracao1, numeroSubtracao2;
        public void ApresentarSubtracao()
        {
            Console.Write("Digite um numero: ");
            numeroSubtracao1 = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Digite um numero: ");
            numeroSubtracao2 = Convert.ToDecimal(Console.ReadLine());

            decimal subtracaoResultado = numeroSubtracao1 - numeroSubtracao2;
            Console.WriteLine($"O resultado da subtração entre {numeroSubtracao1} e {numeroSubtracao2} é: {subtracaoResultado.ToString("f")}");
        }

        public decimal Divisao { get; set; }
        decimal numeroDivisao1, numeroDivisao2;
        public void ApresentarDivisao()
        {
            Console.Write("Digite um numero: ");
            numeroDivisao1 = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Digite um numero: ");
            numeroDivisao2 = Convert.ToDecimal(Console.ReadLine());

            decimal divisaoResultado = numeroDivisao1 / numeroDivisao2;
            Console.WriteLine($"O resultado da divisão entre {numeroDivisao1} e {numeroDivisao2} é: {divisaoResultado}");
        }


        public decimal Multiplicacao { get; set; }
        decimal numeroMultiplicacao1, numeroMultiplicacao2;
        public void ApresentarMultiplicacao()
        {
            Console.Write("Digite um numero: ");
            numeroMultiplicacao1 = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Digite um numero: ");
            numeroMultiplicacao2 = Convert.ToDecimal(Console.ReadLine());

            decimal multiplicacaoResultado = numeroMultiplicacao1 * numeroMultiplicacao2;
            Console.WriteLine($"O resultado da multiplicação entre {numeroMultiplicacao1} e {numeroMultiplicacao2} é: {multiplicacaoResultado}");
        }
    }
}