string original, resultante;
string vogal = "aeiouAEIOU";
string consoante = "bcdfghjklmnpqrstvwxyzBCDFGHJKLMNPQRSTVWYZ";

Console.WriteLine("Digite o texto que sera usado: ");
original = Console.ReadLine();

//Console.WriteLine("Digite o caracter que sera usado: ");
//x = char.Parse(Console.ReadLine());

resultante = InsereCaracter(original);
Console.WriteLine(resultante);

string InsereCaracter(string original)
{
    char[] aux = new char[original.Length*2];
    string alterada = "";
    for (int i = 0, j=0; i < original.Length; i++)
    {
        if ((original[i] != 'a') && (original[i] != 'e') &&(original[i] != 'i') && (original[i] != 'o') && (original[i] != 'u'))
        {
            aux[j+1] = original[i];
            aux[j] = '.';
            j = j +2;
        }
        else
        {
            aux[j] = original[i];
            j++;
        }
    }
    for (int i = 0; i < aux.Length; i++)
    {
        alterada += aux[i];
    }
    return alterada;
}

