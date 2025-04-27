using System;

Random random = new Random();
int numeroSecreto = random.Next(1, 101); // Gera número de 1 a 100
int tentativa;
int tentativas = 0;

Console.WriteLine("Jogo da Adivinhação!");
Console.WriteLine("Tente adivinhar o número entre 1 e 100.");

do
{
    Console.Write("Digite sua tentativa: ");
    tentativa = int.Parse(Console.ReadLine());
    tentativas++;

    if (tentativa < numeroSecreto)
    {
        Console.WriteLine("O número secreto é MAIOR!");
    }
    else if (tentativa > numeroSecreto)
    {
        Console.WriteLine("O número secreto é MENOR!");
    }
    else
    {
        Console.WriteLine($"\nParabéns! Você acertou o número {numeroSecreto}.");
        Console.WriteLine($"Total de tentativas: {tentativas}");
    }

} while (tentativa != numeroSecreto);
