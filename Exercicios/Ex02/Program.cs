using System.Runtime.ExceptionServices;

Console.Write("Digite um numero para ver a tabuada:");
string entrada = Console.ReadLine();

if(int.TryParse(entrada, out int numero)){
    Console.WriteLine($"\nTabuada do {numero}: \n");

    for(int i = 1; i<=10; i++){
        Console.WriteLine($"{numero} x {i} = {numero * i}");
    }

}else{
    Console.WriteLine("Entrada Inválida! Por favor digite o numero inteiro!");
}