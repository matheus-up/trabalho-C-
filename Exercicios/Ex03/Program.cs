using System.ComponentModel;

int numero;
Console.WriteLine("Informe um numero inteiro e positivo.");
string input1 = Console.ReadLine();



while(!int.TryParse(input1, out numero) || numero < 0){
    Console.WriteLine("Entrada Inválida! Por favor, digite um numero inteiro **POSITIVO**.");
    Console.WriteLine("Tente Novamente");
    input1 = Console.ReadLine();
}

long fatorial = 1;
int contador = numero;

while(contador > 1){
    fatorial *= contador;
    contador--;
}

Console.WriteLine($"\nFatorial de {numero} é: {fatorial}");