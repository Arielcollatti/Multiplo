// Determine se um número é múltiplo de outro.
Console.WriteLine("--- Multiplo ---\n");

Console.Write("Digite um numero...........: ");
int n1 = int.Parse(Console.ReadLine()!); 

Console.Write("Avaliar se é múltiplo de...: ");
int n2 = int.Parse(Console.ReadLine()!); 

if(n1 % n2 == 0)
{
    Console.WriteLine($"{n1} é multiplo de {n2}");
}
else
{
    Console.WriteLine($"{n1} não é multiplo de {n2}");
}