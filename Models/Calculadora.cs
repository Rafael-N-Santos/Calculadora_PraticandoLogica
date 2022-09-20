using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Menu_Interativo.Models
{
    public class Calculadora
    {
        public float Somatoria { get; set; }
        float numero1, numero2;
        public void ApresentarSoma()
        {
            float somaResultado = numero1 + numero2;
            Console.WriteLine($"O resultado da soma entre {numero1} e {numero2} é: {somaResultado.ToString("f")}");
        }

        public float Subtracao { get; set; }
        float numeroSubtracao1, numeroSubtracao2;
        public void ApresentarSubtracao()
        {
            float subtracaoResultado = numeroSubtracao1 - numeroSubtracao2;
            Console.WriteLine($"O resultado da subtração entre {numeroSubtracao1} e {numeroSubtracao2} é: {subtracaoResultado.ToString("f")}");
        }

        public float Divisao { get; set; }
        float numeroDivisao1, numeroDivisao2;
        public void ApresentarDivisao()
        {
            float divisaoResultado = numeroDivisao1 / numeroDivisao2;
            Console.WriteLine($"O resultado da divisão entre {numeroDivisao1} e {numeroDivisao2} é: {divisaoResultado}");
        }


        public float Multiplicacao { get; set; }
        float numeroMultiplicacao1, numeroMultiplicacao2;
        public void ApresentarMultiplicacao()
        {
            float multiplicacaoResultado = numeroMultiplicacao1 * numeroMultiplicacao2;
            Console.WriteLine($"O resultado da multiplicação entre {numeroMultiplicacao1} e {numeroMultiplicacao2} é: {multiplicacaoResultado}");
        }
    }
}