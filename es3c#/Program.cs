Console.WriteLine("inserisci due numeri");
string? num1 = Console.ReadLine();
string? num2 = Console.ReadLine();
int parsed1 = int.Parse(num1);
int parsed2 = int.Parse(num2);
int result = parsed1 + parsed2;
Console.WriteLine($"il risultato è {result}");