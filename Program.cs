using Menu_Interativo.Models;


//Apresentação do Programa
Console.WriteLine("---------------------------");
Console.WriteLine("    Calculadora 2000");
Console.WriteLine("---------------------------");

Console.WriteLine("Olá seja bem vindo a Calculadora 2000, qual seu nome?: ");
string nome = Console.ReadLine();
Console.WriteLine($"{nome}, vamos começar, deseja iniciar a calculadora? [s/n]");
string inicia = Console.ReadLine().ToUpper();

Calculadora Calcula = new Calculadora();

string opcao = string.Empty;

while (inicia == "S")
{
    Console.Clear();
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("[1] SOMA");
    Console.WriteLine("[2] SUBTRAÇÃO");
    Console.WriteLine("[3] DIVISÃO");
    Console.WriteLine("[4] MULTIPLICAÇÃO");
    Console.WriteLine("[5] ENCERRAR");

    switch (Console.ReadLine())
    {
        case "1":
            Calcula.ApresentarSoma();
            break;
        
        case "2":
            Calcula.ApresentarSubtracao();
            break;

        case "3":
            Calcula.ApresentarDivisao();
            break;
        
        case "4":
            Calcula.ApresentarMultiplicacao();
            break;

        case "5":
            inicia = "n";
            break;
    }

    Console.WriteLine("Aperte uma tecla para continuar");
    Console.ReadLine();
}

Console.WriteLine("O programa se encerrou");


