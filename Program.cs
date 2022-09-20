using Menu_Interativo.Models;

//Apresentação do Programa
Console.WriteLine("---------------------------");
Console.WriteLine("    Calculadora 2000");
Console.WriteLine("---------------------------");

Console.WriteLine("Olá seja bem vindo a Calculadora 2000, qual seu nome?: ");
string? nome = Console.ReadLine();
Console.WriteLine($"{nome}, vamos começar, deseja iniciar a calculadora? [s/n]");
string? inicia = Console.ReadLine();

//Inicio do Funcionamento do Programa

while (inicia == "s") 
{
    Console.WriteLine("Escolha uma opção:\n[1] Soma\n[2] Subtração\n[3] Divisão\n[4] Multplicação\n[5] Sair");
    int opcao = int.Parse(Console.ReadLine());
    if (opcao == 1)
    {
        Calculadora Soma = new Calculadora();
        Console.WriteLine("Digite um numero: ");
        Soma.numero1 = 
        Console.WriteLine("Digite outro numero: ");
    }

Console.WriteLine("Progama encerrado.");