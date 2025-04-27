using System.Text.RegularExpressions;

Console.WriteLine("Informe uma senha: ");
string senha = Console.ReadLine();

if(SenhaEhForte(senha)){
    Console.WriteLine("Senha Válida!");
}
else{
            Console.WriteLine("Senha inválida! ❌");
            Console.WriteLine("A senha deve conter:");
            Console.WriteLine("- Mínimo de 8 caracteres");
            Console.WriteLine("- Pelo menos uma letra maiúscula");
            Console.WriteLine("- Pelo menos um número");
            Console.WriteLine("- Pelo menos um caractere especial (!, @, #, etc)");
}


static bool SenhaEhForte(string senha){
    if(senha.Length < 8){
        return false;

    }
        bool temMaiuscula = Regex.IsMatch(senha, "[A-Z]");
        bool temNumero = Regex.IsMatch(senha, "[0-9]");
        bool temEspecial = Regex.IsMatch(senha, "[!@#$%&*(),.?:{}|<>]");

        return temMaiuscula && temNumero && temEspecial;    
    }


