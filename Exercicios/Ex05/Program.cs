
using System.Text;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite uma palavra ou frase:");
        string input = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("Entrada inválida. Por favor, digite algo.");
            return;
        }

        string normalizedInput = RemoverAcentos(input.ToLower().Replace(" ", ""));
        string textoFiltrado = new string(normalizedInput.Reverse().ToArray());

        if (normalizedInput == textoFiltrado)
        {
            Console.WriteLine("É um palíndromo!");
        }
        else
        {
            Console.WriteLine("Não é um palíndromo.");
        }
    }

    static string RemoverAcentos(string texto)
    {
        var textoForm = texto.Normalize(NormalizationForm.FormD);
        var sb = new StringBuilder();

        foreach (char c in textoForm)
        {
            var unicode = CharUnicodeInfo.GetUnicodeCategory(c);
            if (unicode != UnicodeCategory.NonSpacingMark)
            {
                sb.Append(c);
            }
        }

        return sb.ToString().Normalize(NormalizationForm.FormC);
    }
}