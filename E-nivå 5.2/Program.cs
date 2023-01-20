int[] tal = new int[3];

tal[0] = 5;
tal[1] = 10;

{
    Console.WriteLine("Första tal "+ tal[0]);
    Console.WriteLine("Andra tal "+ tal[1]);
    Console.WriteLine("Skriv in det tredje talet");
}
tal[2] = int.Parse(Console.ReadLine());
{
    Console.WriteLine($"Alla talen i programmet {tal[0]}, {tal[1]}, {tal[2]}");
}

