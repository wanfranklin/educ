int numero = 10;

for (int i = 0; i < numero; i++)
{
    Console.WriteLine(i);
}

Parallel.For(0, numero, i =>
{
    Console.WriteLine($"Thread {i} executando.");
});
