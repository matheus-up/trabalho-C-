Console.WriteLine("Informe os 10 numeros:");
int[] numeros = new int[10];
for (int i = 0; i < 10; i++)
{
    numeros[i] = int.Parse(Console.ReadLine());
}

int soma = 0;

for(int i = 0; i < numeros.Length; i++){
    if(numeros[i] % 2 == 0){
        soma += numeros[i];
    }

}

Console.WriteLine($"A Soma dos numero pares é : {soma}.");

