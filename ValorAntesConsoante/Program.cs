string texto;
char x;
string vogal = "aeiouAEIOU";
string consoante = "bcdfghjklmnpqrstvwxyzBCDFGHJKLMNPQRSTVWYZ";

Console.WriteLine("Digite o texto que sera usado: ");
texto = Console.ReadLine();
Console.WriteLine("Digite o caracter que sera usado: ");
x = char.Parse(Console.ReadLine());


for (int i = 0; i < texto.Length; i++)
{
    if (vogal.Contains(texto[i]))
    {
        Console.Write(texto[i]);
    }
    else if (consoante.Contains(texto[i]))
    {
        Console.Write(x.ToString() + texto[i].ToString());
    }
    else {
        Console.Write(texto[i]);
    }
}

