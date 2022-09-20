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
    Console.WriteLine("Escolha uma opção:\n[1] Soma\n[2] Subtração\n[3] Divisão\n[4] Multplicação");
    string? opcao = Console.ReadLine();
    if (opcao == 1)
    {

    }
}

Console.WriteLine("Progama encerrado.");